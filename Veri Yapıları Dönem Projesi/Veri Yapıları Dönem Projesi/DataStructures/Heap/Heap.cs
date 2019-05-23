using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class Heap
    {
        public int depthcount = 0;
        private HeapDugumu[] heapArray;
        public int hashMap;
        private int maxSize;
        private int currentSize;
        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            heapArray = new HeapDugumu[maxSize];
            currentSize = 0;
        }
        public bool IsEmpty()
        { 
            return currentSize == 0; 
        }
        public bool Insert(Hotel value)
        {
            if (currentSize == maxSize)
                return false;
            HeapDugumu newHeapDugumu = new HeapDugumu(value);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && heapArray[parent].Value.Rate < bottom.Value.Rate)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugumu RemoveMax()
        {
            HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && heapArray[leftChild].Value.Rate < heapArray[rightChild].Value.Rate)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.Value.Rate >= heapArray[largerChild].Value.Rate)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        public List<Hotel> DisplayHeap()
        {
            List<Hotel> hotels = new List<Hotel>();
            Console.WriteLine();
            Console.Write("Heap içerisindeki elemanlar: ");
            for (int m = 0; m < currentSize; m++)
                if (heapArray[m] != null)
                {
                    hotels.Add(heapArray[m].Value);
                    Console.Write(heapArray[m].Value.Rate + " ");

                }
                else
                    Console.Write("-- ");
            Console.WriteLine();
            int emptyLeaf = 32;
            int itemsPerRow = 1;
            int column = 0;
            int j = 0;
            String separator = "...............................";
            Console.WriteLine(separator + separator);
            while (currentSize > 0)
            {
                if (column == 0)
                    for (int k = 0; k < emptyLeaf; k++)
                        Console.Write(' ');
                Console.Write(heapArray[j].Value.Rate);

                if (++j == currentSize)
                    break;
                if (++column == itemsPerRow)
                {
                    emptyLeaf /= 2;
                    itemsPerRow *= 2;
                    column = 0;
                    Console.WriteLine();
                }
                else
                    for (int k = 0; k < emptyLeaf * 2 - 2; k++)
                        Console.Write(' ');
            }
            Console.WriteLine("\n" + separator + separator);
            depthcount++;
            return hotels;
        } 
    }
}
