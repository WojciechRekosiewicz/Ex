using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Person
    {
        private readonly string name;
        private readonly int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public override bool Equals(object obj)
        {
            Person p = (Person)obj;

            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            return (this.name == p.name) && (this.age == p.age);
        }


        public override int GetHashCode()
        {
            return 13 * name.GetHashCode() * age.GetHashCode();
        }
    }
}
