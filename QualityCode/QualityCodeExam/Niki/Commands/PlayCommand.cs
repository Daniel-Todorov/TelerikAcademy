namespace Computers
{
    public class PlayCommand : Command, ICommand
    {
        public PlayCommand(MotherBoard motherboard)
            : base(motherboard)
        {
        }

        public void Execute(int playerGuess)
        {
            PcMotherBoard pc = (PcMotherBoard)this.motherboard;

            string result = pc.Play(playerGuess);

            this.motherboard.DrawOnVideoCard(result);
        }
    }
}