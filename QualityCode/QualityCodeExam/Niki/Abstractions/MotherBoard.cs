namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class MotherBoard : IMotherboard
    {
        private IRamMemory ram;
        private ICpu cpu;
        private IHardDrive hardDrive;
        private IVideoCard videoCard;

        public MotherBoard(IRamMemory ram, ICpu cpu, IHardDrive hardDrive, IVideoCard videoCard)
        {
            this.ram = ram;
            this.cpu = cpu;
            this.hardDrive = hardDrive;
            this.videoCard = videoCard;
        }

        public int LoadRamValue()
        {
            return this.ram.LoadInteger();
        }

        public void SaveRamValue(int value)
        {
            this.ram.SaveInteger(value);
        }

        public void DrawOnVideoCard(string data)
        {
            this.videoCard.AddData(data);
        }

        public void EndPresentation()
        {
            this.videoCard.DrawTextData();
        }
    }
}