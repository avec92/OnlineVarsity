﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using AjaxControlToolkit;

public partial class MyInformation : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Apoorva\\Documents\\OnlineVarsity.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
    }

    private void BindData()
    {
        string qry = "select * from StudentData where sid = '" + Session["userid"] + "'";
        con.Open();
        cmd = new SqlCommand(qry, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataList1.DataSource = ds.Tables[0];
        DataList1.DataBind();
        con.Close();

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string qry2 = "select * from StudentData where sid = '" + Session["userid"] + "'";
        con.Open();
        cmd = new SqlCommand(qry2, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        txtid.Text = ds.Tables[0].Rows[0][0].ToString();
        txtname.Text = ds.Tables[0].Rows[0][1].ToString();
        txtpass.Text = ds.Tables[0].Rows[0][2].ToString();
        txtemail.Text = ds.Tables[0].Rows[0][4].ToString();
        this.ModalPopupExtender1.Show();
    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        con.Open();
        string qry1 = "update StudentData set sname='" + txtname.Text + "',spass='" + txtpass.Text + "',semail='" + txtemail.Text + "' where sid='" + txtid.Text + "'";
        cmd = new SqlCommand(qry1, con);
        int rows = cmd.ExecuteNonQuery();
        con.Close();
        if (rows > 0)
        {
            BindData();
        }

    }
}