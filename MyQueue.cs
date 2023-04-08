using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    public class MyQueue
    {
        int size;
        char[] values;
        int front;
        int rear;

        public MyQueue(int sizePara)
        {
            this.size = sizePara;
            values = new char[size];
            front = rear = -1;
        }

        public bool isEmpty()
        {
            return this.front == this.rear;
        }

        public bool isFull()
        {
            return this.rear == this.size - 1; 
        }

        public void Enqueue(char dataPara)
        {
            if (isFull())
                Console.WriteLine("Kuyruk dolu!");
            else
            {
                this.rear++;
                this.values[rear] = dataPara;
            }
        }

        public char Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Liste boş, çıkartılacak bir şey yok!");
                return 'X';
            }
            else
            {
                this.front++; //eleman çıkarma aksiyonu
                return values[front]; //çıkarılan eleman döndürülür
            }  
        }

        public void Print()
        {
            if (isEmpty())
                Console.WriteLine("Kuyruk boş, yazdırılacak bir şey yok!");
            else
            {
                for (int i = 0; i <= this.rear; i++) //front++ ifadesi enqueue işlemini bozduğu için burada i = 0 alınmıştır.
                {
                    Console.WriteLine(values[i]);
                }
            }
        }

    }
}
