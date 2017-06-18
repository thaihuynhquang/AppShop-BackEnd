using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace Winform_ShopGao
{
    public partial class NewSupplierForm : Form
    {

        public Form RefToFormMain { get; set; }

        private SupplierDataAccessLayer _supplierDataAccessLayer;

        public NewSupplierForm()
        {
            InitializeComponent();
            _supplierDataAccessLayer = new SupplierDataAccessLayer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.RefToFormMain.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = _supplierDataAccessLayer.CreateNewSupplier(name.Text.Trim(), address.Text.Trim(), mail.Text.Trim(),
                  phone.Text.Trim());

            MessageBox.Show(x ? "Success" : "Fail");
        }
    }
}
