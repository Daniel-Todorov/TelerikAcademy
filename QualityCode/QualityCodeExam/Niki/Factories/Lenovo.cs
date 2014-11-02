namespace Computers
{
    using System.Collections.Generic;

    public class Lenovo : ComputerAbstractFactory
    {
        public override PcMotherBoard MakePc()
        {
            return new PcMotherBoard(new RamMemory(4), new Bit64Cpu(2), new HDD(2000), new MonochromeVideoCard());
        }

        public override LaptopMotherBoard MakeLaptop()
        {
            return new LaptopMotherBoard(new RamMemory(16), new Bit64Cpu(2), new HDD(1000), new ColorfulVideoCard(), new LaptopBattery());
        }

        public override ServerMotherBoard MakeServer()
        {
            List<IHardDrive> disksInArray = new List<IHardDrive>();

            disksInArray.Add(new HDD(500));
            disksInArray.Add(new HDD(500));

            return new ServerMotherBoard(new RamMemory(8), new Bit128Cpu(2), new RaidArray(disksInArray), new MonochromeVideoCard());
        }
    }
}