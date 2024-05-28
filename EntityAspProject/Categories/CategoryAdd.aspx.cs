using EntityAspProject.Entity;
using System;

namespace EntityAspProject.Categories
{
    public partial class CategoryAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            tbl_category t = new tbl_category();
            t.ctg_name = txtCategoryName.Text;
            db.tbl_category.Add(t);
            db.SaveChanges();
            Response.Redirect("/Categories/Categories.aspx");
        }
    }
}