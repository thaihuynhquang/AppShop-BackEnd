using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using ValueObject;

namespace Winform_ShopGao
{
    public partial class ImportProduct : Form
    {
        private SupplierBusinessLogic _supplierBusinessLogic;
        private ProductBusinessLogic _productBusinessLogic;
      
        public ImportProduct()
        {
            InitializeComponent();
            _supplierBusinessLogic = new SupplierBusinessLogic();
            _productBusinessLogic = new ProductBusinessLogic();
        }

        public MainForm RefToFormMain { get; set; }

        private void ImportProduct_Load(object sender, EventArgs e)
        {
            // combo box nha cung cap
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = _supplierBusinessLogic.GetallSupplier();


            // combo box san pham
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";
            comboBox2.DataSource = _productBusinessLogic.GetAllProduct();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idNcc = (int) comboBox1.SelectedValue;
                int idSp = (int) comboBox2.SelectedValue;
                int sl = Convert.ToInt32(textBox1.Text);
                int dongia = Convert.ToInt32(textBox2.Text);

                // luu xuong data base
                 _productBusinessLogic.ImportProduct(idSp, idNcc, sl, dongia);
                MessageBox.Show("Success");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
