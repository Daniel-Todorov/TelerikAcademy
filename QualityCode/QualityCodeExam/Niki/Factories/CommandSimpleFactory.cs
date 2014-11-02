namespace Computers
{
    using System;

    public static class CommandSimpleFactory
    {
        public static ICommand CreateCommand(string commandName, MotherBoard motherboard)
        {
            switch (commandName)
            {
                case "Charge":
                    return new ChargeCommand(motherboard);
                case "Process":
                    return new ProcessCommand(motherboard);
                case "Play":
                    return new PlayCommand(motherboard);
                case "Exit":
                    return new ExitCommand(motherboard);
                default:
                    throw new ArgumentException("Invalid command name");
            }
        }
    }
}
