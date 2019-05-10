using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
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
            if (p1.Equals(p2))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

   
        }
    }
}
