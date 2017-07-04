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
using DAO;
using DevExpress.Utils.Base;
using ValueObject;

namespace Winform_ShopGao
{
    public partial class NewSupplierForm : Form
    {
        private readonly bool _isUpdate;
        private readonly int _rowId;
        public Form RefToFormMain { get; set; }

        private readonly SupplierBusinessLogic _supplierBusinessLogic;

        public NewSupplierForm(int? rowId = null)
        {
            InitializeComponent();
            _supplierBusinessLogic = new SupplierBusinessLogic();
            if (rowId == null) return;
            btn_themNCC.Text = @"Cập nhật thay đổi";
            _isUpdate = true;
            _rowId = (int) rowId;

            var supplier = _supplierBusinessLogic.GetDetailSupplier(_rowId);
            txtB_TenNCC.Text = supplier.Name;
            txtB_DiaChiNCC.Text = supplier.Address;
            txtB_emailNCC.Text = supplier.Email;
            txtB_SđtNCC.Text = supplier.Phone;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var supplierValueObject = new SupplierValueObject(_isUpdate ? _rowId: 0, txtB_TenNCC.Text.Trim(), txtB_DiaChiNCC.Text.Trim(), txtB_emailNCC.Text.Trim(),txtB_SđtNCC.Text.Trim());
            var success = _isUpdate ? _supplierBusinessLogic.UpdateSupplier(supplierValueObject) : _supplierBusinessLogic.CreateSupplier(supplierValueObject);

            MessageBox.Show(success ? "Success" : "Fail");
        }

        
    }
}
