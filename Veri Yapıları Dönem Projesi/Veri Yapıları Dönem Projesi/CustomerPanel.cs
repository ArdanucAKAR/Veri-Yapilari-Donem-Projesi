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
    public partial class CustomerPanel : Form
    {
        Hotel currentHotel;
        Customer activeCustomer;
        public CustomerPanel(string _FullName)
        {
            InitializeComponent();
            activeCustomer = new Customer();
            activeCustomer.Fullname = _FullName;
        }

        private void CustomerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowManager.CloseForm(this);
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            Singleton.Instance().hotels.InOrder();
            dgwHotels.DataSource = Singleton.Instance().hotels.PrintTree();
            dgwHotels.Columns[4].Visible = false;
            dgwHotels.Columns[7].Visible = false;
            dgwHotels.Columns[8].Visible = false;
            dgwHotels.Columns[0].Visible = false;

        }

        private void btnsortByCityTown_Click(object sender, EventArgs e)
        {
            string[] cityTownInfo = Interaction.InputBox("İl İlçe Girişi", "İli ve İlçeyi Giriniz.", "Örn:İzmir Bornova", 0, 0).Split(' ');

            foreach (var item in Singleton.Instance().hotels.PrintTree().Where(x => x.City == cityTownInfo[0] && x.Town == cityTownInfo[1]).ToList())
            {//11an 12iz //11
                Singleton.Instance().hashMapChain.AddHotel(cityTownInfo[0] + cityTownInfo[1], item);
            }
            dgwHotels.DataSource = Singleton.Instance().hashMapChain.GetHotels(cityTownInfo[0] + cityTownInfo[1]).DisplayHeap().OrderByDescending(x => x.Rate).ToList();
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            string commentContent = Interaction.InputBox("Yorum Girişi", "Lütfen Yorum Yapınız.", "", 0, 0);
            currentHotel = Singleton.Instance().hotels.PrintTree().Where(x => x.Id == Convert.ToInt32(dgwHotels.SelectedRows[0].Cells[0].Value)).ToList()[0];
            currentHotel.Comments.Add(new Comment()
            {
                Content = commentContent,
                Customer = activeCustomer
            });
        }

        private void dgwHotels_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwHotels.SelectedRows.Count > 0)
            {
                string Comments = "";
                foreach (var item in Singleton.Instance().hotels.PrintTree().Where(x => x.Id == Convert.ToInt32(dgwHotels.SelectedRows[0].Cells[0].Value)).ToList()[0].Comments)
                {
                    Comments += item.ToString() + "\n-------\n";
                }
                MessageBox.Show(Comments);

            }
        }

        private void btnRateHotel_Click(object sender, EventArgs e)
        {
            string Rate = Interaction.InputBox("Puan Girişi", "Lütfen Puan Veriniz.", "", 0, 0);
            Singleton.Instance().hotels.PrintTree().Where(x => x.Id == Convert.ToInt32(dgwHotels.SelectedRows[0].Cells[0].Value)).ToList()[0].RateTheHotel(int.Parse(Rate));
            dgwHotels.Update();
            dgwHotels.Refresh();
            dgwHotels.DataSource = Singleton.Instance().hotels.PrintTree();
        }

        private void btnListHotelOrderByStar_Click(object sender, EventArgs e)
        {
            int stars = Convert.ToInt32(Interaction.InputBox("Yıldız", "Yıldız Sayısı Giriniz", "Örn: 1-5", 0, 0));
            if (stars < 1 || stars > 5)
                MessageBox.Show("Hatalı Değer Girdiniz");
            else
            {
                BindingList<Hotel> hotels = (BindingList<Hotel>)dgwHotels.DataSource;
                dgwHotels.DataSource = hotels.Where(x => x.Stars == stars).OrderBy(x => x.Stars).ToList();
            }
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            Singleton.Instance().hotels.PreOrder();
            dgwHotels.DataSource = Singleton.Instance().hotels.PrintTree();

        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            Singleton.Instance().hotels.PostOrder();
            dgwHotels.DataSource = Singleton.Instance().hotels.PrintTree();
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            Singleton.Instance().hotels.InOrder();
            dgwHotels.DataSource = Singleton.Instance().hotels.PrintTree();
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("İsim", "Otel İsmini Giriniz", "", 0, 0);
            
                BindingList<Hotel> hotels = (BindingList<Hotel>)dgwHotels.DataSource;
                dgwHotels.DataSource = hotels.Where(x => x.Name == name).OrderByDescending(x => x.Rate).ToList();
            
        }

        private void btnTreeInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İkili ağaç eleman sayısı : " + Singleton.Instance().hotels.NodeCount().ToString()
                + "\nİkili ağaç derinliği : " + Singleton.Instance().hotels.getMaxDepth().ToString());
        }
    }
}
