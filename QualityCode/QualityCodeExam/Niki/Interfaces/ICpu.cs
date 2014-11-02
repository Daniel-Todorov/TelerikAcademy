namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICpu
    {
        void SaveData(int numberToStore, IRamMemory ram);

        int LoadData(IRamMemory ram);

        void GenerateRandomNumber(int minValue, int maxValue, IRamMemory ram);

        string CalculateSquareNumber();
    }
}
