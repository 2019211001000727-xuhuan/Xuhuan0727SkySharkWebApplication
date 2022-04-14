using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Xuhuan0727SkySharkWebApplication.NA
{
    public partial class ManageDatabases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnArchive_Click(object sender, EventArgs e)
        {
            try{
                lblMessage.Text = "";
                String ConnectionString = ConfigurationManager.ConnectionStrings["ARPDatabaseConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateResverations", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", DateTime.Today.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                conn.Close();
                lblMessage.Text = "Update Resverations Done!!!";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try{
                lblMessage.Text = "";
                String ConnectionString = ConfigurationManager.ConnectionStrings["ARPDatabaseConectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("FrequentFliers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery ();
                conn.Close ();
                lblMessage.Text = "Update FrequentFlier Done!!!";
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
    }
}