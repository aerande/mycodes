using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] != null && Session["Username"].ToString().ToUpper() == "ADMIN")
        {
            liAdminMenu.Visible = true;
            LinkButton1.Visible = true;
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["Username"] = "";
        Response.Redirect("Home.aspx");
    }
}
