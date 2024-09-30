using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication13
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=img;Integrated Security=True");
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from img", cn);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (fileExtension.ToLower() != ".jpg" && fileExtension.ToLower() != "./png")
                {
                    Label1.Text = "only .jpg/.png files are allowed";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int filesize = FileUpload1.PostedFile.ContentLength;
                    if (filesize > 50000)
                    {
                        Label1.Text = "Maximum file size (50kb) exceeded";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {

                        string ServerMapPath = Server.MapPath("~/images/" + FileUpload1.FileName);

                        FileUpload1.PostedFile.SaveAs(ServerMapPath);

                        string path = "~/images/" + FileUpload1.FileName;

                        string q = "insert into img values ('" + TextBox1.Text + "','" + path + "')";

                        SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=img;Integrated Security=True");
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(q, cn);
                        cmd.ExecuteNonQuery();

                        Response.Write("saved successfully.....");

                    }
                }
            }
            else
            {
                Label1.Text = "please select a file to upload";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex =e.NewPageIndex;
            Page_Load(sender, e);
        }
    }
        }
    