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
    public partial class ManagerPanel : Form
    {
        object ilkveri;
        public ManagerPanel()
        {
            InitializeComponent();
            
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {
            Singleton.Instance().hotels.PreOrder();
            List<Hotel> hotels = new List<Hotel>();
            hotels = Singleton.Instance().hotels.PrintTree();
            var listBinding = new BindingList<Hotel>(hotels);
            
            dgwHotels.DataSource = listBinding;
            dgwHotels.Columns[4].Visible = false;
            dgwHotels.Columns[7].Visible = false;
            dgwHotels.Columns[8].Visible = false;
            dgwHotels.Columns[9].ReadOnly = true;
            dgwHotels.Columns[0].Visible = false;
            dgwHotels.AllowUserToAddRows = true;


        }

        private void ManagerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;
            WindowManager.CloseForm(this);
        }

       


        

        private void dgwHotels_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ilkveri = dgwHotels.SelectedCells[0].Value;
        }

        private void dgwHotels_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwHotels.SelectedCells[0].ColumnIndex == 5)
            {
                if (Convert.ToInt32(dgwHotels.SelectedCells[0].Value) < 0 || Convert.ToInt32(dgwHotels.SelectedCells[0].Value) > 5)
                {
                    dgwHotels.SelectedCells[0].Value = ilkveri;

                }

            }

        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            Singleton.Instance().hotels.Remove(Convert.ToInt32(dgwHotels.SelectedRows[0].Cells[0].Value));
           
        }
    }
    
}
