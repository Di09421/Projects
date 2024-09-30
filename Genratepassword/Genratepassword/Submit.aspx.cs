using System;
using System.Web.UI;

namespace Genratepassword
{
    public partial class Submit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "thanku for registration" + Request["nm"];

            TextBox1.Text = Request["em"];
            TextBox2.Text = Request["pass"];
        }
    }
}
