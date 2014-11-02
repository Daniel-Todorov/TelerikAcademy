//Refactor the following examples to produce code with well-named identifiers in C#:

using System;

public class HumanBase
{
    private enum Gender
    {
        Male, Female
    }

    public void InicializeHuman(int magicNumberOfHuman)
    {
        Human newHuman = new Human();

        newHuman.Age = magicNumberOfHuman;

        if (magicNumberOfHuman % 2 == 0)
        {
            newHuman.Name = "Батката";

            newHuman.Gender = Gender.Male;
        }
        else
        {
            newHuman.Name = "Мацето";

            newHuman.Gender = Gender.Female;
        }
    }

    private class Human
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}