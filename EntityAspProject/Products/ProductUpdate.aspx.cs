using EntityAspProject.Entity;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityAspProject.Products
{
    public partial class ProductUpdate : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int id = Convert.ToInt32(Request.QueryString["Update"]);
            if (Page.IsPostBack == false)
            {
                var values = (from x in db.tbl_category select new { x.ctg_id, x.ctg_name }).ToList();
                ddlPrdCategory.DataTextField = "ctg_name";
                ddlPrdCategory.DataValueField = "ctg_id";
                ddlPrdCategory.DataSource = values;
                ddlPrdCategory.DataBind();

                var product = db.tbl_product.Find(id);
                txtPrdID.Text = product.prd_id.ToString();
                txtPrdName.Text = product.prd_name;
                txtPrdBrand.Text = product.prd_brand;
                ddlPrdCategory.SelectedValue = product.prd_ctg.ToString();
                txtPrdPrice.Text = product.prd_price.ToString();
                txtPrdStock.Text = product.prd_stock.ToString();

            }
        }

        protected void btnPrdUpdate_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int id = Convert.ToInt32(Request.QueryString["Update"]);

            var prod = db.tbl_product.Find(id);
            prod.prd_name = txtPrdName.Text;
            prod.prd_brand = txtPrdBrand.Text;
            prod.prd_ctg = byte.Parse(ddlPrdCategory.SelectedValue.ToString());
            prod.prd_price = decimal.Parse(txtPrdPrice.Text);
            prod.prd_stock = short.Parse(txtPrdStock.Text);
            db.SaveChanges();
            Response.Redirect("/Products/ProductList.aspx");
        }
    }
}