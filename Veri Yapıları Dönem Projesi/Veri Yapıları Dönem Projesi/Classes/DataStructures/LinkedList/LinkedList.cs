using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class LinkedList : LinkedListADT
    {
        public override void InsertFirst(object value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }

        public override void InsertLast(object value)
        {
            Node oldLast = Head;

            if (Head == null)
                InsertFirst(value);
            else
            {
                Node newLast = new Node
                {
                    Data = value
                };
                while (oldLast.Next != null)
                {
                    oldLast = oldLast.Next;

                }
                oldLast.Next = newLast;
                Size++;
            }
        }

        public override void InsertPos(int position, object value)
        {
            Node temp = new Node
            {
                Data = value
            };
            Node tempNode = Head;
            int count = 0;

            while (tempNode != null)
            {
                if (count == position - 2)
                {
                    break;
                }
                tempNode = tempNode.Next;
                count++;
            }
            temp.Next = tempNode.Next;
            tempNode.Next = temp;

            Size++;
        }

        public override void DeleteFirst()
        {
            if (Head != null)
            {
                Node tempHeadNext = this.Head.Next;
                if (tempHeadNext == null)
                    Head = null;
                else
                    Head = tempHeadNext;
                Size--;
            }
        }

        public override void DeleteLast()
        {
            Node lastNode = Head;
            Node lastPrevNode = null;
            while (lastNode.Next != null)
            {
                lastPrevNode = lastNode;
                lastNode = lastNode.Next;
            }
            Size--;
            lastNode = null;
            if (lastPrevNode != null)
                lastPrevNode.Next = null;
            else
                Head = null;
        }

        public override void DeletePos(int position)
        {
            Node tempNode = Head;
            int count = 0;
            while (tempNode != null)
            {
                if (count == position - 2)
                {
                    break;
                }
                tempNode = tempNode.Next;
                count++;
            }
            tempNode.Next = tempNode.Next.Next;
            Size--;
        }

        public override Node GetElement(int position)
        {
            Node retNode = null;
            Node tempNode = Head;
            int count = 0;
            while (tempNode != null)
            {
                if (count == position)
                {
                    retNode = tempNode;
                    break;
                }
                tempNode = tempNode.Next;
                count++;
            }
            return retNode;
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }
            return temp;
        }
    }
}
