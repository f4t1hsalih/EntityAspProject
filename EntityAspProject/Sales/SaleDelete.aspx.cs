using EntityAspProject.Entity;
using System;

namespace EntityAspProject.Sales
{
    public partial class SaleDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int id = int.Parse(Request.QueryString["Delete"]);
            var value = db.tbl_sale.Find(id);
            value.sal_status = false;
            db.SaveChanges();
            Response.Redirect("/Sales/SaleList.aspx");
        }
    }
}