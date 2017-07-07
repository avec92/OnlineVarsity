using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test : System.Web.UI.Page
{
    double total, count;
    protected void Page_Load(object sender, EventArgs e)
    {
        ques(1);
    }
    void ques(int i)
    {
        if(i==1)
        {
            Label1.Text = "Which of these technologies/API's are officially a part of HTML5?";
            RadioButtonList1.Items[0].Text = "Web SQL";
            RadioButtonList1.Items[1].Text = "Microdata";
            RadioButtonList1.Items[2].Text = "SVG";
            RadioButtonList1.Items[3].Text = "Silverlite";

            Label2.Text = "Full form of HTML is";
            RadioButtonList2.Items[0].Text = "Hyper Text Makeup Language";
            RadioButtonList2.Items[1].Text = "HyperText Markup Language";
            RadioButtonList2.Items[2].Text = "HelloText Markup Language";
            RadioButtonList2.Items[3].Text = "HyperTurf Markup Language";

            Label3.Text = "Which of these element is not supported under HTML5?";
            RadioButtonList3.Items[0].Text = "blockquote";
            RadioButtonList3.Items[1].Text = "table";
            RadioButtonList3.Items[2].Text = "cite";
            RadioButtonList3.Items[3].Text = "center";

            Label4.Text = "Which of these is not valid HTML5 section element?";
            RadioButtonList4.Items[0].Text = "header";
            RadioButtonList4.Items[1].Text = "aside";
            RadioButtonList4.Items[2].Text = "nav";
            RadioButtonList4.Items[3].Text = "body";

            Label5.Text = "Which of these is not valid input type in HTML5?";
            RadioButtonList5.Items[0].Text = "telephone";
            RadioButtonList5.Items[1].Text = "week ";
            RadioButtonList5.Items[2].Text = "datetime-local";
            RadioButtonList5.Items[3].Text = "color";

            Label6.Text = "Which of the following is not media element?";
            RadioButtonList6.Items[0].Text = "readyToPlay";
            RadioButtonList6.Items[1].Text = "embed";
            RadioButtonList6.Items[2].Text = "track";
            RadioButtonList6.Items[3].Text = "video";

            Label7.Text = "Can we have two body tags in same HTML5 file?";
            RadioButtonList7.Items[0].Text = "Yes";
            RadioButtonList7.Items[1].Text = "No";
            RadioButtonList7.Items[2].Text = "Maybe";
            RadioButtonList7.Items[3].Text = "Sometimes";

            Label8.Text = "Can we embed one <html> tag in body of another one in same file?";
            RadioButtonList8.Items[0].Text = "Yes";
            RadioButtonList8.Items[1].Text = "No";
            RadioButtonList8.Items[2].Text = "Maybe";
            RadioButtonList8.Items[3].Text = "Sometimes";

            Label9.Text = "Data list is used with...";
            RadioButtonList9.Items[0].Text = "List elements";
            RadioButtonList9.Items[1].Text = "Output elements";
            RadioButtonList9.Items[2].Text = "Input elements";
            RadioButtonList9.Items[3].Text = "None";

            Label10.Text = "In <bdi>, dbi stands for....";
            RadioButtonList10.Items[0].Text = "Bi-directional Isolation";
            RadioButtonList10.Items[1].Text = "Bi-detection Indexing";
            RadioButtonList10.Items[2].Text = "Bi-directional Indexing";
            RadioButtonList10.Items[3].Text = "None";

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        calc();
        Response.Redirect("Result.aspx?res="+total);

    }
    protected void Timer1_Tick1(object sender, EventArgs e)
    {
                    
            TimeSpan time1 = new TimeSpan();
            time1 = (DateTime)Session["time"] - DateTime.Now;
            if (time1.Hours <= 0)
            {
                Response.Write("<script>alert('Time Over')</script>");
                Label11.Text = "TimeOut!";
                //string[] cmdStr = new string[1];
                //cmdStr[0] = "update UserMaster set ExamStatus='True' where UserId=" + HttpContext.Current.Session["UserId"].ToString() + "";
                //bool status = cscomm.ExecuteCommands(Cmd, cmdStr, conn);
                //Session.Abandon();
                calc();
                Response.Redirect("Result.aspx?res=" + total);
            }
            else
            {
                Label11.Text = "Time Left : " + time1.Hours.ToString() + " : " + time1.Minutes.ToString() + " : " + time1.Seconds.ToString();
                
            }
        

    }
     public double calc()
    {
        count = 0;
        
        if (RadioButtonList1.SelectedIndex == 1)
        {
            count++;
        }
        if (RadioButtonList2.SelectedIndex == 1)
        {
            count++;
        }
        if (RadioButtonList3.SelectedIndex == 0)
        {
            count++;

        }
        if (RadioButtonList4.SelectedIndex == 3)
        {
            count++;
        }
        if (RadioButtonList5.SelectedIndex == 0)
        {
            count++;
        }
        if (RadioButtonList6.SelectedIndex == 0)
        {
            count++;
        }
        if (RadioButtonList7.SelectedIndex == 0)
        {
            count++;
        }
        if (RadioButtonList8.SelectedIndex == 0)
        {
            count++;
        }
        if (RadioButtonList9.SelectedIndex == 2)
        {
            count++;
        }
        if (RadioButtonList10.SelectedIndex == 2)
        {
            count++;
        }
        total = count * 10;
        return total;
     }

     
}