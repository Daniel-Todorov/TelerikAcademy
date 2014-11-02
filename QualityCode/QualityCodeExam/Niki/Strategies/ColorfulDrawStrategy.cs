namespace Computers
{
    using System;

    public class ColorfulDrawStrategy : IDrawStrategy
    {
        public void Draw(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(text);
        }
    }
}
