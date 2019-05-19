using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class ArrayTypedStack: IStack
    {
        private object[] items;
        private int top = -1;

        public ArrayTypedStack(int itemCount)
        {
            this.items = new object[itemCount];
        }
        public void Push(object item)
        {
            if (items.Length == top + 1)
            {
                throw new Exception("Hata: Stack doldu... (Overflow)");
            }
            items[++top] = item;
        }

        public object Pop()
        {
            object temp = items[top--];
            return temp;
        }

        public object Peek()
        {
            return items[top];
        }

        public bool IsEmpty()
        {
            return top == -1 ? true : false;
        } 
    }
}
