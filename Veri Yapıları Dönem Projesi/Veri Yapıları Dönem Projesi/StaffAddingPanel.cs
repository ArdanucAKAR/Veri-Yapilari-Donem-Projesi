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
    public partial class StaffAddingPanel : Form
    {
        int id;
        public StaffAddingPanel(int index)
        {
            InitializeComponent();
            id = index;
            this.ActiveControl = txtTRId;
        }

        private void btnAddPersonel_Click(object sender, EventArgs e)
        {
            Staff newStaff = new Staff()
            {
                Contact = new ContactInformation()
                {
                    Address = txtAddress.Text,
                    EMail = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text
                },
                Department = txtDepartment.Text,
                FullName = txtName.Text + " " + txtSurname.Text,
                Position = txtPosition.Text,
                Rate = 0,
                TRId = txtTRId.Text
            };
            Singleton.Instance().hotels.nodes.Where(x => x.Id == id).ToList()[0].Staff.Add(newStaff);
            this.Close();
        }

        private void StaffAddingPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowManager.CloseForm(this);
        }
    }
}
