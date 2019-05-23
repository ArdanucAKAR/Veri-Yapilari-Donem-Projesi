using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
                WindowManager.CloseForm(this);
            }
        }
        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            string FullName = Interaction.InputBox("Bilgi Girişi", "Adınızı ve Soyadınızı giriniz.", "Örn: Ekrem İmamoğlu ", (Screen.PrimaryScreen.Bounds.Width / 2) - 175, (Screen.PrimaryScreen.Bounds.Height / 2) - 100);
            CustomerPanel customerPanel = new CustomerPanel(FullName);
            WindowManager.OpenForm(customerPanel);
            WindowManager.CloseForm(this);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowManager.CloseForm(this);
        }
    }
}
