using EntityAspProject.Entity;
using System;

namespace EntityAspProject.Staff
{
    public partial class StaffAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnStfAdd_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            tbl_staff staff = new tbl_staff();
            staff.stf_name_surname = txtStfNameSurname.Text;
            db.tbl_staff.Add(staff);
            db.SaveChanges();
            Response.Redirect("/Staff/StaffList.aspx");
        }
    }
}