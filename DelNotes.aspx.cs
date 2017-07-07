using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Data.Sql;
 

public partial class notes : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    SqlDataAdapter da;
    string s;
    int i;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            
            s = "Select distinct Subject from Data";
            DataSet ds = new DataSet();
            cmd = new SqlCommand(s, con);
            da = new SqlDataAdapter(cmd);

            da.Fill(ds);
            
            
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                ddl1.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            ddl1.SelectedIndex = 0;
            
           
        }
    }
   
   
    protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillgrid();
             
    }
  
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Session["subject"] = ddl1.SelectedItem;
       
    }
    protected void l1_click(object sender, CommandEventArgs e)
    {
        string path = e.CommandName.ToString();
        Response.Redirect(path);
    }
    protected void l2_click(object sender, CommandEventArgs e)
    {
        string path = e.CommandName.ToString();
        s = "delete from Data where path='" + path + "'";
        
        fillgrid();
    }


    public void fillgrid()
    {
        
        s = "select bname, Subject,AuthorName,path from Data where Subject='" + ddl1.SelectedItem + "'";

        DataSet ds = new DataSet();
        cmd = new SqlCommand(s, con);
        da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        if (ds.Tables[0].Rows.Count != 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label1.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        else
        {
            Label1.Text = "No data Found";
        }
        
        con.Close();
   
    }
}
