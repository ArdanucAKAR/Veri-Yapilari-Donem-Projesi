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
        Hotel selectedHotel;

        public ManagerPanel()
        {
            InitializeComponent();

        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {

            Singleton.Instance().hotels.InOrder();
            dgwHotels.DataSource = Singleton.Instance().hotels.PrintTree();
            #region Görüntü Ayarları
            dgwHotels.Columns[4].Visible = false;
            dgwHotels.Columns[7].Visible = false;
            dgwHotels.Columns[8].Visible = false;
            dgwHotels.Columns[9].ReadOnly = true;
            dgwHotels.Columns[0].Visible = false;
            dgwHotels.AllowUserToAddRows = false;
            dgwStaff.AllowUserToAddRows = false;
            dgwStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            (tbcManager.TabPages[1] as TabPage).Enabled = false;
            #endregion

        }

        private void ManagerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowManager.CloseForm(this);
        }

        private void dgwHotels_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgwHotels.SelectedCells.Count > 0)
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
            if (dgwHotels.SelectedRows.Count > 0)
            {
                Singleton.Instance().hotels.Remove(Convert.ToInt32(dgwHotels.SelectedRows[0].Cells[0].Value));
                Singleton.Instance().hotels.InOrder();
                dgwHotels.DataSource = Singleton.Instance().hotels.PrintTree();
            }

        }

        private void btnListStaff_Click(object sender, EventArgs e)
        {
            if (dgwHotels.SelectedRows.Count > 0)
            {
                selectedHotel = Singleton.Instance().hotels.nodes[dgwHotels.CurrentCell.RowIndex];
                #region Görüntü
                lblHotelName.Text = selectedHotel.Name + " Otelinin Personelleri";
                (tbcManager.TabPages[1] as TabPage).Enabled = true;
                tbcManager.SelectedIndex = 1;
                #endregion
                dgwStaff.DataSource = selectedHotel.Staff;
            }
            else
            {
                MessageBox.Show("Lütfen bir otel seçiniz.");
            }
        }

        private void tbcManager_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            if (dgwStaff.SelectedRows.Count > 0)
            {
                selectedHotel.Staff.RemoveAt(dgwStaff.CurrentCell.RowIndex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HotelAddingPanel hotelAddingPanel = new HotelAddingPanel(dgwHotels);
            WindowManager.OpenForm(hotelAddingPanel);
        }
    }

}
