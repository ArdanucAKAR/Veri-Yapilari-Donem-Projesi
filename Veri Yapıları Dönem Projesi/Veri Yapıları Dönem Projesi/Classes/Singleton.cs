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
        private Singleton()
        {

        }
        public static Singleton Instance()
        {
            if (singleton == null)
                singleton = new Singleton();
            return singleton;
        }
    }
}
