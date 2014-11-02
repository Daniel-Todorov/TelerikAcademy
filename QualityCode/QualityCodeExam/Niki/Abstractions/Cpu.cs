namespace Computers
{
    using System;

    public abstract class Cpu : ICpu
    {
        private int numberOfCores;
        private ICalculateSquareStrategy calculateSquareStrategy;

        public int NumberOfCores
        {
            get;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The core must have at least one core!");
                }

                this.numberOfCores = value;
            }
        }

        public void GenerateRandomNumber(int minValue, int maxValue, IRamMemory ram)
        {
            Random random = new Random();
            int randomNumber = random.Next(minValue, maxValue);

            ram.SaveInteger(randomNumber);
        }

        public string CalculateSquareNumber(IRamMemory ram)
        {
            int numberToProcess = this.LoadData(ram);
            string result = this.calculateSquareStrategy.GetSquare(numberToProcess);

            return result;
        }

        private void SaveData(int numberToStore, IRamMemory ram)
        {
            ram.SaveInteger(numberToStore);
        }

        private int LoadData(IRamMemory ram)
        {
            return ram.LoadInteger();
        }
    }
}
