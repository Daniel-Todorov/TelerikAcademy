namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PcMotherBoard : MotherBoard
    {
        public PcMotherBoard(IRamMemory ram, ICpu cpu, IHardDrive hardDrive, IVideoCard videoCard)
            : base(ram, cpu, hardDrive, videoCard)
        {
        }

        public string Play(int playerGuess)
        {
            this.cpu.GenerateRandomNumber(1, 11, this.ram);

            int numberToGuess = this.LoadRamValue();

            if (playerGuess != numberToGuess)
            {
                return string.Format("You didn’t guess the number {0}.", numberToGuess);
            }
            else
            {
                return "You win!";
            }
        }
    }
}