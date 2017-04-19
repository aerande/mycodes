using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

public partial class ViewResume : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ResumeLogic Rsl = new ResumeLogic();
        DataTable dt = Rsl.SelectAll();
        Repeater1.DataSource = dt;
        Repeater1.DataBind();
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);
        ResumeLogic Rsl = new ResumeLogic();
        Resume s = Rsl.SelectByID(id);
        lblresumename.Text = s.Name;
        lblResumeQualification.Text = s.Qualification;
        lblResumeExperience.Text = s.Experience;
        lblResumeCertificateCourses.Text = s.CertificateCourses;
        lblResumeDivingSpot.Text = s.LatestDivingSpot;
        lblSpotsVisited.Text = s.DivingSpotsVisited;
        

    }
}