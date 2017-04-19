using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
   public class ResumeLogic : ILogic<Resume>
    {
        public int Insert(Resume obj)
        {
            string query = "INSERT into Resume(Name, Experience, Qualification, CertificateCourses, LatestDivingSpot, DivingSpotsVisited ) VALUES(@Name, @Experience, @Qualification, @CertificateCourses, @LatestDivingSpot, @DivingSpotsVisited)";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Name", obj.Name));
            param.Add(new SqlParameter("@Experience", obj.Experience));
            param.Add(new SqlParameter("@Qualification", obj.Qualification));
            param.Add(new SqlParameter("@CertificateCourses", obj.CertificateCourses));
            param.Add(new SqlParameter("@LatestDivingSpot", obj.LatestDivingSpot));
            param.Add(new SqlParameter("@DivingSpotsVisited", obj.DivingSpotsVisited));
            return DataAccess.ModifyData(query, param);
        }

        public int Update(Resume obj)
        {
            string query = "update Resume set Name = @Name, Experience = @Expereince, Qualification = @Qualification, CertificateCourses = @CertificateCourses, LatestDivingSpot = @LatestDivingSpot, DivingSpotsVisited = @DivingSpotsVisited where ResumeID = @ResumeID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Name", obj.Name));
            param.Add(new SqlParameter("@Experience", obj.Experience));
            param.Add(new SqlParameter("@Qualification", obj.Qualification));
            param.Add(new SqlParameter("@CertificateCourses", obj.CertificateCourses));
            param.Add(new SqlParameter("@LatestDivingSpot", obj.LatestDivingSpot));
            param.Add(new SqlParameter("@DivingSpotsVisited", obj.DivingSpotsVisited));
            param.Add(new SqlParameter("@ResumeID", obj.ResumeID));

            return DataAccess.ModifyData(query, param);
        }

        public int Delete(int ID)
        {
            string query = "delete Resume where ResumeID = @ResumeID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@ResumeID", ID));

            return DataAccess.ModifyData(query, param);
        }

        public Resume SelectByID(int ID)
        {
            string query = "select * from Resume where ResumeID = @ResumeID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@ResumeID", ID));

            DataTable dt = DataAccess.SelectData(query, param);
            Resume obj = new Resume();

            if (dt.Rows.Count == 1)
            {
                obj.Name = dt.Rows[0]["Name"].ToString();
                obj.Experience = dt.Rows[0]["Experience"].ToString();
                obj.Qualification = dt.Rows[0]["Qualification"].ToString();
                obj.CertificateCourses = dt.Rows[0]["CertificateCourses"].ToString();
                obj.LatestDivingSpot = dt.Rows[0]["LatestDivingSpot"].ToString();
                obj.DivingSpotsVisited = dt.Rows[0]["DivingSpotsVisited"].ToString();
                obj.ResumeID = Convert.ToInt32(dt.Rows[0]["ResumeID"].ToString());
            }
            return obj;
        }

        public DataTable SelectAll()
        {
            return DataAccess.SelectData("select * from Resume", new List<SqlParameter>());
        }

        //public List<FAQ> SelectAllList()
        //{
        //    DataTable dt = DataAccess.SelectData("select * from FAQ", new List<SqlParameter>());
        //    List<FAQ> lstObj = new List<FAQ>();

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        FAQ obj = new FAQ();
        //        obj.Title = dt.Rows[i]["Title"].ToString();
        //        obj.Date = Convert.ToDateTime(dt.Rows[i]["Date"]);
        //        obj.FAQID = Convert.ToInt32(dt.Rows[i]["FAQID"]);

        //        lstObj.Add(obj);
        //    }

        //    return lstObj;
        //}

    }
}
