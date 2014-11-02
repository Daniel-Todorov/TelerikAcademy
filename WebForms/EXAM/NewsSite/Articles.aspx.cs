using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSite
{
    public partial class Articles : Page
    {
        private NewsDbContext db;

        public Articles()
        {
            this.db = new NewsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Article> ListViewArticles_GetData()
        {
            return this.db.Articles;
        }

        public IQueryable<Category> DropDownListCategoriesEdit_GetData()
        {
            return this.db.Categories;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewArticles_UpdateItem(int id)
        {
            Article item = db.Articles.Find(id);
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();
                db.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewArticles_DeleteItem(int id)
        {
            this.db.Articles.Remove(this.db.Articles.Find(id));
            this.db.SaveChanges();
        }

        public void ListViewArticles_InsertItem()
        {
            var item = new Article();

            TryUpdateModel(item);

            item.DateCreated = DateTime.Now;
            item.AuthorId = db.Users.Where(u => u.UserName == this.Context.User.Identity.Name).FirstOrDefault().Id;

            if (ModelState.IsValid)
            {
                db.Articles.Add(item);
                db.SaveChanges();
            }
        }
    }
}