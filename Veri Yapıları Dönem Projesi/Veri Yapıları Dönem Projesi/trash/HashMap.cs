using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class HashMap
    {
        int TABLE_SIZE = 10;
        HashEntry[] table;

        public HashMap()
        {
            table = new HashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                table[i] = null;
        }
        public void AddPersonel(int key, object value)
        {
            int hash = (key % TABLE_SIZE);
            while (table[hash] != null && table[hash].Anahtar != key)
            {
                if (hash == (key % TABLE_SIZE) - 1)
                    break;
                hash = (hash + 1) % TABLE_SIZE;
            }
            table[hash] = new HashEntry(key, value);
        }
        public Personel GetPersonel(int key)
        {
            int hash = (key % TABLE_SIZE);
            while (table[hash] != null && table[hash].Anahtar != key)
                hash = (hash + 1) % TABLE_SIZE;
            if (table[hash] == null)
                return null;
            else
                return (Personel)table[hash].Deger;
        }
        public List<Personel> GetPersonels()
        {
            List<Personel> a = new List<Personel>();
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] != null)
                    a.Add((Personel)table[i].Deger);
            }
            return a;
        }
        public bool DeletePersonel(int key)
        {
            int hash = (key % TABLE_SIZE);
            while (table[hash] != null && table[hash].Anahtar != key)
                hash = (hash + 1) % TABLE_SIZE;
            if (table[hash] != null)
            {
                table[hash].Durum = -1;
                table[hash].Deger = null;
                return true;
            }
            return false;
        }

    }
}
