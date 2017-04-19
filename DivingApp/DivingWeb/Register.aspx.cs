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

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        AppUserLogic appl = new AppUserLogic();
        AppUser s = new AppUser();
        s.Name = txtName.Text;
        s.Address = txtAddress.Text;
        s.Phone = Convert.ToInt32(txtPhone.Text);
        s.Email = txtEmail.Text;
        s.City = txtCity.Text;
        s.Country = txtCountry.Text;
        s.RegisteredDate = DateTime.Now;
        s.Username = txtUsername.Text;
        s.Password = txtPassword.Text;


        if (photoupload.HasFile)
        {
            string rpath = "profilepic/" + DateTime.Now.Ticks.ToString() + "_" + photoupload.FileName;//Server.MapPath("images") + "/";
            photoupload.SaveAs(Server.MapPath(rpath));
            s.PhotoPath = rpath;
        }
        else
        {
            s.PhotoPath = "";
        }

        appl.Insert(s);

        Response.Redirect("ViewRegistration.aspx");
    }
}
