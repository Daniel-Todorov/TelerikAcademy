using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01._03.WorldWideInfo
{
    public partial class WorldWide : System.Web.UI.Page
    {
        DbContext context = new WorldWideEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EntityDataSourceContinents_Selecting(object sender, EntityDataSourceSelectingEventArgs e)
        {

        }
    }
}