using System;

namespace _03.Animal
{
    class Dog : Animal, ISound
    {
        public string MakeSound()
        {
            return "Bau, bau";
        }

        public Dog(string name, int age, Gender sex)
            : base(name, age, sex)
        {
        }
    }
}
