using EntityAspProject.Entity;
using System;
using System.Linq;

namespace EntityAspProject.Sales
{
    public partial class NewSale : System.Web.UI.Page
    {
        UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Ürünler
                var product = (from x in db.tbl_product where x.prd_status != false select new { x.prd_id, x.prd_name }).ToList();
                ddlPrdName.DataTextField = "prd_name";
                ddlPrdName.DataValueField = "prd_id";
                ddlPrdName.DataSource = product;
                ddlPrdName.DataBind();

                //Müşteriler
                var customer = (from x in db.tbl_customer where x.ctm_status != false select new { x.ctm_id, Customer = x.ctm_name + " " + x.ctm_surname }).ToList();
                ddlCtmName.DataTextField = "customer";
                ddlCtmName.DataValueField = "ctm_id";
                ddlCtmName.DataSource = customer;
                ddlCtmName.DataBind();

                //Çalışan
                var staff = (from x in db.tbl_staff where x.stf_status != false select new { x.stf_id, x.stf_name_surname }).ToList();
                ddlStfName.DataTextField = "stf_name_surname";
                ddlStfName.DataValueField = "stf_id";
                ddlStfName.DataSource = staff;
                ddlStfName.DataBind();

            }
        }

        protected void btnSalAdd_Click(object sender, EventArgs e)
        {
            UdemyProductTrackingEntities db = new UdemyProductTrackingEntities();
            tbl_sale sale = new tbl_sale();
            sale.sal_prd = int.Parse(ddlPrdName.SelectedValue);
            sale.sal_stf = byte.Parse(ddlStfName.SelectedValue);
            sale.sal_ctm = int.Parse(ddlCtmName.SelectedValue);
            sale.sal_price = decimal.Parse(txtPrice.Text);
            db.tbl_sale.Add(sale);
            db.SaveChanges();
            Response.Redirect("/Sales/SaleList.aspx");
        }
    }
}