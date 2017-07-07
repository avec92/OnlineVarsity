using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class AspList : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            
                Bind();
            
            
        }


    }
    //public void BindData()
    //{
    //    DataSet ds = new DataSet();
    //    con.Open();
    //    string qry = "select bname,AuthorName,price,image,bid from Data where Subject ='Asp.net'";
    //    cmd = new SqlCommand(qry, con);
    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
    //    da.Fill(ds);
    //    DataList1.DataSource = ds.Tables[0];
    //    DataList1.DataBind();
    //    con.Close();

    //}

    protected void Bind()
    {
        DataSet ds = new DataSet();
        con.Open();
        string qry = "select bname,AuthorName,price,qty,image,bid from Data where Subject ='Asp.net'";
        cmd = new SqlCommand(qry, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        DataList1.DataSource = ds.Tables[0];
        DataList1.DataBind();
        con.Close();

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "ID")
        {
            Response.Redirect("Addtocart.aspx?BookId=" + e.CommandArgument.ToString());
        }
    }
}