using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Checkout : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!Page.IsPostBack)
        {
            BindData();

        }
    }

    protected void BindData()
    {
        cmd = new SqlCommand("select Name,Price from AddCart where sid=" + Session["userid"] + "", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
        con.Close();
    }
    protected void btncontinue_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("Billing.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            string bookname = "";
            bookname = GridView1.Rows[e.RowIndex].Cells[1].Text;
            string qry = "delete from AddCart where Name ='" + bookname + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            BindData();
        }
        catch (Exception ex)
        {
            Response.Write("Error :" + ex.Message);
        }
    }
}