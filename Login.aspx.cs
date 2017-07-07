using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Linq;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    SqlDataAdapter da = new SqlDataAdapter();
    string s;
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
        {
            Response.Redirect("Admin.aspx");
        }
        else
        {
            con.Open();
            string qry = "select sid,spass,sname from StudentData where sid = '" + TextBox1.Text + "'";
            cmd = new SqlCommand(qry, con);
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows[0][0].ToString() == TextBox1.Text && ds.Tables[0].Rows[0][1].ToString() == TextBox2.Text)
            {                
                Session["userid"] = TextBox1.Text.Trim();
                Session["name"] = ds.Tables[0].Rows[0][2];
                Response.Redirect("Inside.aspx");
            }
            else
            {
                Label1.Text = "Enter valid user id or password";
            }
        }
    }
}