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
        private readonly bool _isUpdate = false;
        private readonly int _rowId;
        private int _supplierId;
        private int _productId;
        private readonly SupplierBusinessLogic _supplierBusinessLogic;
        private readonly ProductBusinessLogic _productBusinessLogic;
        private readonly ImportBusinessLogic _importBusinessLogic;

        public ImportProduct(int? rowId = null, int? SupplierId = null, int? ProductId = null)
        {
            InitializeComponent();
            _supplierBusinessLogic = new SupplierBusinessLogic();
            _productBusinessLogic = new ProductBusinessLogic();
            _importBusinessLogic = new ImportBusinessLogic();

            btn_importProduct.Enabled = false;

            if (rowId == null || SupplierId == null || ProductId == null) return;
            btn_Unclock.Text = @"Chỉnh sửa";
            _isUpdate = true;
            _rowId = (int)rowId;
            _supplierId = (int)SupplierId;
            _productId = (int)ProductId;

            var supplier = _supplierBusinessLogic.GetDetailSupplier(_supplierId);
            txtB_SupplierName.Text = supplier.Name;
            txtB_SupplierEmail.Text = supplier.Email;
            txtB_SupplierPhone.Text = supplier.Phone;

            var product = _productBusinessLogic.GetProductById(_productId);
            txtB_ProductName.Text = product.Name;
            txtB_ProductPrice.Text = product.Price.ToString();
        }

        public MainForm RefToFormMain { get; set; }

        private void ImportProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int supplierId = (int)cmb_ChooseSupplier.SelectedValue;
            int productId = (int)cmb_ChooseProduct.SelectedValue;
            int unitInStock = Convert.ToInt32(txtB_UnitInStock.Text);
            int unitPrice = Convert.ToInt32(txtB_UnitPrice.Text);

            var supplier = _supplierBusinessLogic.GetDetailSupplier(supplierId);
            string supplierName = supplier.Name;

            var product = _productBusinessLogic.GetProductById(productId);
            string productName = product.Name;

            var import = new ImportValueObject(_isUpdate ? _rowId : 0, supplierId, supplierName, productId, productName, unitInStock, 0, unitPrice, 0);
            var success = _isUpdate ? _importBusinessLogic.UpdateImportProduct(import) : _importBusinessLogic.ImportProduct(import);
            MessageBox.Show(success ? "Thành công." : "Thất bại");
            
        }

        private void cmb_ChooseSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            _supplierId = (int)cmb_ChooseSupplier.SelectedValue;
            var supplier = _supplierBusinessLogic.GetDetailSupplier(_supplierId);
            txtB_SupplierName.Text = supplier.Name;
            txtB_SupplierEmail.Text = supplier.Email;
            txtB_SupplierPhone.Text = supplier.Phone;
        }

        private void cmn_ChooseProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            _productId = (int)cmb_ChooseProduct.SelectedValue;
            var product = _productBusinessLogic.GetProductById(_productId);
            txtB_ProductName.Text = product.Name;
            txtB_ProductPrice.Text = product.Price.ToString();
        }

        private void btn_Unclock_Click(object sender, EventArgs e)
        {
            // combo box nha cung cap
            cmb_ChooseSupplier.DisplayMember = "name";
            cmb_ChooseSupplier.ValueMember = "id";
            cmb_ChooseSupplier.DataSource = _supplierBusinessLogic.GetallSupplier();
            
            // combo box san pham
            cmb_ChooseProduct.DisplayMember = "name";
            cmb_ChooseProduct.ValueMember = "id";
            cmb_ChooseProduct.DataSource = _productBusinessLogic.GetAllProduct();

            btn_importProduct.Enabled = true;
        }
    }
}
