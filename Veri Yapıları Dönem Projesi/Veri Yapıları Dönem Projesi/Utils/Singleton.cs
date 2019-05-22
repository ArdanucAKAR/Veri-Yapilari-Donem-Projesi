using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class Singleton
    {
        private static Singleton singleton = null;
        public BinaryTree hotels;
        public List<Manager> managers = new List<Manager>();
        public HashMapChain hashMapChain;

        private Singleton()
        {

        }
        public static Singleton Instance()
        {
            if (singleton == null)
                singleton = new Singleton();
            return singleton;
        }
        public void Initialize()
        {
            hashMapChain = new HashMapChain();
            hotels = new BinaryTree(null);
            List<Hotel> hotelList = new List<Hotel>();
            //hotelList.Add(new Hotel() { Id = 19, Name = "o" });
            //hotelList.Add(new Hotel() { Id = 2, Name = "a" });
            //hotelList.Add(new Hotel() { Id = 8, Name = "b" });

            //hotelList.Add(new Hotel() { Id = 5, Name = "c" });
            //hotelList.Add(new Hotel() { Id = 15, Name = "d" });
            TextReader.Path = "\\oteller.txt";
            hotelList = TextReader.ReadFile();
            foreach (var item in hotelList)
            {
                Console.WriteLine(item.Name);
                hotels.Add(item);
            }
            Manager manager = new Manager { Username = "admin", Password = "admin" };           
            managers.Add(manager);
        }
    }
}
