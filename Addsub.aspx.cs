using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class page_add_branch : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    SqlDataAdapter da;
    String s;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        con.Open();
        fillgrid();
       
        TextBox1.Focus();
    }
    void fillgrid()
    {
        s = "Select * from Addsubject";
        DataSet ds = new DataSet();
        cmd = new SqlCommand(s, con);
        da = new SqlDataAdapter(cmd);
        da.Fill(ds);

        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        s = "insert into Addsubject values('" + TextBox1.Text + "')";
       
        fillgrid();
        cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = "";
        TextBox1.Focus();
    }
}
