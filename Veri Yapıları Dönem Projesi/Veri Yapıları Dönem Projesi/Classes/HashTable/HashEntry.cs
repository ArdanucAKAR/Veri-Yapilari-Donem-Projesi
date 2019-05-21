using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashUygulama
{
    public class HashEntry
    {
        private int anahtar;

       
        private object deger;

        public object Deger
        {
            get { return deger; }
            set { deger = value; }
        }
        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }
        public HashEntry(int anahtar, object deger)
        {
            this.anahtar = anahtar;
            this.deger = deger;
        }


    }
}
