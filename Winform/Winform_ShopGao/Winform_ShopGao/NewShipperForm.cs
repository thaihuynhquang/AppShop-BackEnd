using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;

namespace Winform_ShopGao
{
    public partial class NewShipperForm : Form
    {
        private readonly bool _isUpdate = false;
        private readonly int _rowId;
        public Form RefToFormMain { get; set; }

        private readonly ShipperBussinessLogic _shipperBussinessLogic;

        public NewShipperForm(int? rowId = null)
        {
            InitializeComponent();
            _shipperBussinessLogic = new ShipperBussinessLogic();
            if (rowId == null) return;
            btn_InsertShipper.Text = @"Cập nhật";
            _isUpdate = true;
            _rowId = (int)rowId;

            var shipper = _shipperBussinessLogic.GetDetailShipper(_rowId);
            txtB_NameShipper.Text = shipper.Name;
            txt_EmailShipper.Text = shipper.Email;
            txt_PhoneShipper.Text = shipper.Phone;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }

        private void btn_InsertShipper_Click(object sender, EventArgs e)
        {
            var shipperValueObject = new ShipperValueObject(_isUpdate ? _rowId : 0, txtB_NameShipper.Text.Trim(), txt_EmailShipper.Text.Trim(), txt_PhoneShipper.Text.Trim());
            var success = _isUpdate ? _shipperBussinessLogic.UpdateSupplier(shipperValueObject) : _shipperBussinessLogic.CreateShipper(shipperValueObject);

            MessageBox.Show(success ? "Thành công." : "Thất bại");
        }
    }
}
