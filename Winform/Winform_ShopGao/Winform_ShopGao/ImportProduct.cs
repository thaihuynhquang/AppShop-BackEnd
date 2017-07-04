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
        private ImportBusinessLogic _importBusinessLogic;

        public ImportProduct()
        {
            InitializeComponent();
            _supplierBusinessLogic = new SupplierBusinessLogic();
            _productBusinessLogic = new ProductBusinessLogic();
            _importBusinessLogic = new ImportBusinessLogic();
        }

        public MainForm RefToFormMain { get; set; }

        private void ImportProduct_Load(object sender, EventArgs e)
        {
            // combo box nha cung cap
            cmb_Supplier.DisplayMember = "name";
            cmb_Supplier.ValueMember = "id";
            cmb_Supplier.DataSource = _supplierBusinessLogic.GetallSupplier();


            // combo box san pham
            cmn_Product.DisplayMember = "name";
            cmn_Product.ValueMember = "id";
            cmn_Product.DataSource = _productBusinessLogic.GetAllProduct();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int supplierId = (int)cmb_Supplier.SelectedValue;
            int productId = (int)cmn_Product.SelectedValue;
            int unitInStock = Convert.ToInt32(txtB_UnitInStock.Text);
            int unitPrice = Convert.ToInt32(txtB_UnitPrice.Text);

            var supplier = _supplierBusinessLogic.GetDetailSupplier(supplierId);
            string supplierName = supplier.Name;

            var product = _productBusinessLogic.GetProductById(productId);
            string productName = product.Name;

            var import = new ImportValueObject(0, supplierId, supplierName, productId, productName, unitInStock, 0, unitPrice, 0);
            var success = _importBusinessLogic.ImportProduct(import);
            MessageBox.Show(success ? "Thành công." : "Thất bại");
            
        }
    }
}
