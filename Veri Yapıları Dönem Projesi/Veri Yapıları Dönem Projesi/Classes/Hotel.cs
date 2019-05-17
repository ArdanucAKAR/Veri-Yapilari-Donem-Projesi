using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public ContactInformation Contact { get; set; }
        public int Stars { get; set; }
        public int NumRooms { get; set; }
        public int Rate { get; set; }
        public List<Comment> Comments{ get; set; }
        public List<Staff> Staff { get; set; }
    }
}
