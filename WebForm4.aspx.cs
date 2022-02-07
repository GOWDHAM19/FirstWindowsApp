using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Session
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ViewState.Add("Value", 0); //we can take any integer value here.
            }
        }





        protected void Button1_Click1(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2 = Convert.ToInt32(TextBox2.Text);
            int result = num1 + num2;
            ViewState["Value"] = result.ToString();

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox3.Text);
            int num2 = Convert.ToInt32(ViewState["Value"].ToString());
            int result = num1 + num2;
            Label1.Text = result.ToString();
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            ViewState.Clear();

        }
    }
}
