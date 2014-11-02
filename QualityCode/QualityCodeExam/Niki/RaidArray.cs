namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RaidArray : IHardDrive
    {
        private readonly string noHardDriveErrorMessage = "No hard drive in the RAID array!";
        private List<IHardDrive> hardDrivesInRaid;

        public RaidArray(List<IHardDrive> hardDrivesInRaid)
        {
            this.hardDrivesInRaid = hardDrivesInRaid;
        }

        public void SaveData(int systemAdress, string textToStore)
        {
            this.CheckForHardDrive();

            foreach (IHardDrive hardDrive in this.hardDrivesInRaid)
            {
                hardDrive.SaveData(systemAdress, textToStore);
            }
        }

        public string LoadData(int systemAdress)
        {
            this.CheckForHardDrive();

            IHardDrive firstHardDrive = this.hardDrivesInRaid.First();

            return firstHardDrive.LoadData(systemAdress);
        }

        private void CheckForHardDrive()
        {
            if (this.hardDrivesInRaid == null || this.hardDrivesInRaid.Count < 1)
            {
                throw new InvalidOperationException(this.noHardDriveErrorMessage);
            }
        }
    }
}
