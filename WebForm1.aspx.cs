﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Session
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Session["hai"] = TextBox1.Text;
            Session["hlo"] = TextBox2.Text;
            Response.Redirect("WebForm2.aspx");

        }
    }
}