namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bit32Cpu : Cpu, ICpu
    {
        public Bit32Cpu(int numberOfCores)
        {
            this.numberOfCores = numberOfCores;
            this.calculateSquareStrategy = new Bit32CalculateSquareStrategy();
        }
    }
}