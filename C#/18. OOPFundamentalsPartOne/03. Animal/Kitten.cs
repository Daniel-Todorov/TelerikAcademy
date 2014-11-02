using System;

namespace _03.Animal
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, sex: Gender.Female)
        {
        }
    }
}
