namespace Computers
{
    public abstract class Command : ICommand
    {
        private MotherBoard motherboard;

        public Command(MotherBoard motherboard)
        {
            this.motherboard = motherboard;
        }
    }
}
