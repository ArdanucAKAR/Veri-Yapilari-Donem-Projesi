using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapıları_Dönem_Projesi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Singleton.Instance().Initialize();
            WindowManager.OpenForm(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Manager manager = null;
            manager = AuthenticationService.Login(txtUsername.Text, txtPassword.Text);
            if (manager != null)
            {
                ManagerPanel managerPanel = new ManagerPanel();
                WindowManager.OpenForm(managerPanel);
            }
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Singleton.Instance().hotels.root.left.data.Name);

            CustomerPanel customerPanel = new CustomerPanel();
            WindowManager.OpenForm(customerPanel);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowManager.CloseForm(this);
        }
    }
}
