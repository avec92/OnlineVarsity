using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using AjaxControlToolkit;


public partial class Description : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!Page.IsPostBack)
        {
            getImage();
        }
        Label2.Text = "You would be able to view final bill on next page before proceeding.";
        //con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Inside.aspx");
    }

    public void getImage()
    {
        string qry = "select image,bname from Data where bid ='" + Request.QueryString["BookId"] + "'";
        cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader(); 
        if (dr.HasRows)
        {
            FormView1.DataSource = dr;
            FormView1.DataBind();
        }
       // con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Choice.aspx");
        //this.ModalPopupExtender1.Show();

    }
    //protected void btnshop1_Click(object sender, EventArgs e)
    //{
    //    addData();
    //    Response.Redirect("Inside.aspx");
    //}
    //protected void btncheckout1_Click(object sender, EventArgs e)
    //{
    //    addData();
    //    Response.Redirect("BillInfo.aspx");
    //}

protected void addData()
{
        string qry1 = "select bid,bname,price from Data where bid = '" + Request.QueryString["BookId"] + "'";
        SqlCommand cmd = new SqlCommand(qry1, con);
        da.SelectCommand = cmd;
        da.Fill(ds);
        SqlCommand cmd1 = new SqlCommand("insert into AddCart values(@BookId,@name,@price,@sid)", con); 

        cmd1.Parameters.AddWithValue("@BookId", Convert.ToInt32(ds.Tables[0].Rows[0][0]));
        cmd1.Parameters.AddWithValue("@name", ds.Tables[0].Rows[0][1].ToString());
        cmd1.Parameters.AddWithValue("@price", Convert.ToDouble(ds.Tables[0].Rows[0][2]));
        cmd1.Parameters.AddWithValue("@sid", Session["userid"].ToString());
        cmd1.ExecuteNonQuery();
        con.Close();
}   
}