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
        }

        private void Login_Load(object sender, EventArgs e)
        {
        

            Singleton.Instance().hotels.PreOrder();
            foreach (Hotel hotel in Singleton.Instance().hotels.PrintTree())
            {
                MessageBox.Show("Id: " + hotel.Id.ToString() + "\n" + "Adı: "+hotel.Name);

            }


            //LinkedList linkedList = new LinkedList();
            //linkedList.InsertFirst(f);
            //linkedList.InsertFirst(s);

            //for (int i = 0; i < linkedList.Size; i++)
            //{
            //    Staff ss = (Staff)linkedList.GetElement(i).Data;
            //    MessageBox.Show(ss.FullName);
            //}
        }
    }
}
