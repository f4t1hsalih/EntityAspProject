using EntityAspProject.Entity;
using System;

namespace EntityAspProject.Staff
{
    public partial class StaffDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int id = int.Parse(Request.QueryString["Delete"].ToString());
            var value = db.tbl_staff.Find(id);
            value.stf_status = false;
            db.SaveChanges();
            Response.Redirect("/Staff/StaffList.aspx");
        }
    }
}