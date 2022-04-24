using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Xuhuan0727SkySharkWebApplication.BM
{
    public partial class FreqFI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                String ConnectionString = ConfigurationManager.ConnectionStrings["ARPDatabaseConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                string insertSql = "INSERT INTO dtFrequentFliers Select EMail, Discount=@Discount from dtPassengerDetails where TotalTimesFlown>=@TotalTimesFlown";
                SqlCommand cmd = new SqlCommand(insertSql, conn);
                cmd.Parameters.AddWithValue(" @Discount", lstDisc1.SelectedItem.Text.Trim());
                cmd.Parameters.AddWithValue("@TotalTimesFlown", listTimeFlown.SelectedItem.Text.Trim());
                int n = cmd.ExecuteNonQuery();
                conn.Close();
                lblMessage.Text = "Record Added";
                conn.Open();
                String selectSql = "select * from dtFrequentFliers";
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd2 = new SqlCommand(selectSql, conn);
                adapter.SelectCommand = cmd2;
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "FrequentFliers");
                conn.Close();
                DataView source = new DataView(dataset.Tables["FrequentFliers"]);
                GridView1.DataSource = source;
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            if (txtFare.Text == "" || txtFare.Text == null)
            {
                lblMessage.Text = "Invalid Parameter for fare Collected";
                return;
            }
            try
            {
                String ConnectionString = ConfigurationManager.ConnectionStrings["ARPDatabaseConnect ionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                string insertSql = "INSERT INTO dtFrequentFliers Select EMail, Discount=@Discount from dtPassengerDetails where FareCollected>=@FareCollected";
                SqlCommand cmd = new SqlCommand(insertSql, conn);
                cmd.Parameters.AddWithValue("@Discount", lstDisc2.SelectedItem.Text.Trim());
                cmd.Parameters.AddWithValue("@FareCollected", txtFare.Text.Trim());
                int n = cmd.ExecuteNonQuery();
                conn.Close();
                lblMessage.Text = "Record Added.";
                conn.Open();
                String selectSql = "select * from dtFrequentFliers";
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd2 = new SqlCommand(selectSql, conn);
                adapter.SelectCommand = cmd2;
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "FrequentFliers");
                conn.Close();
                DataView source = new DataView(dataset.Tables["FrequentFliers"]);
                GridView1.DataSource = source;
                GridView1.DataBind();
            }
            catch (Exception ex){
                lblMessage.Text = ex.Message;
            }
        }
    }
}