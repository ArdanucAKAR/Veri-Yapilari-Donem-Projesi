using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public ContactInformation Contact { get; set; }
        public int Stars { get; set; }
        public int NumRooms { get; set; }
        public int Point { get; set; }
        public int Raters { get; set; }

        private float rate;
        public float Rate
        {
            get { return rate; }
            set
            {
                if (0 != Raters)
                {
                    rate = (float)Point / Raters;
                }
            }
        }

        public List<Comment> Comments { get; set; }
        public List<Staff> Staff { get; set; }

        public Hotel()
        {
            Comments = new List<Comment>();
            Staff = new List<Staff>();
            Id = IdGenerator();
        }
        private int IdGenerator()
        {
            string number = String.Format("{0:d5}", (DateTime.Now.Ticks / 10) % 100000);
            return Convert.ToInt32(number);
        }
            public void RateTheHotel(int rate)
        {
            Point += rate;
            Raters++;
            Rate = 1; // Prop'un setterını tetikler.
        }
    }

}
