  //Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
  //Dogs, frogs and cats are Animals. 
  //All animals can produce sound (specified by the ISound interface). 
  //Kittens and tomcats are cats. 
  //All animals are described by age, name and sex. 
  //Kittens can be only female and tomcats can be only male. 
  //Each animal produces a specific sound. 
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

//!!!NOTE!!!
//Again I am not completely sure if that's what I am supposed to do.
//Please, add a comment if you think the hierarchy should be defined in another way.
using System;

namespace _03.Animal
{
    enum Gender { Male, Female };

    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }

        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}
