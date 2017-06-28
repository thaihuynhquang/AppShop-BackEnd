using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using DAO;

namespace Winform_ShopGao
{
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userDataAccessLayer = new UserDataAccessLayer();
            var  x = userDataAccessLayer.Login(txtB_Username.Text.Trim(), txtB_Password.Text.Trim());
            if (!x)
            {
                MessageBox.Show("login fail");
            }

            var  mainForm = new MainForm();
            mainForm.Show();

            this.Hide();
        }
    }
}
