using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class DealLogic : ILogic<Deal>
    {
        public int Insert(Deal obj)
        {
            string query = "INSERT into Deal(Title, Description, PhotoPath) VALUES(@Title, @Description, @PhotoPath)";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Title", obj.Title));
            param.Add(new SqlParameter("@Description", obj.Description));
            param.Add(new SqlParameter("@PhotoPath", obj.PhotoPath));

            return DataAccess.ModifyData(query, param);
        }

        public int Update(Deal obj)
        {
            string query = "update Deal set Title = @Title, Description = @Description, PhotoPath = @PhotoPath where DealID = @DealID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Title", obj.Title));
            param.Add(new SqlParameter("@Description", obj.Description));
            param.Add(new SqlParameter("@PhotoPath", obj.PhotoPath));
            param.Add(new SqlParameter("@DealID", obj.DealID));

            return DataAccess.ModifyData(query, param);
        }

        public int Delete(int ID)
        {
            string query = "delete Deal where DealID = @DealID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@DealID", ID));

            return DataAccess.ModifyData(query, param);
        }

        public Deal SelectByID(int ID)
        {
            string query = "select * from Deal where DealID = @DealID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@DealID", ID));

            DataTable dt = DataAccess.SelectData(query, param);
            Deal obj = new Deal();

            if (dt.Rows.Count == 1)
            {
                obj.Title = dt.Rows[0]["Title"].ToString();
                obj.Description = dt.Rows[0]["Description"].ToString();
                obj.PhotoPath = dt.Rows[0]["PhotoPath"].ToString();
                obj.DealID = Convert.ToInt32(dt.Rows[0]["DealID"].ToString());
            }
            return obj;
        }

        public DataTable SelectAll()
        {
            return DataAccess.SelectData("select * from Deal", new List<SqlParameter>());
        }
               
    }
}
