using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosElrabia.Model;

namespace PosElrabia.Supplier
{
    public partial class SupplierFrm : Form
    {

        ElArabiaPOSApplicationEntities db = new ElArabiaPOSApplicationEntities();
        public SupplierFrm()
        {
            InitializeComponent();
        }

        private void SupplierFrm_Load(object sender, EventArgs e)
        {
            SelectAllSuppliers();
        }

        private void SelectAllSuppliers()
        {
            supplierGridView.DataSource = db.Suppliers
                .Where(a=>a.IsDeleted == false)
                 .Select(a => new { a.ID, a.SupplierName, a.Phone, a.Email }).ToList();
            supplierGridView.Columns[0].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSupplierAdd frm = new frmSupplierAdd();
            frm.ShowDialog();
            SelectAllSuppliers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (supplierGridView.SelectedRows.Count > 0) {
                int ID = Convert.ToInt32( supplierGridView.SelectedRows[0].Cells[0].Value);
                string name = Convert.ToString(supplierGridView.SelectedRows[0].Cells[1].Value);

               DialogResult dialogResult = MessageBox.Show($"Are you Sure yo Delete Employee {name}","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                  Model.Supplier supplier =  db.Suppliers.FirstOrDefault(a => a.ID == ID);
                    supplier.IsDeleted = true;
                    db.SaveChanges();
                    SelectAllSuppliers();


                }
            }
        }
    }
}
