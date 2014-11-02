namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ServerMotherBoard : MotherBoard
    {
        public ServerMotherBoard(IRamMemory ram, ICpu cpu, IHardDrive hardDrive, IVideoCard videoCard)
            : base(ram, cpu, hardDrive, videoCard)
        {
        }

        public string ProcessData()
        {
            return this.cpu.CalculateSquareNumber();
        }
    }
}