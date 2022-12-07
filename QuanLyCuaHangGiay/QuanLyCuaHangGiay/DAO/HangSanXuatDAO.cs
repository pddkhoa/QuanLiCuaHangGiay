using QuanLiBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyCuaHangGiay.DAO
{
    public class HangSanXuatDAO
    { 
        private static HangSanXuatDAO instance;
        public static HangSanXuatDAO Instance
        {
            get { if (instance == null) instance = new HangSanXuatDAO(); return HangSanXuatDAO.instance; }
            set { HangSanXuatDAO.instance = value; }
        }
        private HangSanXuatDAO()
        { }
        public List<HangSanXuat> GetListHangSanXuat()
        {
            List<HangSanXuat> list = new List<HangSanXuat>();
            string query = "Select * From Hang_San_Xuat";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HangSanXuat hangSanXuat = new HangSanXuat(item);
                list.Add(hangSanXuat);
            }
            return list;
        }
        public HangSanXuat GetHangSanXuatByID(int id)
        {
            HangSanXuat hangSanXuat = null;
            string query = String.Format("Select * From Hang_San_Xuat where id={0}", id);
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                hangSanXuat = new HangSanXuat(item);
                return hangSanXuat;
            }
            return hangSanXuat;
        }
        public bool InsertHangSanXuat(string tenhang, string diachi)
        {
            string query = string.Format("INSERT into Hang_San_Xuat(tenhang, diachi) VALUES(N'{0}', N'{1}'); ", tenhang,diachi);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateHangSanXuat(int id, string tenhang, string diachi)
        {
            string query = string.Format("Update Hang_San_Xuat Set tenhang = N'{0}' , diachi = N'{1}' where id = {2}; ", tenhang, diachi,id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteHangSanXuat(int id)
        {
            SanPhamDAO.Instance.DeleteSanPhamByIdHangSanXuat(id);
            string query = string.Format("Delete Hang_San_Xuat where id = {0};", id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
