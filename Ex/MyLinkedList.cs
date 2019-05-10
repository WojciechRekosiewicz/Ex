using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    public class MyLinkedList<T> : IMyLinkedList<T>
    {

        Node<T> Head { get; set; }

        public void AddLast(T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
            }
            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(data);
            Console.WriteLine($"{data} added!");
        }


        public int Count()
        {
            int x = 0;

            if (Head == null)
            {
                return x;
            }
            Node<T> current = Head;
            while (current.Next != null)
            {
                x++;
                current = current.Next;
            }
            return x;
        }
    }
}
