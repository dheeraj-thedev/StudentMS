﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteBranch : System.Web.UI.Page
{
    DBhandler db;
    protected void Page_Load(object sender, EventArgs e)
    {
        db = new DBhandler();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        db.deleteBranch(TextBoxBranchName.Text);
        Response.Redirect("Branch.aspx");
    }
}