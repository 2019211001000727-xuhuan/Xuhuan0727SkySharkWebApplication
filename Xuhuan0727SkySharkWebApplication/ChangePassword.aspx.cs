using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Xuhuan0727SkySharkWebApplication
{
    public partial class Change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["usrRole"] == null)
            {
                Response.Redirect(".\\default.aspx");
            }
            if(!(Session["usrRole"].ToString() == "Admin"))
            {
                Response.Redirect(".\\default.aspx");
            }
            else
            {
                Label1.Text = "Changing password for "+Session["username"].ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                String ConnectionString = ConfigurationManager.ConnectionStrings["ARPDatabaseConectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                string updateSql = "UPDATE dtUsers SET Password = @Password, passwordChanged = '1' WHERE (Username = @original_username)";
                SqlCommand cmd = new SqlCommand("FrequentFliers", conn);
                cmd.Parameters.AddWithValue("@Password",txtPassword.Text);
                cmd.Parameters.AddWithValue("@original_username", Session["usrName"]);
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("~/NA/ManageUsers.aspx");
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}