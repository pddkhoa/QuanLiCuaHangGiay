using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiBanGiay.DTO;

namespace QuanLyCuaHangGiay.DAO
{
     public class GioHangDAO
    {
        private static GioHangDAO instance;
        public static GioHangDAO Instance
        {
            get { if (instance == null) instance = new GioHangDAO(); return GioHangDAO.instance; }
            set { GioHangDAO.instance = value; }
        }
        private GioHangDAO()
        { }
        public List<GioHang> GetListGioHang(int id)
        {
            List<GioHang> list = new List<GioHang>();
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("SELECT * FROM GIO_HANG Where idHoaDon = "+ id);
            foreach(DataRow item in data.Rows)
            {
                GioHang gioHang = new GioHang(item);
                list.Add(gioHang);
            }
            return list;
        }
        public void InsertGioHang(int idhoadon,int idsanpham, int soluong)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteNonQuery("ADD_GIOHANG @IDHOADON , @IDSANPHAM , @SOLUONG", new object[] {idhoadon,idsanpham,soluong });
        }
        public void DeleteGioHangBySanPham(int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("Delete Gio_Hang where idSanPham = " + id);
        }
        public void DeleteGioHangByHoaDon(int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("Delete Gio_Hang where idHoaDon = " + id);
        }
    }
}
