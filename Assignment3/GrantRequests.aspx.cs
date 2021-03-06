﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class GrantRequests : System.Web.UI.Page
{
    GrantClass grant = new GrantClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["PersonKey"] != null)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = Table;
                DropDownList1.DataTextField = "GrantTypeName";
                DropDownList1.DataTextField = "GrantTypeKey";
                DropDownList1.DataBind();
                ListItem item = new ListItem("Choose a Grant: ");
                DropDownList1.Items.Insert(0, item);

            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        protected void FillGrid()
        {
        if(!DropDownList1.SelectedItem.Text.Equals("Choose a Grant: "))
        {
            int key = int.Parse(DropDownList1.SelectedValue.ToString());
            DataTable tbl = grant.GetGrants(key);
            GridView1.DataSource = tbl;
            GridView1.DataBind();
        }
       }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGrid();
    }
  }
