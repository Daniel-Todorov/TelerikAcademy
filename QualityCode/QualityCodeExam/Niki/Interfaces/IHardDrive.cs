namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IHardDrive
    {
        void SaveData(int systemAdress, string textToStore);

        string LoadData(int systemAdress);
    }
}
