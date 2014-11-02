namespace Computers
{
    public abstract class ComputerAbstractFactory
    {
        public abstract PcMotherBoard MakePc();

        public abstract LaptopMotherBoard MakeLaptop();

        public abstract ServerMotherBoard MakeServer();
    }
}
