using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04.ToDoList
{
    public partial class ToDoApp : System.Web.UI.Page
    {
        private ToDoAppData context;

        public ToDoApp()
        {
            this.context = new ToDoAppData();
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
        public IQueryable ListViewCategories_GetData()
        {
            var allCategories = context.Categories;

            return allCategories;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_DeleteItem(int id)
        {
            context.Categories.Remove(context.Categories.FirstOrDefault(category => category.Id == id));
            context.SaveChanges();

            Response.Redirect(Request.RawUrl);
        }

        public void ListViewCategories_InsertItem()
        {
            var item = new Category();

            this.TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                context.Categories.Add(item);
                this.context.SaveChanges();

                Response.Redirect(Request.RawUrl);
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_UpdateItem(int id)
        {
            Category item = null;
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            item = this.context.Categories.Find(id);

            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            this.TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();
                this.context.SaveChanges();

                Response.Redirect(Request.RawUrl);
            }
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Todo> ListViewToDos_GetData()
        {
            return this.context.Todos;
        }

        public IQueryable<Category> SelectCategoriesForDropDownInsert()
        {
            var result = this.context.Categories;
            return result;
        }

        public void ListViewToDos_InsertItem(int categoryId)
        {
            var item = new Todo();

            this.TryUpdateModel(item);
            item.DateOfLastChange = DateTime.Now;

            if (ModelState.IsValid)
            {
                // Save changes here
                this.context.Todos.Add(item);
                this.context.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewToDos_DeleteItem(int id)
        {
            this.context.Todos.Remove(this.context.Todos.Find(id));
            this.context.SaveChanges();

            Response.Redirect(Request.RawUrl);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewToDos_UpdateItem(int id)
        {
            Todo item = null;
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            item = context.Todos.Find(id);

            if (item == null)
            {
                // The item wasn't found
                this.ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            this.TryUpdateModel(item);
            item.DateOfLastChange = DateTime.Now;

            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();
                this.context.SaveChanges();

                Response.Redirect(Request.RawUrl);
            }
        }
    }
}