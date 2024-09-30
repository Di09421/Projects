using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Security_Demo.user
{
    public partial class user_abt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
                Label1.Text = Session["unm"].ToString();
           
    }
}
