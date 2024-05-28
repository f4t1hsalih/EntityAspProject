using EntityAspProject.Entity;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace EntityAspProject.Sales
{
    public partial class SaleList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            var values = db.tbl_sale.ToList();
            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }
    }
}