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
                var product = (from x in db.tbl_product where x.prd_status == true select new { x.prd_id, x.prd_name }).ToList();
                ddlPrdName.DataTextField = "prd_name";
                ddlPrdName.DataValueField = "prd_id";
                ddlPrdName.DataSource = product;
                ddlPrdName.DataBind();

                //Müşteriler
                var customer = (from x in db.tbl_customer where x.ctm_status == true select new { x.ctm_id, Customer = x.ctm_name + " " + x.ctm_surname }).ToList();
                ddlCtmName.DataTextField = "customer";
                ddlCtmName.DataValueField = "ctm_id";
                ddlCtmName.DataSource = customer;
                ddlCtmName.DataBind();

                //Çalışan
                var staff = (from x in db.tbl_staff where x.stf_status == true select new { x.stf_id, x.stf_name_surname }).ToList();
                ddlStfName.DataTextField = "stf_name_surname";
                ddlStfName.DataValueField = "stf_id";
                ddlStfName.DataSource = staff;
                ddlStfName.DataBind();

            }
        }
    }
}