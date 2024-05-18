using EntityAspProject.Entity;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace EntityAspProject
{
    public partial class Categories : System.Web.UI.Page
    {
        UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.tbl_category.ToList();
            Repeater1.DataBind();
        }
    }
}