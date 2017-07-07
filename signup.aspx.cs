using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

public partial class signup : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        txtname.Focus();
    }
    protected void Button1_Click(object sender, EventArgs e)
     {
        Byte[] a = null;
        string extension = Path.GetExtension(photo.PostedFile.FileName);
        if (((extension == ".jpg") || ((extension == ".gif") || (extension == ".png"))))
        {
            if (photo.HasFile && photo.PostedFile != null)
            {
                HttpPostedFile file = photo.PostedFile;
                a = new Byte[file.ContentLength];
                file.InputStream.Read(a, 0, file.ContentLength);
            }
        }

        con.Open();
            string qry = "insert into StudentData values('" + txtname.Text + "','" + txtpass.Text + "','" + a + "','" + txtemail.Text + "')";
            cmd = new SqlCommand(qry, con);
            int rows = cmd.ExecuteNonQuery();

            string qry1 = "select max(sid) from StudentData";
            cmd = new SqlCommand(qry1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (rows > 0)
            {
                
                Label1.Text = "Registration done successfully. You can go ahead and log into your account.";
            }
            else
            {
                Label1.Text = "Error adding data.";
            }
            if (dr.HasRows)
            {
                Label2.Text = "Your User ID is :" + dr.GetInt32(0);
            }
            con.Close();
        }

    
    protected void Button2_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtDate.Text = "";
        txtemail.Text = "";
    }
}




