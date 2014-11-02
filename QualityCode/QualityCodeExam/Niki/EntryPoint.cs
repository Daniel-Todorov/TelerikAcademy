namespace Computers
{
    using System;
    using System.Collections.Generic;

    public class EntryPoint
    {
        public static void Main()
        {
            ComputerAbstractFactory factory;
            PcMotherBoard pc;
            LaptopMotherBoard laptop;
            ServerMotherBoard server;

            var manufacturerName = Console.ReadLine();

            if (manufacturerName.Equals("HP"))
            {
                factory = new Hp();
            }
            else if (manufacturerName == "Dell")
            {
                factory = new Dell();
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }

            pc = factory.MakePc();
            laptop = factory.MakeLaptop();
            server = factory.MakeServer();

            while (true)
            {
                var commandLine = Console.ReadLine();

                if (commandLine.StartsWith("Exit"))
                {
                    ICommand command = CommandSimpleFactory.CreateCommand("Exit", pc);
                    command.Execute(0);
                    command = CommandSimpleFactory.CreateCommand("Exit", laptop);
                    command.Execute(0);
                    command = CommandSimpleFactory.CreateCommand("Exit", server);
                    command.Execute(0);
                    break;
                }

                string[] parsedCommand = CommandParser.Parse(commandLine);
                string commandName = parsedCommand[0];
                int commandArgument = int.Parse(parsedCommand[1]);
                
                if (commandName == "Charge")
                {
                    ICommand command = CommandSimpleFactory.CreateCommand(commandName, laptop);
                }
                else if (commandName == "Process")
                {
                    ICommand command = CommandSimpleFactory.CreateCommand(commandName, server);
                }
                else if (commandName == "Play")
                {
                    ICommand command = CommandSimpleFactory.CreateCommand(commandName, pc);
                }
            }
        }
    }
}
