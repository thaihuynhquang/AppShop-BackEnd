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
       

        public Form RefToFormMain { get; set; }
        public NewProductForm(int? rowId = null)
        {
            InitializeComponent();
            _productTypeBusinessLogic = new ProductTypeBusinessLogic();
            _productBusinessLogic = new ProductBusinessLogic();

            if (rowId == null) return;
            button1.Text = @"Update";
            _isUpdate = true;
            _rowId = (int)rowId;

            var productTypes = _productTypeBusinessLogic.GetAllProductType();
            cmbProductType.DataSource = productTypes;
            cmbProductType.DisplayMember = "name";
            cmbProductType.ValueMember = "id";


            var product = _productBusinessLogic.GetProductById(rowId);
            textBox1.Text = product.Name;
            textBox2.Text = product.Price.ToString();
            textBox3.Text = product.Collection.ToString();
            cmbProductType.SelectedIndex = product.IdType;
            checkBox1.Checked = product.Inew == 1;
            richTextBox1.Text = product.Description;
            try
            {
                var image= GetImage(rowId);
                pictureBox1.Image = image;
            }
            catch (Exception e)
            {
               // do not thing
            }
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            var productTypes = _productTypeBusinessLogic.GetAllProductType();
            cmbProductType.DataSource = productTypes;
            cmbProductType.DisplayMember = "name";
            cmbProductType.ValueMember = "id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text.Trim();
            var price = int.Parse(textBox2.Text.Trim());
            var type = int.Parse(cmbProductType.SelectedValue.ToString());
            var des = richTextBox1.Text.Trim();
            var isNew = checkBox1.Checked ? 1 : 0;
            var collection = int.Parse(textBox3.Text.Trim());
            var productValueObject = new ProductValueObject(_isUpdate ? _rowId : 0, name, type, price, des, isNew, collection,0);
            using (var tran = new TransactionScope())
            {

                var actionUrl = "http://localhost:4000/api/upload_image_product";
              
                var fileStream = File.OpenRead(_filePath);
                string fileNameInServer = string.Empty;
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
                            MessageBox.Show("Error whern upload image ");
                            return;
                        }
                        fileNameInServer = stuff.link.ToString();
                    }
                }
                var image = new ImageValueObject(null,fileNameInServer,productValueObject.Id);
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
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.BackColor = Color.White;
        }

        private static Image GetImage(int? id)
        {
            byte[] lnFile;

            var lxRequest = (HttpWebRequest)WebRequest.Create("http://www.productimageswebsite.com/images/stock_jpgs/"+id+".jpg");
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

        
    }
}
