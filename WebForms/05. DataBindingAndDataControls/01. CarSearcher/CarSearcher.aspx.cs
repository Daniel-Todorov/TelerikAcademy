using _01.CarSearcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.CarSearcher
{
    public partial class CarSearcher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                return;
            }

            IEnumerable<Producer> producers = this.GetProducers();

            this.ddlProducers.ItemType = "Producer";
            this.ddlProducers.DataSource = producers;
            this.ddlProducers.DataTextField = "Name";
            this.ddlProducers.DataBind();

            this.ddlModels.DataSource = producers.ToList()[0].Models;

            this.ddlEngineType.DataSource = GetEngineTypes();

            this.cblExtras.DataSource = GetExtras();
            this.cblExtras.DataTextField = "Name";
            this.cblExtras.RepeatColumns = 2;

            this.Page.DataBind();
        }

        private IEnumerable<Producer> GetProducers()
        {
            List<Producer> producers = new List<Producer>();

            producers.Add(new Producer()
            {
                Name = "Bentley",
                Models = new List<string>()
                {
                    "Arnage",
                    "Azure",
                    "Continental",
                    "Continental gt",
                    "Mulsanne",
                    "T-series"
                }
            });
            producers.Add(new Producer()
            {
                Name = "Corvette",
                Models = new List<string>()
                {
                    "C06 Convertible",
                    "C06 Coupe",
                    "Powa",
                    "Z06"
                }
            });
            producers.Add(new Producer()
            {
                Name = "Great Wall",
                Models = new List<string>()
                {
                    "Voleex C10",
                    "Voleex C30"
                }
            });

            return producers;
        }

        private string[] GetEngineTypes()
        {
            string[] result = new string[] {
                "Gasoline",
                "Diesel",
                "Electric",
                "Hybrid"
            };

            return result;
        }

        private IEnumerable<Extra> GetExtras()
        {
            var result = new List<Extra>();

            result.Add(new Extra()
            {
                Name="Alarm"
            });
            result.Add(new Extra()
            {
                Name = "Armored"
            });
            result.Add(new Extra()
            {
                Name = "Insurance"
            });
            result.Add(new Extra()
            {
                Name = "Central locking"
            });
            result.Add(new Extra()
            {
                Name = "Air conditioner"
            });
            result.Add(new Extra()
            {
                Name = "Electric windows"
            });
            result.Add(new Extra()
            {
                Name = "DVD"
            });
            result.Add(new Extra()
            {
                Name = "Navigation"
            });

            return result;
        }

        protected void ddlProducers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlProducers = sender as DropDownList;

            this.ddlModels.DataSource = this.GetProducers().FirstOrDefault(producer => producer.Name.Equals(ddlProducers.SelectedValue)).Models;
            this.ddlModels.DataBind();
        }

        protected void btnSubmit_Command(object sender, CommandEventArgs e)
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Brand: {0}<br>", this.ddlProducers.SelectedValue));
            result.AppendLine(string.Format("Model: {0}<br>", this.ddlModels.SelectedValue));

            if (this.cblExtras.Items.Cast<ListItem>().Count(item => item.Selected) > 0)
            {
                result.AppendLine("Extras:<br>");

                foreach (var item in this.cblExtras.Items.Cast<ListItem>())
                {
                    if (item.Selected)
                    {
                        result.AppendLine(string.Format("-  {0}<br>", item.Text));
                    }
                }
            }

            result.AppendLine(string.Format("Engine type: {0}<br>", this.ddlEngineType.SelectedValue));

            this.ltrSearchResult.Text = result.ToString();
        }
    }
}