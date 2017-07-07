using System;
//using System.Linq;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class AddNotes : System.Web.UI.Page
{
    string s;
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    SqlDataAdapter da;
    int i;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {            
            
            s = "Select distinct subname from Addsubject";
            DataSet ds = new DataSet();
            cmd = new SqlCommand(s, con);
            da = new SqlDataAdapter(cmd);
                      
            da.Fill(ds);
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                ddl2.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            ddl2.SelectedIndex = 0;   
        }
        con.Close();
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

        if (fp1.HasFile)
        {
            string path = "~/Notes/" + fp1.FileName;

            s = "insert into Data values('" + TextBox1.Text + "','" + ddl2.SelectedItem + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + path + "','" + TextBox4.Text + "','" + extension + "')";

            fp1.SaveAs(Server.MapPath("~\\Notes\\" + fp1.FileName));



            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ddl2.SelectedIndex = 0;
            Label1.Text = "Your file has been uploaded.";
        }
        else
        {
            Label1.Text = "Please select the file in Browse Option";
        }

    }
}
