using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{

    public class MedicineLogic : ILogic<Medicine>
    {
        public int Insert(Medicine obj)
        {
            string query = "INSERT into Medicine(Name, Description, Cost, Purpose) VALUES(@Name, @Description, @Cost, @Purpose)";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Name", obj.Name));
            param.Add(new SqlParameter("@Description", obj.Description));
            param.Add(new SqlParameter("@Cost", obj.Cost));
            param.Add(new SqlParameter("@Purpose", obj.Purpose));
            
            return DataAccess.ModifyData(query, param);
        }

        public int Update(Medicine obj)
        {
            string query = "update Medicine set Name = @Name, Description = @Description, Cost = @Cost, Purpose = @Purpose where MedicineID = @MedicineID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Name", obj.Name));
            param.Add(new SqlParameter("@Description", obj.Description));
            param.Add(new SqlParameter("@Cost", obj.Cost));
            param.Add(new SqlParameter("@Purpose", obj.Purpose));
            param.Add(new SqlParameter("@MedicineID", obj.MedicineID));

            return DataAccess.ModifyData(query, param);
        }

        public int Delete(int ID)
        {
            string query = "delete Medicine where MedicineID = @MedicineID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@MedicineID", ID));

            return DataAccess.ModifyData(query, param);
        }

        public Medicine SelectByID(int ID)
        {
            string query = "select * from Medicine where MedicineID = @MedicineID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@MedicineID", ID));

            DataTable dt = DataAccess.SelectData(query, param);
            Medicine obj = new Medicine();

            if (dt.Rows.Count == 1)
            {
                obj.Name = dt.Rows[0]["Name"].ToString();
                obj.Description = dt.Rows[0]["Description"].ToString();
                obj.Cost = Convert.ToSingle(dt.Rows[0]["Cost"]);
                obj.Purpose = dt.Rows[0]["Purpose"].ToString();
                obj.MedicineID = Convert.ToInt32(dt.Rows[0]["MedicineID"]);
            }
            return obj;
        }

        public DataTable SelectAll()
        {
            return DataAccess.SelectData("select * from Medicine", new List<SqlParameter>());
        }

       
    }
}
