using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Security_Demo.user
{
    public partial class user_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["unm"]!=null)
            {
                Label1.Text = Session["unm"].ToString();
                Session.Timeout = 1;

            }
            else
            {
                Response.Redirect("~/login1.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/user/user_abt.aspx");
        }
    }
}