using System;
using System.IO;
using System.Web.UI;

namespace Imageform
{
    public partial class Image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            Label1.Text = name;

       
            if (FileUpload1.HasFile && FileUpload2.HasFile)
            {
             
                string imageFileName = Path.GetFileName(FileUpload1.FileName);
                string signatureFileName = Path.GetFileName(FileUpload2.FileName);
                string imageServerPath = Server.MapPath("~/Images/" + imageFileName);
                string signatureServerPath = Server.MapPath("~/Sign/" + signatureFileName);

           
                FileUpload1.PostedFile.SaveAs(imageServerPath);
                FileUpload2.PostedFile.SaveAs(signatureServerPath);

             
                Image1.ImageUrl = "~/Images/" + imageFileName;
                Image2.ImageUrl = "~/Sign/" + signatureFileName;

                Label2.Text = "Image uploaded successfully.";
                Label3.Text = "Signature uploaded successfully.";
            }
            else
            {
                if (!FileUpload1.HasFile)
                {
                    Label2.Text = "No image selected.";
                }
                if (!FileUpload2.HasFile)
                {
                    Label3.Text = "No signature selected.";
                }
            }
        }
    }
}