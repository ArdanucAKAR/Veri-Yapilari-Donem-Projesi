using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class HashMapChain
    {
        public List<Heap> heaps = new List<Heap>();
        int TABLE_SIZE = 200;
        
        LinkedHashEntry[] table;

        public HashMapChain()
        {
            table = new LinkedHashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                table[i] = null;
        }
        public void AddHotel(string Stringkey, object value)
        {
            int key = Stringkey.Length;
            int hash = (key % TABLE_SIZE);
            if (table[hash] == null)
            {
                table[hash] = new LinkedHashEntry(key, value);
                Heap heap = new Heap(10) { hashMap = hash };
                heap.Insert((Hotel)value);
                heaps.Add(heap);
            }
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry.Next != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry.Anahtar == key) { 
                    entry.Deger = value;
                    heaps.Where(x => x.hashMap == hash).ToList()[0].Insert((Hotel)value);
                }
                else
                {
                    entry.Next = new LinkedHashEntry(key, value);
                }
            }
        }

        public Heap GetHotels(string Stringkey)
        {
            int key = Stringkey.Length;
            int hash = (key % TABLE_SIZE);
            return heaps.Where(x => x.hashMap == hash).ToList()[0];
        }
    }
}