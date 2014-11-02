namespace Computers
{
    public class RamMemory : IRamMemory
    {
        private int maximumAmount;
        private int storedValue;

        public RamMemory(int maximumAmount)
        {
            this.maximumAmount = maximumAmount;
        }

        public void SaveInteger(int newValue)
        {
            this.storedValue = newValue;
        }

        public int LoadInteger()
        {
            return this.storedValue;
        }
    }
}