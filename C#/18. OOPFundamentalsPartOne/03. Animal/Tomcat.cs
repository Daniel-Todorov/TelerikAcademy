using System;

namespace _03.Animal
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, sex: Gender.Male)
        {
        }
    }
}
