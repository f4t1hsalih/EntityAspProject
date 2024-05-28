using EntityAspProject.Entity;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityAspProject.Sales
{
    public partial class SaleUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int id = int.Parse(Request.QueryString["Update"]);
            if (!Page.IsPostBack)
            {
                var sale = db.tbl_sale.Find(id);

                //Ürünler
                var product = (from x in db.tbl_product where x.prd_status != false select new { x.prd_id, x.prd_name }).ToList();
                ddlPrdName.DataTextField = "prd_name";
                ddlPrdName.DataValueField = "prd_id";
                ddlPrdName.DataSource = product;
                ddlPrdName.DataBind();
                ddlPrdName.SelectedValue = sale.sal_prd.ToString();

                //Müşteriler
                var customer = (from x in db.tbl_customer where x.ctm_status != false select new { x.ctm_id, Customer = x.ctm_name + " " + x.ctm_surname }).ToList();
                ddlCtmName.DataTextField = "customer";
                ddlCtmName.DataValueField = "ctm_id";
                ddlCtmName.DataSource = customer;
                ddlCtmName.DataBind();
                ddlCtmName.SelectedValue = sale.sal_ctm.ToString();

                //Çalışan
                var staff = (from x in db.tbl_staff where x.stf_status != false select new { x.stf_id, x.stf_name_surname }).ToList();
                ddlStfName.DataTextField = "stf_name_surname";
                ddlStfName.DataValueField = "stf_id";
                ddlStfName.DataSource = staff;
                ddlStfName.DataBind();
                ddlStfName.SelectedValue = sale.sal_stf.ToString();

                //Fiyat
                txtPrice.Text = sale.sal_price.ToString();
            }
        }

        protected void btnSalUpdate_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            int id = int.Parse(Request.QueryString["Update"]);
            var value = db.tbl_sale.Find(id);
            value.sal_prd = int.Parse(ddlPrdName.SelectedValue);
            value.sal_stf = byte.Parse(ddlStfName.SelectedValue);
            value.sal_ctm = int.Parse(ddlCtmName.SelectedValue);
            value.sal_price = decimal.Parse(txtPrice.Text);
            db.SaveChanges();
            Response.Redirect("/Sales/SaleList.aspx");
        }
    }
}