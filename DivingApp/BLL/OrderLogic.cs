using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class OrderLogic : ILogic<Order>
    {
        public int Insert(Order obj)
        {
            string query = "INSERT into Order(AccessoryID, OrderTime, OrderAmount, AppUserID, Status, PaymentMode, TentativeDate) VALUES(@AccessoryID, @OrderTime, @OrderAmount, @AppUserID, @Status, @PaymentMode, @TentativeDate)";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@AccessoryID", obj.AccessoryID));
            param.Add(new SqlParameter("@OrderTime", obj.OrderTime));
            param.Add(new SqlParameter("@OrderAmount", obj.OrderAmount));
            param.Add(new SqlParameter("@RegUserID", obj.AppUserID));
            param.Add(new SqlParameter("@Status", obj.Status));
            param.Add(new SqlParameter("@PaymentMode", obj.PaymentMode)); 
            param.Add(new SqlParameter("@TentativeDate", obj.TentativeDate));

            return DataAccess.ModifyData(query, param);
        }

        public int Update(Order obj)
        {
            string query = "update Order set AccessoryID = @AccessoryID, OrderTime = @OrderTime, OrderAmount = @OrderAmount, AppUserID = @AppUserID, Status= @Status,  PaymentMode = @PaymentMode, TentativeDate = @TentativeDate where OrderID = @OrderID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@AccessoryID", obj.AccessoryID));
            param.Add(new SqlParameter("@OrderTime", obj.OrderTime));
            param.Add(new SqlParameter("@OrderAmount", obj.OrderAmount));
            param.Add(new SqlParameter("@AppUserID", obj.AppUserID));
            param.Add(new SqlParameter("@Status", obj.Status));
            param.Add(new SqlParameter("@PaymentMode", obj.PaymentMode));
            param.Add(new SqlParameter("@TentativeDate", obj.TentativeDate));
            param.Add(new SqlParameter("@OrderID", obj.OrderID));

            return DataAccess.ModifyData(query, param);
        }

        public int Delete(int ID)
        {
            string query = "delete Order where OrderID = @OrderID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@OrderID", ID));

            return DataAccess.ModifyData(query, param);
        }

        public Order SelectByID(int ID)
        {
            string query = "select * from Order where OrderID = @OrderID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@OrderID", ID));

            DataTable dt = DataAccess.SelectData(query, param);
            Order obj = new Order();

            if (dt.Rows.Count == 1)
            {
                obj.AccessoryID = Convert.ToInt32(dt.Rows[0]["AccessoryID"].ToString());
                obj.OrderTime= Convert.ToDateTime(dt.Rows[0]["OrderTime"].ToString());
                obj.OrderAmount = Convert.ToInt32(dt.Rows[0]["OrderAmount"].ToString());
                obj.AppUserID = Convert.ToInt32(dt.Rows[0]["AppUserID"].ToString());
                obj.Status = dt.Rows[0]["Status"].ToString();
                obj.PaymentMode = dt.Rows[0]["PaymentMode"].ToString();
                obj.TentativeDate = Convert.ToDateTime(dt.Rows[0]["TentativeDate"]);
                obj.OrderID= Convert.ToInt32(dt.Rows[0]["OrderID"].ToString());
            }
            return obj;
        }

        public DataTable SelectAll()
        {
            return DataAccess.SelectData("select * from Order", new List<SqlParameter>());
        }

        
    }
}
