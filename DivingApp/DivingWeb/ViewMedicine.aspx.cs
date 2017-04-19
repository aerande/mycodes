using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

public partial class ViewMedicine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MedicineLogic ml = new MedicineLogic();
        DataTable dt = ml.SelectAll();
        Repeater1.DataSource = dt;
        Repeater1.DataBind();
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);
        MedicineLogic ml = new MedicineLogic();
        Medicine m = ml.SelectByID(id);
        lblmediname.Text = m.Name;
        lblmedidesc.Text = m.Description;
        lblmedicost.Text = m.Cost.ToString();
        lblmedipurpose.Text = m.Purpose;
    }
}