using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main()
        {
            var people = new List<Person>();

            var p1 = new Person("Adam", 30);
            var p2 = new Person("Adam", 30);

            if (!people.Contains(p1))
                people.Add(p1);

            if (!people.Contains(p2))
                people.Add(p2);

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());



            Console.WriteLine(people.Count);

            //EQUALS

            if (p1.Equals(p2))
            {
                Console.WriteLine("p1 equals p2");
            }
            else
            {
                Console.WriteLine("p1 not equals p2");
            }
            
            
            
            
            
            
            //LINKED LIST


            MyLinkedList<int> myList = new MyLinkedList<int>();



            Console.WriteLine($"Number of elements in this list is { myList.Count()}");
            myList.AddLast(1);
            Console.WriteLine($"Number of elements in this list is { myList.Count()}");
            myList.AddLast(2);
            Console.WriteLine($"Number of elements in this list is { myList.Count()}");
            myList.AddLast(3);
            Console.WriteLine($"Number of elements in this list is { myList.Count()}");

            Console.WriteLine();


            MyLinkedList<string> myList1 = new MyLinkedList<string>();

            myList1.AddLast("kappa");
            Console.WriteLine($"Number of elements in this list is { myList.Count()}");

        }
    }
}
