using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using BusinessLogicLayer;
using Newtonsoft.Json;
using ValueObject;

namespace Winform_ShopGao
{
    public partial class NewProductType : Form
    {
        private string _filePath;
        private bool _isUpdate = false;
        private readonly ProductBusinessLogic _productBusinessLogic;

        public NewProductType()
        {
            InitializeComponent();
            _productBusinessLogic = new ProductBusinessLogic();
        }

        public NewProductForm RefToPreForm { get; set; }

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            RefToPreForm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text.Trim();
            using (var tran = new TransactionScope())
            {
                const string actionUrl = "http://localhost:4000/api/upload_image_productType";

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
                ProductTypeValueObject productValueObject = new ProductTypeValueObject(null, name, fileNameInServer);
                var success = _isUpdate ? _productBusinessLogic.UpdateProductType(productValueObject) : _productBusinessLogic.CreateNewProductType(productValueObject);
                MessageBox.Show(success ? "Success" : "Fail");
                tran.Complete();
            }
        }
    }
}
