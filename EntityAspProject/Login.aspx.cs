using EntityAspProject.Entity;
using System;
using System.Linq;

namespace EntityAspProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            var value = from x in db.tbl_admin where x.user == txtName.Text && x.password == txtPassword.Text select x;
            if (value.Any())
            {
                Response.Redirect("/Customers/Customers.aspx");
            }
            else
            {
                lblMessage.Visible = true;
            }

        }
    }
}