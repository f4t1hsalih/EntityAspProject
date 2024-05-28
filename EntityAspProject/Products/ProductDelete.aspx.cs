using EntityAspProject.Entity;
using System;

namespace EntityAspProject.Products
{
    public partial class ProductDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Delete"]);
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            var value = db.tbl_product.Find(id);
            value.prd_status = false;
            db.SaveChanges();
            Response.Redirect("/Products/ProductList.aspx");
        }
    }
}