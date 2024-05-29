using EntityAspProject.Entity;
using System;
using System.Linq;

namespace EntityAspProject.Statistics
{
    public partial class Statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            Label1.Text = db.tbl_product.Where(x => x.prd_status != false).Count().ToString();
            Label2.Text = db.tbl_customer.Where(x => x.ctm_status != false).Count().ToString();
            Label3.Text = db.tbl_sale.Where(x => x.sal_status != false).Sum(x=>x.sal_price).ToString()+" ₺";
            Label4.Text = db.tbl_category.Where(x => x.ctg_status != false).Count().ToString();
        }
    }
}