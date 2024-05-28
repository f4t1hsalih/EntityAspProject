using EntityAspProject.Entity;
using System;
using System.Web.UI;

namespace EntityAspProject.Customers
{
    public partial class CustomerUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int id = int.Parse(Request.QueryString["Update"]);
            if (!Page.IsPostBack)
            {
                var customer = db.tbl_customer.Find(id);
                txtCtmID.Text = customer.ctm_id.ToString();
                txtCtmName.Text = customer.ctm_name;
                txtCtmSurname.Text = customer.ctm_surname;
            }
        }

        protected void btnCtmUpdate_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int id = int.Parse(Request.QueryString["Update"]);
            var customer = db.tbl_customer.Find(id);
            customer.ctm_name = txtCtmName.Text;
            customer.ctm_surname = txtCtmSurname.Text;
            db.SaveChanges();
            Response.Redirect("/Customers/Customers.aspx");
        }
    }
}