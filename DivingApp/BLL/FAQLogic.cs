using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class FAQLogic : ILogic<FAQ>
    {
        public int Insert(FAQ obj)
        {
            string query = "INSERT into FAQ(Title, Date) VALUES(@Title, @Date)";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Title", obj.Title));
            param.Add(new SqlParameter("@Date", obj.Date));
            
            return DataAccess.ModifyData(query, param);
        }

        public int Update(FAQ obj)
        {
            string query = "update FAQ set Title = @Title, Date = @Date where FAQID = @FAQID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Title", obj.Title));
            param.Add(new SqlParameter("@Date", obj.Date));
            param.Add(new SqlParameter("@FAQID", obj.FAQID));
            
            return DataAccess.ModifyData(query, param);
        }

        public int Delete(int ID)
        {
            string query = "delete FAQ where FAQID = @FAQID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@FAQID", ID));

            return DataAccess.ModifyData(query, param);
        }

        public FAQ SelectByID(int ID)
        {
            string query = "select * from FAQ where FAQID = @FAQID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@FAQID", ID));

            DataTable dt = DataAccess.SelectData(query, param);
            FAQ obj = new FAQ();

            if (dt.Rows.Count == 1)
            {
                obj.Title = dt.Rows[0]["Title"].ToString();
                obj.Date = Convert.ToDateTime(dt.Rows[0]["Date"]);
                obj.FAQID = Convert.ToInt32(dt.Rows[0]["FAQID"].ToString());
            }
            return obj;
        }

        public DataTable SelectAll()
        {
            return DataAccess.SelectData("select * from FAQ", new List<SqlParameter>());
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
