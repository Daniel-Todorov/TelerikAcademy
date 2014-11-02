namespace Computers
{
    using System.Collections.Generic;

    public class Hp : ComputerAbstractFactory
    {
        public override PcMotherBoard MakePc()
        {
            return new PcMotherBoard(new RamMemory(2), new Bit32Cpu(2), new HDD(500), new ColorfulVideoCard());
        }

        public override LaptopMotherBoard MakeLaptop()
        {
            return new LaptopMotherBoard(new RamMemory(4), new Bit64Cpu(2), new HDD(500), new ColorfulVideoCard(), new LaptopBattery());
        }

        public override ServerMotherBoard MakeServer()
        {
            List<IHardDrive> disksInArray = new List<IHardDrive>();

            disksInArray.Add(new HDD(1000));
            disksInArray.Add(new HDD(1000));

            return new ServerMotherBoard(new RamMemory(32), new Bit32Cpu(8), new RaidArray(disksInArray), new MonochromeVideoCard());
        }
    }
}