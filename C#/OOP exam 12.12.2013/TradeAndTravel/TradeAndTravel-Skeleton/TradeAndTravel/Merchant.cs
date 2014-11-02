using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class Merchant : Person, ITraveller, IShopkeeper
    {
        public virtual void TravelTo(Location location)
        {
            this.Location = location;
        }

        public virtual int CalculateSellingPrice(Item item)
        {
            return item.Value;
        }

        public virtual int CalculateBuyingPrice(Item item)
        {
            return item.Value / 2;
        }

        public Merchant(string name, Location location)
            : base(name, location)
        {
        }
    }
}
