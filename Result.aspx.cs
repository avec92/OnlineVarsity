using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Result : System.Web.UI.Page
{
    double a;
    protected void Page_Load(object sender, EventArgs e)
    {
        a=Convert.ToDouble(Request.QueryString["res"]);
        Label1.Text=a.ToString();
        if(a>=70)
        {
            Label2.Text = "Your score is " + a.ToString() + ". You can avail the 70% discount by clicking on the 'Get the discount' button and buying the book.";
        }
        else
        {
            Label2.Text = "Your score is "+a.ToString()+". Sorry but since you scored less than 70%,you cannot avail the 70% discount.";
            Button2.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("BillInfo.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("BillInfo.aspx?res="+a);
    }
}