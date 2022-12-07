using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DTO
{
   public class User
    {
        private int id;
        private string username;
        private string password;
        private int type;

        public User(int id, string username, string password, int type)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Type = type;
        }
        public User(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
            this.Type = (int)row["type"];
        }
        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
