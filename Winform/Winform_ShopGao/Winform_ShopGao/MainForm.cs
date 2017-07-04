using BusinessLogicLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Winform_ShopGao
{
    public partial class MainForm : Form
    {
        private readonly SupplierBusinessLogic _supplierBusinessLogic;
        private readonly ProductBusinessLogic _productBusinessLogic;
        private readonly UserBusinessLogic _userBusinessLogic;
        private readonly BillBusinessLogic _billBusinessLogic;
        private readonly ShipperBussinessLogic _shipperBusinessLogic;
        private readonly ProductTypeBusinessLogic _productTypeBusinessLogic;

        public MainForm()
        {
            InitializeComponent();
            _supplierBusinessLogic = new SupplierBusinessLogic();
            _productBusinessLogic = new ProductBusinessLogic();
            _userBusinessLogic = new UserBusinessLogic();
            _billBusinessLogic = new BillBusinessLogic();
            _shipperBusinessLogic = new ShipperBussinessLogic();
            _productTypeBusinessLogic = new ProductTypeBusinessLogic();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            tabPaneMainForm.SelectedPage = tabNaviPage_NhaCungCap;
            var suppliers = _supplierBusinessLogic.GetallSupplier();
            supplierGridControl.DataSource = suppliers.ToList();
            supplierGridControl.Refresh();
        }

        private void newSupp_Click(object sender, EventArgs e)
        {
            var newSupplierForm = new NewSupplierForm { RefToFormMain = this };
            newSupplierForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var row = supplierGridControl.SelectedRows;
                var cells = row[0].Cells;
                var newSupplierForm = new NewSupplierForm(int.Parse(cells[0].Value.ToString())) { RefToFormMain = this };
                newSupplierForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Please select row");
            }
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible) return;
            if (tabPaneMainForm.SelectedPage == tabNaviPage_NhaCungCap)
            {
                supplierGridControl.DataSource = _supplierBusinessLogic.GetallSupplier();
            }
        }

        private void tabNavigationPage2_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_SanPham) return;
            productGridView.DataSource = _productBusinessLogic.GetAllProduct();
            productGridView.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newProductForm = new NewProductForm { RefToFormMain = this };
            newProductForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var row = productGridView.SelectedRows;
                var cells = row[0].Cells;
                var newSupplierForm = new NewProductForm(int.Parse(cells[0].Value.ToString())) { RefToFormMain = this };
                newSupplierForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Please select row");
            }
        }
        
        private void Users_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_KhachHang) return;
            userGridView.DataSource = _userBusinessLogic.GetAllUser();
            userGridView.Refresh();
        }
        
        private void tabNavigationPage3_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_DonHang) return;
            GridView_Bills.DataSource = _billBusinessLogic.GetAllBill();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var row = GridView_Bills.SelectedRows;
                var cells = row[0].Cells;
                var billDetailForm = new BillDetailForm(int.Parse(cells[0].Value.ToString()), int.Parse(cells[1].Value.ToString()), int.Parse(cells[10].Value.ToString())) { RefToFormMain = this };
                billDetailForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Please select row");
            }
        }

        private void tabNavigationPage4_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_NhapHang) return;
            dataGridView2.DataSource = _productBusinessLogic.GetAllImportValueObjects();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var importProduct = new ImportProduct { RefToFormMain = this };
            importProduct.Show();
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            //show form chang pass
            var changePassForm = new ChangePassForm { RefToFormMain = this };
            changePassForm.Show();
        }

        private void tabNaviPage_Shipper_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_GiaoHang) return;
            GridView_Shippers.DataSource = _shipperBusinessLogic.GetAllShippers();
        }

        private void btn_InsertShipper_Click(object sender, EventArgs e)
        {
            var newShipperForm = new NewShipperForm { RefToFormMain = this };
            newShipperForm.Show();
        }

        private void btn_EditShipper_Click(object sender, EventArgs e)
        {
            try
            {
                var row = GridView_Shippers.SelectedRows;
                var cells = row[0].Cells;
                var newShipperForm = new NewShipperForm(int.Parse(cells[0].Value.ToString())) { RefToFormMain = this };
                newShipperForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Please select row");
            }
        }

        private void btn_InsertProductType_Click(object sender, EventArgs e)
        {
            var newProductType = new NewProductTypeForm { RefToPreForm = this };
            newProductType.Show();
        }

        private void btn_EditProductType_Click(object sender, EventArgs e)
        {
            try
            {
                var row = GridView_ProductType.SelectedRows;
                var cells = row[0].Cells;
                var newProductType = new NewProductTypeForm(int.Parse(cells[0].Value.ToString())) { RefToPreForm = this };
                newProductType.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Please select row");
            }
        }

        private void tabNaviPage_ProductType_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_LoaiSanPham) return;
            GridView_ProductType.DataSource = _productTypeBusinessLogic.GetAllProductTypes();
        }

        private void btn_RefreshDataSupplier_Click(object sender, EventArgs e)
        {
            supplierGridControl.DataSource = _supplierBusinessLogic.GetallSupplier();
        }

        private void tabNaviPage_NhaCungCap_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_NhaCungCap) return;
            supplierGridControl.DataSource = _supplierBusinessLogic.GetallSupplier();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
