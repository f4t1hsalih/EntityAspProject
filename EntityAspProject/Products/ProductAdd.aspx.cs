using EntityAspProject.Entity;
using System;
using System.Linq;

namespace EntityAspProject.Products
{
    public partial class ProductAdd : System.Web.UI.Page
    {
        UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var value = (from x in db.tbl_category select new { x.ctg_id, x.ctg_name }).ToList();
                ddlPrdCategory.DataTextField = "ctg_name";
                ddlPrdCategory.DataValueField = "ctg_id";
                ddlPrdCategory.DataSource = value;
                ddlPrdCategory.DataBind();
            }
            
        }

        protected void btnPrdAdd_Click(object sender, EventArgs e)
        {
            tbl_product product = new tbl_product();
            product.prd_name = txtPrdName.Text;
            product.prd_brand = txtPrdBrand.Text;
            product.prd_ctg = byte.Parse(ddlPrdCategory.SelectedValue);
            product.prd_stock = short.Parse(txtPrdStock.Text);
            product.prd_price = decimal.Parse(txtPrdPrice.Text);
            db.tbl_product.Add(product);
            db.SaveChanges();
            Response.Redirect("ProductList.aspx");
        }
    }
}