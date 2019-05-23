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
    public partial class HotelAddingPanel : Form
    {
        DataGridView dgwdgwHotels;
        public HotelAddingPanel(DataGridView d)
        {
            InitializeComponent();
            dgwdgwHotels = d;
        }
        private void HotelAddingPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowManager.CloseForm(this);
        }
        private void btnHotelSave_Click(object sender, EventArgs e)
        {
            Hotel h = new Hotel() {
                Name = txtHotelName.Text,
                City = txtCity.Text,
                Town = txtTown.Text,
                Contact = new ContactInformation()
                {
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    EMail = txtEmail.Text
                },
                Stars = int.Parse(txtStar.Text),
                NumRooms = int.Parse(txtNumRoom.Text)
            };
            Singleton.Instance().hotels.Add(h);
            Singleton.Instance().hotels.InOrder();
            dgwdgwHotels.DataSource = Singleton.Instance().hotels.PrintTree();
            this.Close();
        }
    }
}
