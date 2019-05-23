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
    public partial class ManagerPanel : Form
    {
        object ilkveri;
        Hotel selectedHotel;

        public ManagerPanel()
        {
            InitializeComponent();
            this.Size = new Size(714, 447);
            gbHotels.Location = new Point(12, 12);
            gbHotels.Visible = true;
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
            #endregion
        }
        private void ManagerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowManager.CloseForm(this);
        }
        #region STAFF
        private void btnBackHotels_Click(object sender, EventArgs e)
        {
            gbStaff.Visible = false;
            gbHotels.Visible = true;
        }
        private void btnAddRate_Click(object sender, EventArgs e)
        {
            if (dgwStaff.SelectedRows.Count > 0)
            {
                int rate = Convert.ToInt32(Interaction.InputBox("Puan Girişi", "Personele Verdiğiniz Puan", "Örn: 1-10", (Screen.PrimaryScreen.Bounds.Width / 2) - 175, (Screen.PrimaryScreen.Bounds.Height / 2) - 100));
                if (rate < 1 || rate > 10)
                    MessageBox.Show("Hatalı Değer Girdiniz");
                else
                {
                    selectedHotel.Staff.Where(x => x.TRId == dgwStaff.SelectedRows[0].Cells[0].Value.ToString()).ToList()[0].Rate += rate;
                    dgwStaff.Update();
                    dgwStaff.Refresh();
                    dgwStaff.DataSource = selectedHotel.Staff;
                }
            }
            else
                MessageBox.Show("Personel Seçiniz");
        }
        private void btnListStaffForDeparmant_Click(object sender, EventArgs e)
        {
            string department = Interaction.InputBox("Departman Bilgisi", "Departman İsmi Giriniz", "Örn:Mutfak", (Screen.PrimaryScreen.Bounds.Width / 2) - 175, (Screen.PrimaryScreen.Bounds.Height / 2) - 100);
            List<Staff> filterStaff = Singleton.Instance().hotels.PrintTree().Where(x => x.Id == selectedHotel.Id).ToList()[0].Staff.Where(x => x.Department == department).ToList();
            if (filterStaff.Count != 0)
                dgwStaff.DataSource = filterStaff;
            else
                MessageBox.Show("Bu Departmanda Çalışan Yoktur");
        }
        #region STAFF CRUD
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            StaffAddingPanel staffAddingPanel = new StaffAddingPanel(selectedHotel.Id);
            WindowManager.OpenForm(staffAddingPanel);
        }
        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            if (dgwStaff.SelectedRows.Count > 0)
                selectedHotel.Staff.Remove(selectedHotel.Staff.Where(x => x.TRId == dgwStaff.SelectedRows[0].Cells[0].Value.ToString()).ToList()[0]);
            dgwStaff.DataSource = selectedHotel.Staff;
        }
        #endregion
        #region STAFF SORT  
        private void btnStaffSortRate_Click(object sender, EventArgs e)
        {
            selectedHotel = Singleton.Instance().hotels.nodes[dgwHotels.CurrentCell.RowIndex];
            dgwStaff.DataSource = selectedHotel.Staff.OrderBy(x => x.Rate).ToList();
        }
        private void btnStaffSortDescRate_Click(object sender, EventArgs e)
        {
            selectedHotel = Singleton.Instance().hotels.nodes[dgwHotels.CurrentCell.RowIndex];
            dgwStaff.DataSource = selectedHotel.Staff.OrderByDescending(x => x.Rate).ToList();
        }
        #endregion
        #endregion
        #region HOTEL
        private void dgwHotels_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgwHotels.SelectedCells.Count > 0)
                ilkveri = dgwHotels.SelectedCells[0].Value;
        }
        private void dgwHotels_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwHotels.SelectedCells[0].ColumnIndex == 5)
                if (Convert.ToInt32(dgwHotels.SelectedCells[0].Value) < 0 || Convert.ToInt32(dgwHotels.SelectedCells[0].Value) > 5)
                    dgwHotels.SelectedCells[0].Value = ilkveri;
        }
        private void dgwHotels_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwHotels.SelectedRows.Count > 0)
            {
                selectedHotel = Singleton.Instance().hotels.nodes[dgwHotels.CurrentCell.RowIndex];
                #region Görüntü
                gbStaff.Text = selectedHotel.Name + " Otelinin Personelleri";
                #endregion
                dgwStaff.DataSource = selectedHotel.Staff;
                dgwStaff.Columns[5].ReadOnly = true;
                gbHotels.Visible = false;
                gbStaff.Visible = true;
            }
            else
                MessageBox.Show("Lütfen bir otel seçiniz.");
        }
        #region HOTEL CRUD
        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            HotelAddingPanel hotelAddingPanel = new HotelAddingPanel(dgwHotels);
            WindowManager.OpenForm(hotelAddingPanel);
        }
        private void btnDelHotel_Click(object sender, EventArgs e)
        {
            if (dgwHotels.SelectedRows.Count > 0)
            {
                Singleton.Instance().hotels.Remove(Convert.ToInt32(dgwHotels.SelectedRows[0].Cells[0].Value));
                Singleton.Instance().hotels.InOrder();
                dgwHotels.DataSource = Singleton.Instance().hotels.PrintTree();
            }
        }
        #endregion
        #endregion
    }
}