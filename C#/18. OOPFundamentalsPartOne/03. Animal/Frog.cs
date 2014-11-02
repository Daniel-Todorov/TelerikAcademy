using System;

namespace _03.Animal
{
    class Frog : Animal, ISound
    {
        public string MakeSound()
        {
            return "Kvak, kvak";
        }

        public Frog(string name, int age, Gender sex)
            : base(name, age, sex)
        {
        }
    }
}
