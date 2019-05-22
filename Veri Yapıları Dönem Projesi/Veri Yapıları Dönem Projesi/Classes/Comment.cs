using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class Comment
    {
        public Customer Customer { get; set; }
        public string Content { get; set; }
        public override string ToString()
        {
            return Customer.Fullname + ": \n" + Content;
        }
    }

}
