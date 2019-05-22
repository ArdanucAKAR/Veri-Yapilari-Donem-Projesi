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
        public CustomerPanel()
        {
            InitializeComponent();
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
            MessageBox.Show(cityTownInfo[0]+ cityTownInfo[1]);
            //dgwHotels.DataSource = Singleton.Instance().hotels.PrintTree().Where(x => x.City == cityTownInfo[0] && x.Town == cityTownInfo[1]).ToList();
           
        }
    }
}
