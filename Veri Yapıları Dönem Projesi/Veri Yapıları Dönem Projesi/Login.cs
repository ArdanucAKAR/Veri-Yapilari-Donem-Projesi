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
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Hotel a = new Hotel();
            Customer b = new Customer();
            Comment c = new Comment();
            ContactInformation d = new ContactInformation();
            Staff f = new Staff();
            f.Department = "";
            f.Contact = d;
            f.FullName = "Ardanuc";
            f.Position = "";
            f.Rate = 10;
            f.TRId = "0";
            d.Address = "adres";
            d.EMail = "mail";
            d.PhoneNumber = "0";
            c.Customer = b;
            c.Content = "";
            a.Comments.Add(c);
            a.Contact = d;
            a.Name = "Kaşar Otel";
            a.NumRooms = 100;
            a.Rate = 0;
            a.Staff.Add(f);
            a.Stars = 10;
            a.Town = "ADANA";

            LinkedList linkedList = new LinkedList();
            linkedList.InsertFirst(f);
            //textBox1.Text = (Staff)linkedList.GetElement(1).Data;
        }
    }
}
