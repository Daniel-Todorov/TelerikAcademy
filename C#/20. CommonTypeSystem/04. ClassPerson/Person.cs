using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ClassPerson
{
    class Person
    {
        private string name;
        private byte? age;

        public byte? Age
        {
            get
            {
                return this.age;
            }

            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            string result = null;

            if (this.age == null)
            {
                result = string.Format("Name: {0}, Age: not specified", this.name);
            }
            else
            {
                result = string.Format("Name: {0}, Age: {1}", this.name, this.age);
            }

            return result;
        }

        public Person(string name, byte age) : this(name)
        {
            this.age = age;
        }

        public Person(string name)
        {
            this.name = name;
            this.age = null;
        }
    }
}
