namespace Computers
{
    public class ExitCommand : Command, ICommand
    {
        public ExitCommand(MotherBoard motherboard)
            : base(motherboard)
        {
        }

        public void Execute()
        {
            this.motherboard.EndPresentation();
        }
    }
}