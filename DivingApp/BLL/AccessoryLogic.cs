using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class AccessoryLogic : ILogic<Accessory>
    {
        public int Insert(Accessory obj)
        {
            string query = "INSERT into Accessory(Name, PhotoPath, Description, Cost, MRP, Discount, Category) VALUES(@Name, @PhotoPath, @Description, @Cost, @MRP, @Discount, @Category)";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Name", obj.Name));
            param.Add(new SqlParameter("@PhotoPath", obj.PhotoPath));
            param.Add(new SqlParameter("@Description", obj.Description));            
            param.Add(new SqlParameter("@Cost", obj.Cost));
            param.Add(new SqlParameter("@MRP", obj.MRP));
            param.Add(new SqlParameter("@Discount", obj.Discount));
            param.Add(new SqlParameter("@Category", obj.Category));

            return DataAccess.ModifyData(query, param);
        }

        public int Update(Accessory obj)
        {
            string query = "update Accessory set Name = @Name, PhotoPath = @PhotoPath, Description = @Description, Cost = @Cost, MRP = @MRP, Discount = @Discount, Category = @Category where AccessoryID = @AccessoryID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Name", obj.Name));
            param.Add(new SqlParameter("@PhotoPath", obj.PhotoPath));
            param.Add(new SqlParameter("@Description", obj.Description));            
            param.Add(new SqlParameter("@Cost", obj.Cost));
            param.Add(new SqlParameter("@MRP", obj.MRP));
            param.Add(new SqlParameter("@Discount", obj.Discount));
            param.Add(new SqlParameter("@Category", obj.Category));
            param.Add(new SqlParameter("@AccessoryID", obj.AccessoryID));

            return DataAccess.ModifyData(query, param);
        }

        public int Delete(int ID)
        {
            string query = "delete Accessory where AccessoryID = @AccessoryID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@AccessoryID", ID));

            return DataAccess.ModifyData(query, param);
        }

        public Accessory SelectByID(int ID)
        {
            string query = "select * from Accessory where AccessoryID = @AccessoryID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@AccessoryID", ID));

            DataTable dt = DataAccess.SelectData(query, param);
            Accessory obj = new Accessory();

            if (dt.Rows.Count == 1)
            {
                obj.Name = dt.Rows[0]["Name"].ToString();
                obj.PhotoPath = dt.Rows[0]["PhotoPath"].ToString();
                obj.Description = dt.Rows[0]["Description"].ToString();
                obj.Cost = Convert.ToInt32(dt.Rows[0]["Cost"].ToString());
                obj.MRP = Convert.ToInt32(dt.Rows[0]["MRP"].ToString());
                obj.Discount = Convert.ToInt32(dt.Rows[0]["Discount"].ToString());
                obj.Category = dt.Rows[0]["Category"].ToString();
                obj.AccessoryID = Convert.ToInt32(dt.Rows[0]["AccessoryID"].ToString());
            }
            return obj;
        }

        public DataTable SelectAll()
        {
            return DataAccess.SelectData("select * from Accessory", new List<SqlParameter>());
        }

        //public List<Accessory> SelectAllList()
        //{
        //    DataTable dt = DataAccess.SelectData("select * from Accessory", new List<SqlParameter>());
        //    List<Accessory> lstObj = new List<Accessory>();

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        Accessories obj = new Accessories();
        //        obj.Name = dt.Rows[i]["Name"].ToString();
        //        obj.PhotoPath = dt.Rows[i]["PhotoPath"].ToString();
        //        obj.Description = dt.Rows[i]["Description"].ToString();
        //        obj.Cost = Convert.ToInt32(dt.Rows[i]["Cost"].ToString());
        //        obj.MRP = Convert.ToInt32(dt.Rows[i]["MRP"].ToString());
        //        obj.Discount = Convert.ToInt32(dt.Rows[i]["Discount"].ToString());
        //        obj.Category = dt.Rows[i]["Category"].ToString();
        //        obj.AccessoryID = Convert.ToInt32(dt.Rows[i]["AccessoryID"].ToString());
        //        
        //        
        //        

        //        lstObj.Add(obj);
        //    }

        //    return lstObj;
        //}

    }
}
