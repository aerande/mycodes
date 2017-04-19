using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

public partial class ViewRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AppUserLogic appl = new AppUserLogic();
        DataTable dt = appl.SelectAll();
        Repeater1.DataSource = dt;
        Repeater1.DataBind();

    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);
        AppUserLogic appl = new AppUserLogic();
        AppUser s = appl.SelectByID(id);
        lblRegName.Text = s.Name;
        lblRegAddress.Text = s.Address;
        lblRegCity.Text = s.City;
        lblRegCountry.Text = s.Country;
        lblRegEmail.Text = s.Email;
        lblRegPhone.Text = s.Phone.ToString();
        lblRegUsername.Text = s.Username;
        //lblRegPass.Text = s.Password;
        Image1.ImageUrl = s.PhotoPath;
        

    }
}