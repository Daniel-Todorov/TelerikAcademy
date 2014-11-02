namespace Computers
{
    public class ProcessCommand : Command, ICommand
    {
        public ProcessCommand(MotherBoard motherboard)
            : base(motherboard)
        {
        }

        public void Execute(int value)
        {
            ServerMotherBoard server = (ServerMotherBoard)this.motherboard;

            server.SaveRamValue(value);

            string result = server.ProcessData();

            this.motherboard.DrawOnVideoCard(result);
        }
    }
}