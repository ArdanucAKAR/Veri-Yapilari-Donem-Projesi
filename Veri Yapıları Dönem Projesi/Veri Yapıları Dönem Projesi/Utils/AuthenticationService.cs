using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    static class AuthenticationService
    {
        public static Manager Login(string Username, string Password)
        {
            Manager manager = new Manager();
            List<Manager> managers = new List<Manager>();
            managers = Singleton.Instance().managers;
            if (Username != string.Empty && Password != string.Empty)
            {
                manager = (Manager)managers.Where(x => x.Username == Username && x.Password == Password).ToList()[0];
                return manager;
            }
            return null;
        }
    }
}
