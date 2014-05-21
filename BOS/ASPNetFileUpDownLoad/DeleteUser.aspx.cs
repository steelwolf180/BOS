﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNetFileUpDownLoad.Utilities;
using System.Data;

namespace ASPNetFileUpDownLoad
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable UserList = FileUtilities.GetUser();
            DGV.DataSource = UserList;
            DGV.DataBind();
        }

        protected void BtnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void BtnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Int16 id = 0;

            try
            {
                if (txtMemberID.Text.Length == 0 || txtMemberID.Text == "" || txtMemberID.Text == " " || txtMemberID.Text == null )
                {
                    lblError.Text = "Please re-enter the member ID again!!!";
                }
                else
                {
                    id = Int16.Parse(txtMemberID.Text);

                    if (id<0)
                    {
                        lblError.Text = "Please re-enter the member ID again!!!";
                    }
                    else
                    {
                        FileUtilities.DeleteUser(id);
                        DataTable UserList = FileUtilities.GetUser();
                        DGV.DataSource = UserList;
                        DGV.DataBind();
                        lblError.Text = "Member ID Deleted Successfully!!!";
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message.ToString();
            }
        }
    }
}