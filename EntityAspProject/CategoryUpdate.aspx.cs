using EntityAspProject.Entity;
using System;

namespace EntityAspProject
{
    public partial class CategoryUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int x = Convert.ToInt32(Request.QueryString["Update"]);
                UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
                var value = db.tbl_category.Find(x);
                txtCategoryID.Text = value.ctg_id.ToString();
                txtCategoryName.Text = value.ctg_name.ToString();
            }
        }

        protected void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int x = Convert.ToInt32(Request.QueryString["Update"]);
            db.tbl_category.Find(x).ctg_name = txtCategoryName.Text;
            db.SaveChanges();
            Response.Redirect("Categories.aspx");
        }
    }
}