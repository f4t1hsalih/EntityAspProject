using EntityAspProject.Entity;
using System;

namespace EntityAspProject.Staff
{
    public partial class StaffUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
                int id = int.Parse(Request.QueryString["Update"]);
                var value = db.tbl_staff.Find(id);
                txtStfNameSurname.Text = value.stf_name_surname;
            }
        }

        protected void btnStfUpdate_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int id = int.Parse(Request.QueryString["Update"].ToString());
            var value = db.tbl_staff.Find(id);
            value.stf_name_surname = txtStfNameSurname.Text;
            db.SaveChanges();
            Response.Redirect("/Staff/StaffList.aspx");
        }
    }
}