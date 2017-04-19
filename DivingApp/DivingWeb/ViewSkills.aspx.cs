using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using System.Data;
using System.Data.SqlClient;

public partial class ViewSkills : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String q = "select * from Skill";
        List<SqlParameter> lst = new List<SqlParameter>();

        DataTable dt = DataAccess.SelectData(q, lst);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}