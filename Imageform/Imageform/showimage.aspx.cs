using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace Imageform
{
    public partial class showimage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {

                string FileName = Path.GetFileName(FileUpload1.FileName);
                string path = Path.Combine(Server.MapPath("~/img" +FileUpload1.FileName));
                FileUpload1.SaveAs(path);
                string p = "~/img/" + FileUpload1.FileName;

                Image1.ImageUrl = path;

                Label1.Text = TextBox1.Text;

            }



        }
    }
}