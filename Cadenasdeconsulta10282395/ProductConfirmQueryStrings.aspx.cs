using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cadenasdeconsulta10282395
{
    public partial class ProductConfirmQueryStrings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Retrieve the query string's parameters from the encoded URL.
            ddlCategory.SelectedValue = Request.QueryString["ddlCategory"];
            ddlSupplier.SelectedValue = Request.QueryString["ddlSupplier"];
            lblProduct.Text = Request.QueryString["strProduct"];
            txtDescription.Text = Request.QueryString["strDescription"];
            lblImage.Text = Request.QueryString["strImage"];
            Decimal decPrice = Convert.ToDecimal(Request.QueryString["decPrice"]);
            lblPrice.Text = decPrice.ToString("c");
            lblNumberInStock.Text = Request.QueryString["bytNumberInStock"];
            lblNumberOnOrder.Text = Request.QueryString["bytNumberOnOrder"];
            lblReorderLevel.Text = Request.QueryString["bytReorderLevel"];

            // Compute and display the value in stock and the value on order.
            Byte bytNumberInStock = Convert.ToByte(Request.QueryString["bytNumberInStock"]);
            Byte bytNumberOnOrder = Convert.ToByte(Request.QueryString["bytNumberOnOrder"]);
            Decimal decValueInStock = decPrice * bytNumberInStock;
            Decimal decValueOnOrder = decPrice * bytNumberOnOrder;
            lblValueInStock.Text = decValueInStock.ToString("c");
            lblValueOnOrder.Text = decValueOnOrder.ToString("c");
        }
    }
}