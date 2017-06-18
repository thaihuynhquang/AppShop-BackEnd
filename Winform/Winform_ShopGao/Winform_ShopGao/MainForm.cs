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
using DevExpress.Utils.Extensions;
using ValueObject;

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
            supplierGridControl.DataSource = suppliers.ToList();
            supplierGridControl.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabPane1.SelectedPage = tabNavigationPage1;
            var suppliers = _supplierBusinessLogic.GetallSupplier();
            supplierGridControl.DataSource = suppliers.ToList();
            supplierGridControl.Refresh();
        }

        private void newSupp_Click(object sender, EventArgs e)
        {
            var newSupplierForm = new NewSupplierForm { RefToFormMain = this };
            newSupplierForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var row = supplierGridControl.SelectedRows;
                var cells = row[0].Cells;
                var newSupplierForm = new NewSupplierForm(int.Parse(cells[0].Value.ToString())) { RefToFormMain = this };
                newSupplierForm.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Please select row");
            }
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible) return;
            if (tabPane1.SelectedPage == tabNavigationPage1)
            {
                supplierGridControl.DataSource = _supplierBusinessLogic.GetallSupplier().ToList();
            }
        }
    }
}
