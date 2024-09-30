using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
namespace Security_Demo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
            {

                //  FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
                //Response.Redirect("~/admin/admin_home.aspx");

                Session["unm"] = TextBox1.Text;
                

                Response.Redirect("~/user/user_home.aspx");
            }
            else
            {
                Response.Write("invalid user");
            }
        }
    }
}