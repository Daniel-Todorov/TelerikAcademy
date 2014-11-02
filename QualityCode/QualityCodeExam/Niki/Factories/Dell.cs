namespace Computers
{
    using System.Collections.Generic;

    public class Dell : ComputerAbstractFactory
    {
        public override PcMotherBoard MakePc()
        {
            return new PcMotherBoard(new RamMemory(8), new Bit64Cpu(4), new HDD(1000), new ColorfulVideoCard());
        }

        public override LaptopMotherBoard MakeLaptop()
        {
            return new LaptopMotherBoard(new RamMemory(8), new Bit32Cpu(4), new HDD(1000), new ColorfulVideoCard(), new LaptopBattery());
        }

        public override ServerMotherBoard MakeServer()
        {
            List<IHardDrive> disksInArray = new List<IHardDrive>();

            disksInArray.Add(new HDD(2000));
            disksInArray.Add(new HDD(2000));

            return new ServerMotherBoard(new RamMemory(64), new Bit64Cpu(8), new RaidArray(disksInArray), new MonochromeVideoCard());
        }
    }
}
