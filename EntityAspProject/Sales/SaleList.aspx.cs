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
            //var values = db.tbl_sale.ToList();

            var values = (from x in db.tbl_sale
                          where x.sal_status != false
                          select new
                          {
                              x.sal_id,
                              x.tbl_product.prd_name,
                              x.tbl_staff.stf_name_surname,
                              customer = x.tbl_customer.ctm_name + " " + x.tbl_customer.ctm_surname,
                              x.sal_price
                          }).ToList();
            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }
    }
}