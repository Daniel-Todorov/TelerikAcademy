namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HDD : IHardDrive
    {
        private int capacity;
        private SortedDictionary<int, string> storedInfo;

        public HDD(int capacity)
        {
            this.capacity = capacity;
            this.storedInfo = new SortedDictionary<int, string>();
        }

        // TODO where to set validation for the string textToStore ???
        public void SaveData(int systemAdress, string textToStore)
        {
            this.storedInfo[systemAdress] = textToStore;
        }

        public string LoadData(int systemAdress)
        {
            return this.storedInfo[systemAdress];
        }
    }
}
