using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    public class MyStack
    {
        int top;
        int size;
        char[] values;

        public MyStack(int sizePara)
        {
            top = -1;
            size = sizePara;
            values = new char[size];
        }

        public bool isEmpty()
        {
            if (top < this.size - 1)
                return true;
            else
                return false;
        }

        public bool isTotallyEmpty()
        {
            return top == -1;
        }

        public bool isFull()
        {
            return top == size - 1;
        }

        public void Push(char dataPara)
        {
            if (isFull())
                Console.WriteLine("Stack tamamen dolu!");
            else
            {
                top++;
                values[top] = dataPara;
            }
        }

        public char Pop()
        {
            char cikarilan = values[top];
            top--;
            return cikarilan;
        }

        public void Print()
        {
            if(isTotallyEmpty())
                Console.WriteLine("Stack tamamiyle boş!");
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(values[i]);
                }
            }
        }
    }
}
