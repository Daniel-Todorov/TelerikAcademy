namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bit64Cpu : Cpu, ICpu
    {
        public Bit64Cpu(int numberOfCores)
        {
            this.numberOfCores = numberOfCores;
            this.calculateSquareStrategy = new Bit64CalculateSquareStrategy();
        }
    }
}