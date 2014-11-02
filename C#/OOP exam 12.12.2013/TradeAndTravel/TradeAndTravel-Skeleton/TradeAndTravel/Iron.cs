using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class Iron : Item
    {
        const int IronValue = 3;

        public Iron(string name, Location location = null)
            : base(name, Iron.IronValue, ItemType.Iron, location)
        {
        }

        //static List<ItemType> GetComposingItems()
        //{
        //    return new List<ItemType>() { ItemType.Iron };
        //}
    }
}
