using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class AppUserLogic : ILogic<AppUser>
    {
        public int Insert(AppUser obj)
        {
            string query = "INSERT into AppUser(Name, Address, Phone, Email, City, Country, RegisteredDate, Username, Password, PhotoPath) VALUES(@Name, @Address, @Phone, @Email, @City, @Country, @RegisteredDate, @Username, @Password, @PhotoPath)";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Name", obj.Name));
            param.Add(new SqlParameter("@Address", obj.Address));
            param.Add(new SqlParameter("@Phone", obj.Phone));
            param.Add(new SqlParameter("@Email", obj.Email));
            param.Add(new SqlParameter("@City", obj.City));
            param.Add(new SqlParameter("@Country", obj.Country));
            param.Add(new SqlParameter("@RegisteredDate", obj.RegisteredDate));
            param.Add(new SqlParameter("@Username", obj.Username));
            param.Add(new SqlParameter("@Password", obj.Password));
            param.Add(new SqlParameter("@PhotoPath", obj.PhotoPath));
           
            return DataAccess.ModifyData(query, param);
        }

        public int Update(AppUser obj)
        {
            string query = "update AppUser set Name = @Name, Address = @Address, Phone = @Phone, Email = @Email, City = @City, Country = @Country, RegisteredDate = @RegisteredDate, Username = @Username, Password = @Password, PhotoPath = @PhotoPath where AppUserID = @AppUserID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@Name", obj.Name));
            param.Add(new SqlParameter("@Address", obj.Address));
            param.Add(new SqlParameter("@Phone", obj.Phone));
            param.Add(new SqlParameter("@Email", obj.Email));
            param.Add(new SqlParameter("@City", obj.City));
            param.Add(new SqlParameter("@Country", obj.Country));
            param.Add(new SqlParameter("@RegisteredDate", obj.RegisteredDate));
            param.Add(new SqlParameter("@Username", obj.Username));
            param.Add(new SqlParameter("@Password", obj.Password));
            param.Add(new SqlParameter("@PhotoPath", obj.PhotoPath));
            param.Add(new SqlParameter("@AppUserID", obj.AppUserID));
            
            return DataAccess.ModifyData(query, param);
        }

        public int Delete(int ID)
        {
            string query = "delete AppUser where AppUserID = @AppUserID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@AppUserID", ID));

            return DataAccess.ModifyData(query, param);
        }

        public AppUser SelectByID(int ID)
        {
            string query = "select * from AppUser where AppUserID = @AppUserID";

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@AppUserID", ID));

            DataTable dt = DataAccess.SelectData(query, param);
            AppUser obj = new AppUser();

            if (dt.Rows.Count == 1)
            {
                obj.Name = dt.Rows[0]["Name"].ToString();
                obj.Address = dt.Rows[0]["Address"].ToString();
                obj.Phone = Convert.ToInt32(dt.Rows[0]["Phone"].ToString());
                obj.Email = dt.Rows[0]["Email"].ToString();
                obj.City = dt.Rows[0]["City"].ToString();
                obj.Country = dt.Rows[0]["Country"].ToString();
                obj.RegisteredDate = Convert.ToDateTime(dt.Rows[0]["RegisteredDate"]);
                obj.Username = dt.Rows[0]["Username"].ToString();
                obj.Password= dt.Rows[0]["Password"].ToString();
                obj.PhotoPath = dt.Rows[0]["PhotoPath"].ToString();
                obj.AppUserID = Convert.ToInt32(dt.Rows[0]["AppUserID"].ToString());
            }
            return obj;
        }

        public DataTable SelectAll()
        {
            return DataAccess.SelectData("select * from AppUser", new List<SqlParameter>());
        }             

        public bool IsValid(string Username, string Password)
        {
            string query = "select * from AppUser where Username = @Username";

            List<SqlParameter> lstparams = new List<SqlParameter>();
            lstparams.Add(new SqlParameter("@Username", Username));

            DataTable dt = DataAccess.SelectData(query, lstparams);

            if (dt.Rows.Count == 1 && dt.Rows[0]["Password"].ToString() == Password)
            {
                return true;
            }
            else
            {
                return false;               
            }

        }

    }
}
