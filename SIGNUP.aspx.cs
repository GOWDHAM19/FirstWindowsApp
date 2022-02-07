using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WEBFORM_NEW
{
    public partial class SIGNUP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "ADMIN" && TextBox2.Text == "12345")
            {
                
                Response.Redirect("~/LOGIN.aspx");
            }
            
            else
            {
                Label3.Text = "Invalid Username and Password";
                Label3.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}