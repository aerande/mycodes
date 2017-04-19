using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

public partial class AddDeal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        DealLogic dl = new DealLogic();
        Deal d = new Deal();
        d.Title = txtdealtitle.Text;
        d.Description = txtdealdesc.Text;

        if (photoupload.HasFile)
        {
            string rpath = "dealspic/" + DateTime.Now.Ticks.ToString() + "_" + photoupload.FileName;
            photoupload.SaveAs(Server.MapPath(rpath));
            d.PhotoPath = rpath;
        }
        else
        {
            d.PhotoPath = "";
        }

        dl.Insert(d);

        Response.Redirect("Deals.aspx");
    }
}