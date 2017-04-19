using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class SkillLogic : ILogic<Skill>
    {
        public int Insert(Skill obj)
        {
            string query = "INSERT into Skill(Name, Description, Type, PhotoPath, UploadTime, AppUserID, IsActive) VALUES(@Name, @Description, @Type, @PhotoPath, @UploadTime, @AppUserID, @IsActive)";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Name", obj.Name));
            param.Add(new SqlParameter("@Description", obj.Description));
            param.Add(new SqlParameter("@Type", obj.Type));
            param.Add(new SqlParameter("@PhotoPath", obj.PhotoPath));
            param.Add(new SqlParameter("@UploadTime", obj.UploadTime));
            param.Add(new SqlParameter("@AppUserID", obj.AppUserID));
            param.Add(new SqlParameter("@IsActive", obj.IsActive));
                        
            return DataAccess.ModifyData(query, param);
        }

        public int Update(Skill obj)
        {
            string query = "update Skill set Name = @Name, Description = @Description, Type = @Type, PhotoPath = @PhotoPath, UploadTime = @UploadTime, AppUserID = @AppUserID, IsActive = @IsActive where SkillID = @SkillID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Name", obj.Name));
            param.Add(new SqlParameter("@Description", obj.Description));
            param.Add(new SqlParameter("@Type", obj.Type));
            param.Add(new SqlParameter("@PhotoPath", obj.PhotoPath));
            param.Add(new SqlParameter("@UploadTime", obj.UploadTime));
            param.Add(new SqlParameter("@AppUserID", obj.AppUserID));
            param.Add(new SqlParameter("@IsActive", obj.IsActive));
            param.Add(new SqlParameter("@SkillID", obj.SkillID));

            return DataAccess.ModifyData(query, param);
        }

        public int Delete(int ID)
        {
            string query = "delete Skill where SkillID = @SkillID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@SkillID", ID));

            return DataAccess.ModifyData(query, param);
        }

        public Skill SelectByID(int ID)
        {
            string query = "select * from Skill where SkillID = @SkillID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@SkillID", ID));

            DataTable dt = DataAccess.SelectData(query, param);
            Skill obj = new Skill();

            if (dt.Rows.Count == 1)
            {
                obj.Name = dt.Rows[0]["Name"].ToString();
                obj.Description = dt.Rows[0]["Description"].ToString();
                obj.Type = dt.Rows[0]["Type"].ToString();
                obj.PhotoPath = dt.Rows[0]["PhotoPath"].ToString();                
                obj.UploadTime = Convert.ToDateTime(dt.Rows[0]["UploadTime"]);
                obj.AppUserID = Convert.ToInt32(dt.Rows[0]["AppUserID"].ToString());
                obj.IsActive = Convert.ToBoolean(dt.Rows[0]["IsActive"].ToString());
                obj.SkillID = Convert.ToInt32(dt.Rows[0]["SkillID"].ToString());
            }
            return obj;
        }

        public DataTable SelectAll()
        {
            return DataAccess.SelectData("select * from Skill", new List<SqlParameter>());
        }

      

    }
}


