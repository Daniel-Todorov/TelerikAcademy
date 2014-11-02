using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using _01.NorthwindEmployeesAndOrders;

namespace _01.NorthwindEmployeesAndOrders
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewEmployees2_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);

            this.UpdatePanelOrders.Visible = true;
            this.GridViewOrders2.DataSourceID = "SqlDataSourceOrders";
            this.GridViewOrders2.DataBind();
        }
    }
}