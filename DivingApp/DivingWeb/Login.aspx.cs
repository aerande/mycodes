using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Username"] = null;
    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {
        AppUserLogic al = new AppUserLogic();

        if (txtusername.Text == "" && txtpassword.Text == "")
        {
            lblerror.Text = "Please Enter Username and Password";
        }

        else if (txtusername.Text != "" && txtpassword.Text == "")
        {
            lblerror.Text = "Please Enter Password";
        }

        else if (txtusername.Text == "" && txtpassword.Text != "")
        {
            lblerror.Text = "Please Enter Username";
        }

        else if (al.IsValid(txtusername.Text, txtpassword.Text))
        {
            Session["Username"] = txtusername.Text;

            Response.Redirect("Home.aspx");
        }
        else
        {
            lblerror.Text = "Username and Password not matching";
        }


    }
}