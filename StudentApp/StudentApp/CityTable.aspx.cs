using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentApp
{
    public partial class CityTable : System.Web.UI.Page
    {
        private string cs = "Data Source=HP\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDownList();
                BindGridView();
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string selectedCity = DropDownList1.SelectedValue;
            string selectedState = DropDownList2.SelectedValue;
            string selectedCountry = DropDownList3.SelectedValue;

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BindDropDownList()
        {
            BindDropdown(DropDownList1, "SELECT * FROM CityMaster", "Code", "Name", "--Select City--");
            BindDropdown(DropDownList2, "SELECT * FROM StateMaster", "Code", "Name", "--Select State--");
            BindDropdown(DropDownList3, "SELECT * FROM CountryMaster", "Code", "Name", "--Select Country--");
        }

        private void BindDropdown(DropDownList dropdown, string query, string valueField, string textField, string initialText)
        {
            using (SqlConnection cn = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dropdown.DataSource = ds;
                dropdown.DataValueField = valueField;
                dropdown.DataTextField = textField;
                dropdown.DataBind();
                dropdown.Items.Insert(0, new ListItem(initialText, "0"));
            }
        }
       private void BindGridView()
        {
            using (SqlConnection cn = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT c.Code AS CityCode, c.Name AS CityName, s.Code AS StateCode,s.Name AS StateName, co.Code AS CountryCode,co.Name AS CountryName FROM CityMaster c JOIN StateMaster s ON c.StateCode = s.Code JOIN CountryMaster co ON c.CountryCode = co.Code", cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

    }
}