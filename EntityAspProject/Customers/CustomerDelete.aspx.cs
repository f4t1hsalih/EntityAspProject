using EntityAspProject.Entity;
using System;

namespace EntityAspProject.Customers
{
    public partial class CustomerDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int id = int.Parse(Request.QueryString["Delete"]);
            var value = db.tbl_customer.Find(id);
            value.ctm_status = false;
            db.SaveChanges();
            Response.Redirect("/Customers/Customers.aspx");
        }
    }
}