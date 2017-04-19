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
public partial class NewSkill : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        SkillLogic sl = new SkillLogic();
        Skill s = new Skill();
        s.Name = txtName.Text;
        s.Description = txtDesc.Text;
        s.Type = ddlType.SelectedItem.Text;
        s.IsActive = true;
        s.PhotoPath = "";
        s.UploadTime = DateTime.Now;
        s.AppUserID = 0;


        sl.Insert(s);


        //String q = "insert into Skill(Name, Type, Description, UploadTime) values(@Name, @Type, @Description,  @UploadTime)";
        //List<SqlParameter> lst = new List<SqlParameter>();
        //lst.Add(new SqlParameter("@Name", txtName.Text));
        //lst.Add(new SqlParameter("@Description", txtDesc.Text));
        //lst.Add(new SqlParameter("@Type", ddlType.SelectedItem.Text));
    
        //lst.Add(new SqlParameter("@UploadTime", DateTime.Now));


        //DataAccess.ModifyData(q, lst);

        Response.Redirect("ViewSkill.aspx");
    }
}