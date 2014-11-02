using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSite
{
    public partial class ArticleDetails : System.Web.UI.Page
    {
        private NewsDbContext db;

        public ArticleDetails()
        {
            this.db = new NewsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //// The id parameter should match the DataKeyNames value set on the control
        //// or be decorated with a value provider attribute, e.g. [QueryString]int id
        //public Article DetailsView_GetItem([QueryString]int? id)
        //{
        //    if (id == null)
        //    {
        //        return null;
        //    }

        //    return db.Articles.Find(id);
        //}

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<NewsSite.Models.Article> ListViewArticleDetails_GetData([QueryString]int? id)
        {
            if (id == null)
            {
                return null;
            }

            return db.Articles.Where(a => a.Id == id);
        }
    }
}