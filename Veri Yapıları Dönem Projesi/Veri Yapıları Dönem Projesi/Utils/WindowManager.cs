using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapıları_Dönem_Projesi
{
    public static class WindowManager
    {
        static ArrayTypedStack openedForms = new ArrayTypedStack(10);
        static Form f;
        public static void OpenForm(Form form)
        {
            openedForms.Push(form);
            form.Show();
        }
        public static void CloseForm(Form form)
        {
            f = (Form)openedForms.Pop();
            form.Hide();
            if (openedForms.IsEmpty())
            {
                DialogResult res = MessageBox.Show("Programı Kapatmak İstiyor Musunuz?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                    Environment.Exit(0);
                if (res == DialogResult.Cancel)
                    OpenForm(f);
            }
        }
    }
}
