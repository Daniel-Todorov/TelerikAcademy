namespace Computers
{
    public interface IRamMemory
    {
        void SaveInteger(int integerValueToStore);

        int LoadInteger();
    }
}
