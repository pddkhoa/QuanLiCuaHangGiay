using QuanLiBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
    public class BangSizeDAO
    {
        private static BangSizeDAO instance;
       
        public static BangSizeDAO Instance
        {
            get { if (instance == null)instance = new BangSizeDAO(); return BangSizeDAO.instance; }
            set { BangSizeDAO.instance = value; }
        }
        private BangSizeDAO()
        { }


        public List<BangSize> GetListBangSize()
        {
            List<BangSize> list = new List<BangSize>();
            string query = "Select * From Bang_Size";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                BangSize bangSize = new BangSize(item);
                list.Add(bangSize);
            }    
            return list;
        }
        public BangSize GetBangSizeByID(int id)
        {
            BangSize bangsize = null;
            string query = String.Format("Select * From Bang_Size where id={0}",id);
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                bangsize = new BangSize(item);
                return bangsize;
            }
            return bangsize;
        }
        public bool InsertBangSize(int tensize)
        {
            string query = string.Format("INSERT into BANG_SIZE(tensize) VALUES({0}); ",tensize);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateBangSize(int tensize,int id)
        {
            string query = string.Format("Update Bang_Size Set TENSIZE = {0} where id = {1}; ", tensize,id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteBangSize(int id)
        {
            SanPhamDAO.Instance.DeleteSanPhamByIdBangSize(id);
            string query = string.Format("Delete Bang_Size where id = {0};",id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
