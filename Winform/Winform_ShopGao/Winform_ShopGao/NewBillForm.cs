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
    public partial class NewBillForm : Form
    {
        private UserBusinessLogic _userBusinessLogic;
        private BillBusinessLogic _billBusinessLogic;

        public Form RefToFormMain { get; set; }

        public NewBillForm()
        {
            InitializeComponent();
            _userBusinessLogic = new UserBusinessLogic();
            _billBusinessLogic= new BillBusinessLogic();

            cmbB_Customer.DataSource = _userBusinessLogic.GetAllUser();
            cmbB_Customer.DisplayMember = "name";
            cmbB_Customer.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userId = (int) cmbB_Customer.SelectedValue;
            int total = Convert.ToInt32(txtB_Total.Text);
            string addr = txtB_Address.Text.Trim();
            string dis = txtB_District.Text.Trim();
            string city = txtB_City.Text.Trim();
            int status = Convert.ToInt32(txtB_Status.Text);
            string note = rtxtB_Note.Text.Trim();
            var orderDate = dateEdit_OrderDate.DateTime;
            var expOrderDate = dateEdit_ExpOrderDate.DateTime;

            var bill = new BillValueObject(null, userId, orderDate, expOrderDate, total, addr, dis, city, note, status, 0);
           var success = _billBusinessLogic.CreateNewBill(bill);
            MessageBox.Show(success ? "Success" : "Fail");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }
    }
}
