using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;


public partial class view : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    SqlDataAdapter da = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con.Open();
          string qry = "select bid as 'Book Id', bname as 'Name', Subject, AuthorName as 'Author' from Data where qty > 0";
           // string qry = "select bid,bname,Subject,AuthorName,qty from Data where qty>0";
            cmd = new SqlCommand(qry, con);
            
            grid();
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //cmd.ExecuteNonQuery();
            //GridView1.DataSource = ds;
            //GridView1.DataBind();
            cmd.ExecuteNonQuery();
            
        }

    }
    public void grid()
    {
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);

        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string qry1 = "select bid as 'Book Id', bname as 'Name', Subject, AuthorName as 'Author' from Data where bname like '%" + txtsearch.Text + "%' ";
        cmd = new SqlCommand(qry1, con);
        grid();
        //DataSet ds = new DataSet();
        //da.Fill(ds);
        cmd.ExecuteNonQuery();
        //GridView1.DataSource = ds;
        //GridView1.DataBind();
        
    }



    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        string qry = "select bid as 'Book Id', bname as 'Name', Subject, AuthorName as 'Author' from Data where qty>0";
        cmd = new SqlCommand(qry, con);
        grid();
        //DataSet ds = new DataSet();
        //da.Fill(ds);
        //cmd.ExecuteNonQuery();
        //GridView1.DataSource = ds;
        //GridView1.DataBind();
        
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
}