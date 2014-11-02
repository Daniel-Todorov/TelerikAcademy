namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MonochromeDrawStrategy : IDrawStrategy
    {
        public void Draw(string text)
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(text);
        }
    }
}
