using QuanLiBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
     public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            set { HoaDonDAO.instance = value; }
        }
        private HoaDonDAO()
        { }
        public void checkOut(int tongtien,int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("UPDATE HOA_DON SET HOA_DON.TRANGTHAI = 1 , HOA_DON.TONGTIEN = "+tongtien+" WHERE HOA_DON.ID = " + id);
            
        }
        public int GetUncheckHoaDonByIDKhachHang(int id)
        {
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("Select * from HOA_DON where idKhachHang = "+id+" AND TRANGTHAI = 0");
            if(data.Rows.Count > 0)
            {
                HoaDon hoaDon = new HoaDon(data.Rows[0]);
                return hoaDon.Id;
            }
            return -1;
        }
        public void InsertHoaDon(int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteNonQuery("ADD_HOADON @IDKHACHHANG",new object[] {id});
        }

        public List<HoaDon> GetHoaDonByIdKhachHang(int id)
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = "SELECT * FROM HOA_DON Where IDKHACHHANG = " + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HoaDon sanPham = new HoaDon(item);
                list.Add(sanPham);
            }
            return list;
        }
        public int GetHoaDonMax()
        {
            DataProvider provider = new DataProvider();
            try
            {
                return (int)provider.ExecuteScalar("SELECT MAX(ID) FROM HOA_DON");
            }
            catch
            {
                return 1;
            }
        }
        public bool DeleteHoaDon(int id)
        {
            GioHangDAO.Instance.DeleteGioHangByHoaDon(id);
            string query = string.Format("Delete Hoa_Don where id = {0};", id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public void DeleteHoaDonByIdKhachHang(int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("Delete HOA_DON where idkhachhang = " + id);
        }
    }
}
