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

            Heap h = new Heap(Singleton.Instance().hotels.NodeCount());
            Singleton.Instance().hotels.PrintTree().ToList()[1].Name = "Bok Oteli";
            foreach (Hotel hotel in Singleton.Instance().hotels.PrintTree())
            {
                h.Insert(hotel);
                //MessageBox.Show("Id: " + hotel.Id.ToString() + "\n" + "Adı: "+hotel.Name);

            }
            foreach (var item in h.DisplayHeap())
            {
                MessageBox.Show("ad:" + item.Name + "\nrate:" +item.Rate);

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
