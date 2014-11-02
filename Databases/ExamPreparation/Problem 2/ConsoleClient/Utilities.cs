namespace ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Utilities
    {
        private static Utilities utilities;
        private Random random;

        private Utilities()
        {
            this.random = new Random();
        }

        public static Utilities Instance 
        {
            get
            {
                if (utilities == null)
                {
                    utilities = new Utilities();
                }

                return utilities;
            }
        }

        public string GenerateRandomString(int minChars, int maxChars)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[maxChars];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[this.random.Next(chars.Length)];
            }

            var finalString = new String(stringChars).Substring(0, GenerateRandomInteger(minChars, maxChars));

            return finalString;
        }

        public int GenerateRandomInteger(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }

        public double GenerateRandomDouble(double min, double max)
        {
            if (min >= max)
            {
                throw new ArgumentOutOfRangeException();
            }

            return this.random.NextDouble() * (Math.Abs(max - min)) + min;
        }

        public decimal GenerateRandomPrice(double min, double max)
        {
            double rawPrice = GenerateRandomDouble(min, max);
            double filteredPrice = Math.Truncate(rawPrice * 100) / 100;

            return (decimal)filteredPrice;
        }
    }
}
