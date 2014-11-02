using System;

namespace _03.Animal
{
    abstract class Cat : Animal, ISound
    {
        public string MakeSound()
        {
            return "Myau, myau";
        }

        public Cat(string name, int age, Gender sex)
            : base(name, age, sex)
        {
        }
    }
}
