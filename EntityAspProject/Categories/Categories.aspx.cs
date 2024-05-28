using EntityAspProject.Entity;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace EntityAspProject.Categories
{
    public partial class Categories : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            var values = (from x in db.tbl_category where x.ctg_status != false select x).ToList();
            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }
    }
}