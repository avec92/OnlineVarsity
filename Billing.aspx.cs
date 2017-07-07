using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Billing : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
       
        Label1.Text = "Your Order has been Successfully Submitted. The books will be delivered at your location within 4-5 Business Days.";
        string qry = "delete from AddCart where sid = '" + Session["user"] + "'";
        con.Open();
        cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}