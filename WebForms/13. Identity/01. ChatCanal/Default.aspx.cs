using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _01.ChatCanal.Models;

namespace _01.ChatCanal
{
    public partial class _Default : Page
    {
        protected ChatCanelContext context;

        public _Default()
        {
            this.context = new ChatCanelContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Context.User.Identity.IsAuthenticated)
            {
                this.ListViewMessages.Visible = false;
                this.LabelPleaseLogIn.Visible = true;

                return;
            }

            this.ListViewMessages.Visible = true;
            this.LabelPleaseLogIn.Visible = false;
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<_01.ChatCanal.Models.Message> ListViewMessages_GetData()
        {
            return this.context.Messages;
        }

        public void ListViewMessages_InsertItem()
        {
            var item = new Message();

            TryUpdateModel(item);
            item.DateSent = DateTime.Now;
            item.SenderName = this.Context.User.Identity.Name;

            if (ModelState.IsValid)
            {
                this.context.Messages.Add(item);
                this.context.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewMessages_DeleteItem(int id)
        {
            var messageToDelete = this.context.Messages.Find(id);

            if (messageToDelete != null)
            {
                this.context.Messages.Remove(messageToDelete);
                this.context.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewMessages_UpdateItem(int id)
        {
            Message item = null;
            item = this.context.Messages.Find(id);

            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                this.context.SaveChanges();
            }
        }
    }
}