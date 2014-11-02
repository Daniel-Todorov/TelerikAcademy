namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bit128Cpu : Cpu, ICpu
    {
        public Bit128Cpu(int numberOfCores)
        {
            this.numberOfCores = numberOfCores;
            this.calculateSquareStrategy = new Bit128CalculateSquareStrategy();
        }
    }
}