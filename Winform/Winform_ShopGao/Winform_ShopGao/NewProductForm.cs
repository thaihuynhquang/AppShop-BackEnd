using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using ValueObject;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Transactions;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Newtonsoft.Json;

namespace Winform_ShopGao
{
    public partial class NewProductForm : Form
    {
        private readonly ProductTypeBusinessLogic _productTypeBusinessLogic;
        private readonly ProductBusinessLogic _productBusinessLogic;
        private readonly bool _isUpdate;
        private readonly int _rowId;
        private string _filePath;
        private bool isUpdateImage;
        private ProductValueObject product = null;
       

        public Form RefToFormMain { get; set; }
        public NewProductForm(int? rowId = null)
        {
            InitializeComponent();
            isUpdateImage = false;
            _productTypeBusinessLogic = new ProductTypeBusinessLogic();
            _productBusinessLogic = new ProductBusinessLogic();

            var productTypes = _productTypeBusinessLogic.GetAllProductTypes();
            cmbProductType.DisplayMember = "Name";
            cmbProductType.ValueMember = "Id";
            cmbProductType.DataSource = productTypes;
            

            if (rowId == null) return;
            btn_NewProduct.Text = @"Cập nhật thay đổi";
            _isUpdate = true;
            _rowId = (int)rowId;


            product = _productBusinessLogic.GetProductById(rowId);
            
            txtB_ProductName.Text = product.Name;
            txtB_ProductPrice.Text = product.Price.ToString();
            cmbProductType.SelectedValue = product.IdType;
            chB_TopProduct.Checked = product.Inew == 1;
            rTxtB_DescriptionProduct.Text = product.Description;
            
            try
            {
                var image= GetImage(rowId);
                picB_ImageProduct.Image = image;
                picB_ImageProduct.SizeMode = PictureBoxSizeMode.CenterImage;
                picB_ImageProduct.BackColor = Color.AliceBlue;
            }
            catch (Exception e)
            {
               // do not thing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            var name = txtB_ProductName.Text.Trim();
            var price = int.Parse(txtB_ProductPrice.Text.Trim());
            var type = int.Parse(cmbProductType.SelectedValue.ToString());
            var des = rTxtB_DescriptionProduct.Text.Trim();
            var isNew = chB_TopProduct.Checked ? 1 : 0;
            var productValueObject = new ProductValueObject(_isUpdate ? _rowId : 0, name, type, price, des, isNew);
            using (var tran = new TransactionScope())
            {
                ImageValueObject image = null;
                if (isUpdateImage)
                {
                    const string actionUrl = "http://localhost:4000/api/upload_image_product";
                    var fileStream = File.OpenRead(_filePath);
                    string fileNameInServer;
                    HttpContent fileStreamContent = new StreamContent(fileStream);
                    using (var client = new HttpClient())
                    {
                        using (var formData = new MultipartFormDataContent())
                        {
                            formData.Add(fileStreamContent, "image", "image.jpg");
                            var response = client.PostAsync(actionUrl, formData).Result;

                            var receiveStream = response.Content.ReadAsStreamAsync().Result;
                            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                            var message = readStream.ReadToEnd();
                            dynamic stuff = JsonConvert.DeserializeObject(message);
                            string mess = stuff.msg.ToString();
                            if (mess.Equals("Error"))
                            {
                                MessageBox.Show(@"Error whern upload image ");
                                return;
                            }
                            fileNameInServer = stuff.link.ToString();
                        }
                    }
                    image = new ImageValueObject(null, fileNameInServer, productValueObject.Id);
                }
                
                var success = _isUpdate ? _productBusinessLogic.UpdateProduct(productValueObject,image) : _productBusinessLogic.CreateNewProduct(productValueObject,image);
                MessageBox.Show(success ? "Success" : "Fail");
                tran.Complete();
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = @"Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "Image",
                Filter = @"Picture files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            _filePath = openFileDialog1.FileName;
            picB_ImageProduct.SizeMode = PictureBoxSizeMode.CenterImage;
            picB_ImageProduct.Image = Image.FromFile(openFileDialog1.FileName);
            picB_ImageProduct.BackColor = Color.AliceBlue;
            isUpdateImage = true;
        }

        private  Image GetImage(int? id)
        {
            var imageFile = _productBusinessLogic.GetImageFileName(id);

            byte[] lnFile;

            var lxRequest = (HttpWebRequest)WebRequest.Create("http://localhost:4000/api/images/product/"+imageFile);
            using (var lxResponse = (HttpWebResponse)lxRequest.GetResponse())
            {
                using (var lxBr = new BinaryReader(lxResponse.GetResponseStream()))
                {
                    using (var lxMs = new MemoryStream())
                    {
                        var lnBuffer = lxBr.ReadBytes(1024);
                        while (lnBuffer.Length > 0)
                        {
                            lxMs.Write(lnBuffer, 0, lnBuffer.Length);
                            lnBuffer = lxBr.ReadBytes(1024);
                        }
                        lnFile = new byte[(int)lxMs.Length];
                        lxMs.Position = 0;
                        lxMs.Read(lnFile, 0, lnFile.Length);
                    }
                }
            }

            using (var lxFs = new FileStream("xxxx.jpg", FileMode.Create))
            {
                lxFs.Write(lnFile, 0, lnFile.Length);
            }
            using (var ms = new MemoryStream(lnFile))
            {
                return Image.FromStream(ms);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newProductType = new NewProductTypeForm {RefToPreForm = this};
            newProductType.Show();
            Hide();
        }

        private void NewProductForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                cmbProductType.DataSource = _productTypeBusinessLogic.GetAllProductTypes();
                if (product!= null)
                {
                    cmbProductType.SelectedValue = product.IdType;
                   
                }
            }
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
