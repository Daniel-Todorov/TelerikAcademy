namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bit32CalculateSquareStrategy : ICalculateSquareStrategy
    {
        public string GetSquare(int numberToProcess)
        {
            if (numberToProcess < 0)
            {
                return "Number too low.";
            }
            else if (numberToProcess > 500)
            {
                return "Number too high.";
            }
            else
            {
                int square = numberToProcess * numberToProcess;

                return string.Format("Square of {0} is {1}.", numberToProcess, square);
            }
        }
    }
}