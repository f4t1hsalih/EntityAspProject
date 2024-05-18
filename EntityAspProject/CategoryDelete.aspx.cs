using EntityAspProject.Entity;
using System;

namespace EntityAspProject
{
    public partial class CategoryDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["Delete"]);
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            var value = db.tbl_category.Find(x);
            db.tbl_category.Remove(value);
            db.SaveChanges();
            Response.Redirect("Categories.aspx");
        }
    }
}