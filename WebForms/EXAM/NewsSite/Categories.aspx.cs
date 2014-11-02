using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSite
{
    public partial class Categories : Page
    {
        private NewsDbContext db;

        public Categories()
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
        public IQueryable<Category> ListViewCategories_GetData()
        {
            return db.Categories;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_UpdateItem(int id)
        {
            Category item = db.Categories.Find(id);
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
                db.SaveChanges();
            }
        }

        public void ListViewCategories_InsertItem()
        {

            var item = new Category();

            TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                db.Categories.Add(item);

                db.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_DeleteItem(int id)
        {
            db.Articles.RemoveRange(db.Articles.Where(a => a.CategoryId == id));
            db.SaveChanges();

            db.Categories.Remove(db.Categories.Find(id));
            db.SaveChanges();
        }
    }
}