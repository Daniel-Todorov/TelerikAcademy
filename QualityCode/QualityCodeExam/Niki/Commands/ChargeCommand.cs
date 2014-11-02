namespace Computers
{
    public class ChargeCommand : Command, ICommand
    {
        public ChargeCommand(MotherBoard motherboard)
            : base(motherboard)
        {
        }

        public void Execute(int value)
        {
            LaptopMotherBoard laptop = (LaptopMotherBoard)this.motherboard;
            int currentPower = laptop.Battery.CurrentBatteryPower();

            this.motherboard.DrawOnVideoCard(string.Format("Battery status: {0}%", currentPower));
        }
    }
}