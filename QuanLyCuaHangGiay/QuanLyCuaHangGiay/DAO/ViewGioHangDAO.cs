using QuanLyCuaHangGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
    public class ViewGioHangDAO
    {

        private static ViewGioHangDAO instance;

        public static ViewGioHangDAO Instance
        {
            get { if (instance == null) instance = new ViewGioHangDAO(); return ViewGioHangDAO.instance; }
            set { ViewGioHangDAO.instance = value; }
        }
        private ViewGioHangDAO()
        { }
        public List<ViewGioHang> GetListViewGioHangByIDKhachHang(int id)
        {
            List<ViewGioHang> list = new List<ViewGioHang>();
            string query = "SELECT SAN_PHAM.TEN, SAN_PHAM.MAUSAC, BANG_SIZE.TENSIZE, SAN_PHAM.GIABAN, GIO_HANG.SOLUONG, SAN_PHAM.GIABAN*GIO_HANG.SOLUONG AS TONGTIEN FROM GIO_HANG INNER JOIN HOA_DON ON GIO_HANG.idHoaDon = HOA_DON.ID INNER JOIN KHACH_HANG ON HOA_DON.idKhachHang = KHACH_HANG.ID INNER JOIN SAN_PHAM ON GIO_HANG.idSanPham = SAN_PHAM.ID INNER JOIN BANG_SIZE ON SAN_PHAM.idSIZE = BANG_SIZE.ID WHERE HOA_DON.TRANGTHAI = 0 AND KHACH_HANG.ID = "+id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                ViewGioHang viewGioHang = new ViewGioHang(item);
                list.Add(viewGioHang);
            }    
            return list;
        }
        
    }
        
}
