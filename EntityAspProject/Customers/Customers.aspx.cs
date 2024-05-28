using EntityAspProject.Entity;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace EntityAspProject.Customers
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            var values = (from x in db.tbl_customer where x.ctm_status != false select x).ToList();
            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }

        protected void btnCtmKaydet_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            tbl_customer customer = new tbl_customer();
            customer.ctm_name = txtCtmName.Text;
            customer.ctm_surname = txtCtmSurnaame.Text;
            db.tbl_customer.Add(customer);
            db.SaveChanges();
            Response.Redirect("/Customers/Customers.aspx");
        }
    }
}