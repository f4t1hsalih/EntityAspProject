using EntityAspProject.Entity;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace EntityAspProject.Products
{
    public partial class ProductList : System.Web.UI.Page
    {
        UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Method Syntax (Yöntem Sözdizimi)
            //var product1 = db.tbl_product.Where(x => x.prd_status == true).ToList();

            //Query Syntax (Sorgu Sözdizimi)
            var product = (from x in db.tbl_product where x.prd_status == true select x).ToList();
            Repeater1.DataSource = product;
            Repeater1.DataBind();
        }
    }
}