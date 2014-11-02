namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ColorfulVideoCard : VideoCard, IVideoCard
    {
        public ColorfulVideoCard()
        {
            this.drawStrategy = new MonochromeDrawStrategy();
        }
    }
}
