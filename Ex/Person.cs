using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            Person p = (Person)obj;
            return (this.name == p.name) && (this.age == p.age);
        }


        public override int GetHashCode()
        {
            return 13 * this.name.GetHashCode() * age.GetHashCode();
        }
    }
}
