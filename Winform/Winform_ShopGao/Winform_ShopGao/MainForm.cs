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

namespace Winform_ShopGao
{
    public partial class MainForm : Form
    {
        private SupplierBusinessLogic _supplierBusinessLogic;
        public MainForm()
        {
            InitializeComponent();
            _supplierBusinessLogic = new SupplierBusinessLogic();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabPane1_Click(object sender, EventArgs e)
        {
            var suppliers = _supplierBusinessLogic.GetallSupplier();
            supplierGridControl.DataSource = suppliers.Select(x => new { Id = x.GetId(), Name = x.GetName(), Address = x.GetAddress() }).ToList();
            supplierGridControl.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabPane1.SelectedPage = tabNavigationPage1;
        }

        private void newSupp_Click(object sender, EventArgs e)
        {
            var newSupplierForm = new NewSupplierForm { RefToFormMain = this };
            newSupplierForm.Show();
            this.Hide();
        }
    }
}
