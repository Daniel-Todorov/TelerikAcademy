namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class VideoCard : IVideoCard
    {
        private IDrawStrategy drawStrategy;
        private StringBuilder storeData;

        public void DrawTextData()
        {
            string stringifiedData = this.storeData.ToString();
            this.drawStrategy.Draw(stringifiedData);
        }

        public void AddData(string data)
        {
            this.storeData.AppendLine(data);
        }
    }
}
