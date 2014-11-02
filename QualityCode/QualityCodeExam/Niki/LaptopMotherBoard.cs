namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LaptopMotherBoard : MotherBoard
    {
        public LaptopMotherBoard(IRamMemory ram, ICpu cpu, IHardDrive hardDrive, IVideoCard videoCard, IBattery battery)
            : base(ram, cpu, hardDrive, videoCard)
        {
            this.Battery = battery;
        }

        public IBattery Battery { get; set; }
    }
}