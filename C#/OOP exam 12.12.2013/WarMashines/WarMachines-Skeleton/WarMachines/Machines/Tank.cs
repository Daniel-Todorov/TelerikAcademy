using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Tank : IMachine, ITank
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
                    throw new NullReferenceException("The tank's name cannot be null.");
                }
                this.name = value;
            }
        }

        private IPilot pilot;
        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("The tank's pilot cannot be null.");
                }
                this.pilot = value;
            }
        }

        private double healthPoints;
        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        private double attackPoints;
        public double AttackPoints
        {
            get
            {
                if (this.DefenseMode)
                {
                    return (this.attackPoints - 40);
                }
                else
                {
                    return this.attackPoints;
                }
            }
            set
            {
                this.attackPoints = value;
            }
        }

        private double defensePoints;
        public double DefensePoints
        {
           get
            {
                if (this.DefenseMode)
                {
                    return (this.defensePoints + 30);
                }
                else
                {
                    return this.defensePoints;
                }
            }
            set
            {
                this.defensePoints = value;
            }
        }

        public IList<string> Targets { get; set; }

        public bool DefenseMode { get; set; }

        //Methods.
        public void Attack(string target)
        {
            if (target == null)
            {
                throw new NullReferenceException("Your target can't be null");
            }

            this.Targets.Add(target);
        }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("- ");
            result.AppendLine(this.Name);
            result.AppendLine(" *Type: Tank");
            result.Append(" *Health: ");
            result.AppendLine(this.HealthPoints.ToString());
            result.Append(" *Attack: ");
            result.AppendLine(this.AttackPoints.ToString());
            result.Append(" *Defense: ");
            result.AppendLine(this.DefensePoints.ToString());
            result.Append(" *Targets: ");

            if (this.Targets.Count == 0)
            {
                result.AppendLine("None");
            }
            else
            {
                for (int i = 0; i < this.Targets.Count - 1; i++)
                {
                    result.Append(this.Targets[i]);
                    result.Append(", ");
                }
                result.AppendLine(this.Targets[this.Targets.Count - 1]);
            }

            result.Append(" *Defense: ");
            if (this.DefenseMode)
            {
                result.Append("ON");
            }
            else
            {
                result.Append("OFF");
            }

            return result.ToString();
        }

        //Contructors
        public Tank(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;

            //with default values
            this.HealthPoints = 100;
            this.DefenseMode = true;
            this.Targets = new List<string>();
        }
    }
}
