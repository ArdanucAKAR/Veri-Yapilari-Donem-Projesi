using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public interface IStack
    {
        void Push(object item);
        object Pop();
        object Peek();
        bool IsEmpty();
    }
}
