using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
public partial class ViewSkill : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SkillLogic sl = new SkillLogic();


        DataTable dt = sl.SelectAll();
        Repeater1.DataSource = dt;
        Repeater1.DataBind();


    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);
        SkillLogic sl = new SkillLogic();
        Skill s = sl.SelectByID(id);
        lblskillname.Text = s.Name;
        lblskilldesc.Text = s.Description;
        lblskilltype.Text = s.Type;
        lblskilltime.Text = s.UploadTime.ToString();
        lblskillusername.Text = s.AppUserID.ToString();
        lblskillstatus.Text = s.IsActive.ToString();
    }
}