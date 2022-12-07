using QuanLiBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            set { KhachHangDAO.instance = value; }
        }
        private KhachHangDAO()
        { }
        public List<KhachHang> GetListKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            string query = "Select * From Khach_Hang";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhachHang khachHang = new KhachHang(item);
                list.Add(khachHang);
            }
            return list;
        }
        public List<KhachHang> GetListKhachHangUncheck()
        {
            List<KhachHang> list = new List<KhachHang>();
            string query = "SELECT * FROM KHACH_HANG INNER JOIN HOA_DON ON KHACH_HANG.ID = HOA_DON.idKhachHang WHERE TRANGTHAI = 0";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhachHang khachHang = new KhachHang(item);
                list.Add(khachHang);
            }
            return list;
        }
        public bool InsertKhachHang(string hoten, DateTime ngaysinh, string sdt, string diachi)
        {
            string query = string.Format("INSERT Khach_Hang(hoten, ngaysinh, sdt, diachi ) VALUES(N'{0}',N'{1}',N'{2}',N'{3}'); ", hoten, ngaysinh, sdt, diachi);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateKhachHang(int id, string hoten, DateTime ngaysinh, string sdt, string diachi)
        {
            string query = string.Format("Update KHACH_HANG Set HOTEN = N'{0}' ,NGAYSINH= N'{1}' ,SDT=N'{2}' , DIACHI=N'{3}'  where ID = {4}; ", hoten, ngaysinh, sdt, diachi,id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteKhachHang(int id)
        {
            HoaDonDAO.Instance.DeleteHoaDonByIdKhachHang(id);
            string query = string.Format("Delete Khach_Hang where id = {0};", id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
