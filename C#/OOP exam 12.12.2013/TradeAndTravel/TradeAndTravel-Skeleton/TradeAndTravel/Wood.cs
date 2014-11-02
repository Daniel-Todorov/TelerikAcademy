using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class Wood : Item
    {
        public int WoodValue { get; set; }

        public Wood(string name, Location location = null)
            : base(name, 2, ItemType.Wood, location)
        {
        }

        static List<ItemType> GetComposingItems()
        {
            return new List<ItemType>() { ItemType.Wood };
        }

        public override void UpdateWithInteraction(string interaction)
        {
            switch (interaction)
            {
                case "drop":
                    if (this.WoodValue > 0)
                    {
                        this.WoodValue -= 1;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
