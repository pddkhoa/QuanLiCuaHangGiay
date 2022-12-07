using QuanLiBanGiay.DTO;
using QuanLyCuaHangGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
   public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            set { UserDAO.instance = value; }
        }
        private UserDAO() { }
        public bool Login(string username, string password)
        {
            string query = string.Format("SELECT * FROM USER_LOGIN WHERE USERNAME = N'{0}' AND PASSWORD = N'{1}'",username,password);
            DataProvider provider = new DataProvider();
            DataTable result = provider.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public List<User> GetListUserByUsernameAndPassword(string username, string password)
        {
            List<User> list = new List<User>();
            string query = string.Format("SELECT * FROM USER_LOGIN WHERE USERNAME = N'{0}' AND PASSWORD = N'{1}'", username, password);
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                User user = new User(item);
                list.Add(user);
            }
            return list;
        }
        public bool UpdateUser(int id, string userName, string passWord, int type)
        {
            string query = string.Format("UPDATE USER_LOGIN SET USER_LOGIN.USERNAME = N'{0}', USER_LOGIN.PASSWORD = N'{1}', USER_LOGIN.TYPE = {2} WHERE USER_LOGIN.ID = {3}; ",userName,passWord,type, id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteUser(int id)
        {
      
            string query = string.Format("Delete USER_LOGIN where id = {0};", id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool InsertUser( string userName, string passWord, int type)
        {
            string query = string.Format("INSERT INTO USER_LOGIN(USER_LOGIN.USERNAME, USER_LOGIN.PASSWORD, USER_LOGIN.TYPE) VALUES ( N'{0}',N'{1}',{2});", userName, passWord, type);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<User> GetListUser()
        {
            List<User> list = new List<User>();
            string query = "Select * from USER_LOGIN";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                User u = new User(item);
                list.Add(u);
            }
            return list;
        }
    }
}
