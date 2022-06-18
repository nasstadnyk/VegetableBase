using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VegetableBase.Models;
using System.Web.ModelBinding;
using Stripe;
using Stripe.Checkout;

namespace VegetableBase.Checkout
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout/Checkout.aspx");
        }

        public string sessionId = " ";

        public void StripeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://buy.stripe.com/test_4gw5n399c6E60ik288");
        }


    }
}