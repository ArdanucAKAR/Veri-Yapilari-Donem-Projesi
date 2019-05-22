using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class HeapSort
    {
        private Hotel[] dizi;
        public HeapSort(Hotel[] dizi)
        {
            this.dizi = dizi;
        }

        public float[] Sort()
        {
            Heap h = new Heap(dizi.Length);
            float[] sorted = new float[dizi.Length];
            //Heap Ağacı Oluştur
            foreach (var item in dizi)
                h.Insert(item);
            int i = 0;
            //Ağaçtaki maksimum elemanı al ve yeni diziye ekle
            while (!h.IsEmpty())
                sorted[i++] = h.RemoveMax().Value.Rate;
            return sorted;
        }

    }
}
