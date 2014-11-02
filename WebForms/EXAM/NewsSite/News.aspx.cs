using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSite
{
    public partial class News : Page
    {
        private NewsDbContext db;

        public News()
        {
            this.db = new NewsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public System.Collections.IEnumerable RepeaterMostPopularArticles_GetData()
        {
            return db.Articles.OrderByDescending(a => a.Likes.Count(l => l.Value > 0)).Take(3);
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<NewsSite.Models.Category> ListViewAllCategories_GetData()
        {
            return db.Categories.OrderBy(c => c.Name);
        }
    }
}