using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  
namespace PosElrabia.Supplier
{
    public partial class frmSupplierAdd : Form
    {
        Model.ElArabiaPOSApplicationEntities db = new Model.ElArabiaPOSApplicationEntities();
        public frmSupplierAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Model.Supplier supplier = new Model.Supplier()
            {
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                SupplierName = txtName.Text,
                IsDeleted = false
            };
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            MessageBox.Show("Save Data Successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();

            
           
        }
    }
}
