using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                int to = Convert.ToInt32(TextBox2.Text) + 2000;
                Label1.Text = TextBox1.Text + "total sal is " + to + " with Bonus..";
            }
            else if (RadioButton2.Checked)
            {
                int to = Convert.ToInt32(TextBox2.Text) + 3000;
                Label1.Text = TextBox1.Text + "total sal is " + to + " with TA..";
            }
            else
            {
                int to = Convert.ToInt32(TextBox2.Text) + 4000;
                Label1.Text = TextBox1.Text + "total sal is " + to + " with DA..";
            }
        }
    }
}