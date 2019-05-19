using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class HashMapChain
    {
        int TABLE_SIZE = 200;

        LinkedHashEntry[] table;

        public HashMapChain()
        {
            table = new LinkedHashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                table[i] = null;
        }

        public void AddHotel(int key, object value)
        {
            int hash = (key % TABLE_SIZE);
            if (table[hash] == null)
                table[hash] = new LinkedHashEntry(key, value);
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry.Next != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry.Anahtar == key)
                    entry.Deger = value;
                else
                    entry.Next = new LinkedHashEntry(key, value);
            }
        }

        public Hotel GetHotel(int key)
        {
            int hash = (key % TABLE_SIZE);
            if (table[hash] == null)
                return null;
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry == null)
                    return null;
                else
                    return (Hotel)entry.Deger;
            }
        }
    }
}