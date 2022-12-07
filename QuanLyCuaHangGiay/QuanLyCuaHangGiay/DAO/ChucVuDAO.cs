using QuanLiBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyCuaHangGiay.DAO
{
   public class ChucVuDAO
    {
        private static ChucVuDAO instance;
        public static ChucVuDAO Instance
        {
            get { if (instance == null) instance = new ChucVuDAO(); return ChucVuDAO.instance; }
            set { ChucVuDAO.instance = value; }
        }
        private ChucVuDAO() { }
        public List<ChucVu> GetlistChucVu()
        {
            List<ChucVu> list = new List<ChucVu>();
            string query = "Select * FROM CHUC_VU";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                ChucVu chucVu = new ChucVu(item);
                list.Add(chucVu);
            }
            return list;
        }
        public bool InsertChucVu(string tenchucvu, int luong)
        {
            string query = string.Format("INSERT into Chuc_Vu(tenchucvu, luong) VALUES(N'{0}', {1}); ", tenchucvu, luong);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateChucVu(string tenchucvu, int luong, int id)
        {
            string query = string.Format("Update Chuc_Vu Set tenchucvu = N'{0}' , luong = {1} where id = {2}; ", tenchucvu, luong,id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteChucVu(int id)
        {
            string query = string.Format("Delete Chuc_Vu where id = {0};", id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
