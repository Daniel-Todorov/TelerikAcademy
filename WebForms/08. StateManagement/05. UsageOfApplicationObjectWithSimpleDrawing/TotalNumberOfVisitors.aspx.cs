using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _05.UsageOfApplicationObjectWithSimpleDrawing
{
    public partial class TotalNumberOfVisitors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Application.Lock();

            if (this.Application["totalNumberOfVisits"] == null)
            {
                this.Application["totalNumberOfVisits"] = 1;
            }
            else
            {
                this.Application["totalNumberOfVisits"] = (int)this.Application["totalNumberOfVisits"] + 1;
            }

            this.Application.UnLock();

            Response.Clear();

            Bitmap generatedImage = new Bitmap(80, 80);
            using (generatedImage)
            {
                Graphics gr = Graphics.FromImage(generatedImage);
                using (gr)
                {
                    gr.DrawString(
                         this.Application["totalNumberOfVisits"].ToString(),
                        new Font("Tahoma", 20),
                        Brushes.DarkRed,
                        new PointF(20, 20)
                        );

                    Response.ContentType = "image/jpg";

                    generatedImage.Save(Response.OutputStream, ImageFormat.Jpeg);
                }
            }

            //If the application stops, the counter is reseted!
        }
    }
}