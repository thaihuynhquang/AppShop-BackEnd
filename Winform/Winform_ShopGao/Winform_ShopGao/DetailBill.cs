using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_ShopGao
{
    public partial class DetailBill : Form
    {
      
        private int _billId;

        public DetailBill()
        {
            InitializeComponent();
        }

        public DetailBill(int billId)
        {
           
            this._billId = billId;
        }

        public MainForm RefToFormMain { get; set; }

        private void DetailBill_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = 
        }
    }
}
