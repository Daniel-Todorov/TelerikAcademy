namespace Computers
{
    public interface IBattery
    {
        void Charge(int chargeWith);

        int CurrentBatteryPower();
    }
}
