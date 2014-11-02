using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _06.TreeViewSample
{
    public partial class BooksTree : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void trvBooks_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeView trvBooks = sender as TreeView;

            var wtf = trvBooks.SelectedNode;
            
            //this.trvBookDetails.DataBind();
        }
    }
}