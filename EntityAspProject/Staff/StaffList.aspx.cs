using EntityAspProject.Entity;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace EntityAspProject.Staff
{
    public partial class StaffList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            Repeater1.DataSource = (from x in db.tbl_staff where x.stf_status != false select x).ToList();
            Repeater1.DataBind();
        }
    }
}