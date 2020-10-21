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


namespace PosElrabia
{
    public partial class LoginForm : Form
    {
        ElArabiaPOSApplicationEntities entities = new ElArabiaPOSApplicationEntities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtuserName.Text;
            string password = txtPassword.Text;

         Employee employee=   entities.Employees.FirstOrDefault(a => (a.UserName == userName && a.Password == password) && a.IsDeleted == false);
            if(employee == null)
            {
                MessageBox.Show("The Username or password is Wrong ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //The Employee is Exist Authtication Successful 
                //UserInfo info = new UserInfo();
                //info.employee = employee;
                UserInfo.employee = employee;
                MainForm frm = new MainForm();
                this.Hide();
                frm.ShowDialog();
          



            }



        }
    }
}
