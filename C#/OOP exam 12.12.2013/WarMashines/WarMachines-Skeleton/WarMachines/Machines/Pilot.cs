using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Pilot : IPilot
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("The pilot's name cannot be null.");
                }
                this.name = value;
            }
        }

        public List<IMachine> machines { get; set; }

        //Methods.
        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
            this.machines.OrderBy(h => h.HealthPoints).ThenBy(n => n.Name);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.name);
            result.Append(" - ");

            if (this.machines.Count == 0)
            {
                result.Append("no machines");
                return result.ToString();
            }

            result.Append(this.machines.Count);

            if (this.machines.Count == 1)
            {
                result.Append(" machine");
            }
            else
            {
                result.Append(" machines");
            }

            result.AppendLine();

            foreach (var item in this.machines)
            {
                result.Append(item.ToString());
                result.AppendLine();
            }

            return result.ToString().TrimEnd('\r', '\n');
        }

        //Contructors.
        public Pilot(string name)
        {
            this.Name = name;

            //with default values
            this.machines = new List<IMachine>();
        }
    }
}
