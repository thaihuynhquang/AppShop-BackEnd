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

            comboBox1.DataSource = _userBusinessLogic.GetAllUser();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userId = (int) comboBox1.SelectedValue;
            int total = Convert.ToInt32(textBox1.Text);
            string addr = textBox2.Text.Trim();
            int status = Convert.ToInt32(textBox3.Text);
            string note = richTextBox1.Text.Trim();
            var date = dateEdit1.DateTime;

            var bill = new BillValueObject(null,userId,date,total,addr,note,status);
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
