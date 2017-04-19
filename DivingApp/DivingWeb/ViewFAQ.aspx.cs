using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

public partial class ViewFAQ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FAQLogic FAQl = new FAQLogic();


        DataTable dt = FAQl.SelectAll();
        Repeater1.DataSource = dt;
        Repeater1.DataBind();

    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);
        FAQLogic FAQl = new FAQLogic();
        FAQ s = FAQl.SelectByID(id);
        lblFAQTitle.Text = s.Title;
        
        lblFAQTime.Text = s.Date.ToString();
        
    }
}