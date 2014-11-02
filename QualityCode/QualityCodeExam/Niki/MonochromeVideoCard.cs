namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MonochromeVideoCard : VideoCard, IVideoCard
    {
        public MonochromeVideoCard()
        {
            this.drawStrategy = new MonochromeDrawStrategy();
        }
    }
}
