using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using ValueObject;
using System.Net.Http;
using System.Transactions;

namespace Winform_ShopGao
{
    public partial class NewProductForm : Form
    {
        private readonly ProductTypeBusinessLogic _productTypeBusinessLogic;
        private readonly ProductBusinessLogic _productBusinessLogic;
        private readonly bool _isUpdate;
        private readonly int _rowId;
        private string _filePath;
        private static readonly HttpClient Client = new HttpClient();


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

        private async void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text.Trim();
            var price = int.Parse(textBox2.Text.Trim());
            var type = int.Parse(cmbProductType.SelectedValue.ToString());
            var des = richTextBox1.Text.Trim();
            var isNew = checkBox1.Checked ? 1 : 0;
            var collection = int.Parse(textBox3.Text.Trim());
            var productValueObject = new ProductValueObject(_isUpdate ? _rowId : 0, name, type, price, des, isNew, collection,0);
            using (var tran = new TransactionScope()){
               


                //var values = new Dictionary<string, string>
                //{
                //    { "thing1", "hello" },
                //    { "thing2", "world" }
                //};

                //var content = new FormUrlEncodedContent(values);

                //var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);

                //var responseString = await response.Content.ReadAsStringAsync();

                 var success = _isUpdate ? _productBusinessLogic.UpdateProduct(productValueObject) : _productBusinessLogic.CreateNewProduct(productValueObject);
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
    }
}
