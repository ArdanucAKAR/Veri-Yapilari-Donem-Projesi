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
            hotels = new BinaryTree(null);
            TextReader.Path = "\\oteller.txt";
            hotels = TextReader.ReadFile();
            Manager manager = new Manager { Username = "admin", Password = "admin" };           
            managers.Add(manager);
        }
    }
}
