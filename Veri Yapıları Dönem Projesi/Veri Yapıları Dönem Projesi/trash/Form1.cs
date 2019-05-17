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
    public partial class Form1 : Form
    {
        HashMap hashTable = new HashMap();
        HashMapChain hashTableChain = new HashMapChain();
        Personel[] p = new Personel[10];
        public Form1()
        {

            InitializeComponent();
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Personel();
                p[i].adayNo = i * 5;
            }
            for (int a = 0; a < 10; a++)
            {
                p[a].adayAd = "Ali";
                p[a].adayMail = "ali@hotmail.com";
            }

            for (int i = 0; i < p.Length; i++)
            {
                hashTable.AddPersonel(p[i].adayNo, p[i]);

            }
            listBox1.Items.Clear();
            foreach (Personel personel in hashTable.GetPersonels())
            {
                if (personel != null)
                    listBox1.Items.Add(personel.adayMail);
            }
            for (int i = 0; i < p.Length; i++)
            {

                hashTableChain.AddPersonel(p[i].adayNo, p[i]);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hashTable.DeletePersonel(int.Parse(textBox1.Text)) == false)
            {
                MessageBox.Show("sa");
            }
            listBox1.Items.Clear();
            foreach (Personel personel in hashTable.GetPersonels())
            {
                if (personel != null)
                    listBox1.Items.Add(personel.adayMail);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hashTable.AddPersonel(int.Parse(textBox1.Text), p[4]);
            listBox1.Items.Clear();
            foreach (Personel personel in hashTable.GetPersonels())
            {
                if (personel != null)
                    listBox1.Items.Add(personel.adayMail);
            }

        }
    }
}
