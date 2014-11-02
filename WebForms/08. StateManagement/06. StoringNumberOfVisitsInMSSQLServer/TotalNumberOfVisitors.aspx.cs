using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _06.StoringNumberOfVisitsInMSSQLServer
{
    public partial class TotalNumberOfVisitors : System.Web.UI.Page
    {
        private CounterEntities context;

        public TotalNumberOfVisitors()
        {
            this.context = new CounterEntities();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.context.Visits.First().NumberOfVisits += 1;
            this.context.SaveChanges();

            Response.Clear();

            Bitmap generatedImage = new Bitmap(80, 80);
            using (generatedImage)
            {
                Graphics gr = Graphics.FromImage(generatedImage);
                using (gr)
                {
                    gr.DrawString(
                        this.context.Visits.First().NumberOfVisits.ToString(),
                        new Font("Tahoma", 20),
                        Brushes.DarkRed,
                        new PointF(20, 20)
                        );

                    Response.ContentType = "image/jpg";

                    generatedImage.Save(Response.OutputStream, ImageFormat.Jpeg);
                }
            }
        }
    }
}