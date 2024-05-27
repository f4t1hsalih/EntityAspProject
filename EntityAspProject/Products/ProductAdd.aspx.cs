using EntityAspProject.Entity;
using System;

namespace EntityAspProject.Products
{
    public partial class ProductAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrdAdd_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            tbl_product product = new tbl_product();
            product.prd_name = txtPrdName.Text;
            product.prd_brand = txtPrdBrand.Text;
            product.prd_ctg = byte.Parse(txtPrdCategory.Text);
            product.prd_stock = short.Parse(txtPrdStock.Text);
            product.prd_price = decimal.Parse(txtPrdPrice.Text);
            db.tbl_product.Add(product);
            db.SaveChanges();
            Response.Redirect("ProductList.aspx");
        }
    }
}