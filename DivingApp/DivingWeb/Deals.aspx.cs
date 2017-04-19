using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

public partial class Deals : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DealLogic dl = new DealLogic();
            DataTable dt = dl.SelectAll();
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);
        DealLogic dl = new DealLogic();
        Deal d = dl.SelectByID(id);
        lbldealtitle.Text = d.Title;
        lbldealdesc.Text = d.Description;
    }

}