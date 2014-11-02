namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class CommandParser
    {
        public static string[] Parse(string commandLine)
        {
            string[] parsedCommand = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parsedCommand.Length != 2)
            {
                {
                    throw new ArgumentException("Invalid command!");
                }
            }

            return parsedCommand;
        }
    }
}
