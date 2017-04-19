using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using System.Data;
using System.Data.SqlClient;
using BLL;

public partial class AddMedicines : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void MediSave_Click(object sender, EventArgs e)
    {
        MedicineLogic ml = new MedicineLogic();
        Medicine m = new Medicine();
        m.Name = txtMediName.Text;
        m.Description = txtMediDesc.Text;
        m.Cost = float.Parse(txtMediCost.Text);
        m.Purpose = txtMediPurpose.Text;

        ml.Insert(m);

        Response.Redirect("ViewMedicines.aspx");
    }
}