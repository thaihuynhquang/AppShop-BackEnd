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
            button1.Text = @"Update";
            _isUpdate = true;
            _rowId = (int) rowId;

            var supplier = _supplierBusinessLogic.GetDetailSupplier(_rowId);
            name.Text = supplier._name;
            address.Text = supplier._address;
            mail.Text = supplier._email;
            phone.Text = supplier._phone;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.RefToFormMain.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var supplierValueObject = new SupplierValueObject(_isUpdate ? _rowId: 0, name.Text.Trim(), address.Text.Trim(), mail.Text.Trim(),phone.Text.Trim());
            var success = _isUpdate ? _supplierBusinessLogic.UpdateSupplier(supplierValueObject) : _supplierBusinessLogic.CreateSupplier(supplierValueObject);

            MessageBox.Show(success ? "Success" : "Fail");
        }

        
    }
}
