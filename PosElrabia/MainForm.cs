using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosElrabia.Supplier;

namespace PosElrabia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            label1.Text = "Hello " + UserInfo.employee.Name;
           
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierFrm frm = new SupplierFrm();
            frm.ShowDialog();


         
        }
    }
}
