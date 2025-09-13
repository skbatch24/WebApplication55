using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication55
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Welcome";
            Response.Write("Welcome i have written some code ");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "Hello";
        }
    }
}
