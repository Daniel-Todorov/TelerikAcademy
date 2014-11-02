using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animal
{
    class Test
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Sharo", 6, Gender.Male));
            animals.Add(new Frog("Zhabche", 2, Gender.Female));
            animals.Add(new Kitten("Macka", 4));
            animals.Add(new Tomcat("Kotaka", 5));
            animals.Add(new Dog("Lasi", 8, Gender.Female));
            animals.Add(new Frog("Zelenata", 4, Gender.Female));
            animals.Add(new Kitten("Pisanka", 5));
            animals.Add(new Tomcat("Zhrebeca", 7));

            Console.WriteLine("The avarage age of the dogs is: {0}", CountDogs(animals));
            Console.WriteLine("The avarage age of the frogs is: {0}", CountFrogs(animals));
            Console.WriteLine("The avarage age of the cats is: {0}", CountCats(animals));
        }

        public static double CountDogs(List<Animal> animals)
        {
            double result = 0.0;
            int counter = 0;

            var dogs = from dog in animals
                       where dog is Dog
                       select dog;
            foreach (var dog in dogs)
            {
                result = result + dog.Age;
                counter++;
            }
            result = result / counter;

            return result;
        }

        public static double CountFrogs(List<Animal> animals)
        {
            double result = 0.0;
            int counter = 0;

            var frogs = from frog in animals
                        where frog is Frog
                        select frog;
            foreach (var frog in frogs)
            {
                result = result + frog.Age;
                counter++;
            }
            result = result / counter;

            return result;
        }

        public static double CountCats(List<Animal> animals)
        {
            double result = 0.0;
            int counter = 0;

            var cats = from cat in animals
                       where cat is Cat
                       select cat;
            foreach (var cat in cats)
            {
                result = result + cat.Age;
                counter++;
            }
            result = result / counter;

            return result;
        }
    }
}
