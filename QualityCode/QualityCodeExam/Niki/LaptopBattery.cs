namespace Computers
{
    public class LaptopBattery : IBattery
    {
        public const int InitialBatteryPower = 50;
        private int powerProcentage;

        public LaptopBattery()
        {
            this.PowerProcentage = InitialBatteryPower;
        }

        internal int PowerProcentage
        {
            get
            {
                return this.powerProcentage;
            }

            set
            {
                if (value < 0)
                {
                    this.powerProcentage = 0;
                }

                if (value > 100)
                {
                    this.powerProcentage = 100;
                }
                else
                {
                    this.powerProcentage = value;
                }
            }
        }

        public void Charge(int chargeWith)
        {
            int rawPowerResult = this.PowerProcentage + chargeWith;

            this.PowerProcentage = rawPowerResult;
        }

        public int CurrentBatteryPower()
        {
            return this.PowerProcentage;
        }
    }
}
