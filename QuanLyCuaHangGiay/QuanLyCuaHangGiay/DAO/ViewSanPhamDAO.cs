using QuanLyCuaHangGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
    public class ViewSanPhamDAO
    {
        private static ViewSanPhamDAO instance;

        public static ViewSanPhamDAO Instance
        {
            get { if (instance == null) instance = new ViewSanPhamDAO(); return ViewSanPhamDAO.instance; }
            set { ViewSanPhamDAO.instance = value; }
        }
        public static int SanPhamWidth = 170;
        public static int SanPhamHeight = 170;
        private ViewSanPhamDAO()
        { }
        public List<ViewSanPham> GetListViewSanPham()
        {
            List<ViewSanPham> list = new List<ViewSanPham>();
            string query = "SELECT SAN_PHAM.ID, SAN_PHAM.TEN, SAN_PHAM.MAUSAC, SAN_PHAM.GIABAN, BANG_SIZE.TENSIZE, HANG_SAN_XUAT.TENHANG, SAN_PHAM.SOLUONG, KHO.TENKHO FROM SAN_PHAM INNER JOIN BANG_SIZE ON SAN_PHAM.idSIZE = BANG_SIZE.ID INNER JOIN HANG_SAN_XUAT ON SAN_PHAM.idHANGSX = HANG_SAN_XUAT.ID INNER JOIN KHO ON SAN_PHAM.idKHO = KHO.ID";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ViewSanPham viewSP = new ViewSanPham(item);
                list.Add(viewSP);
            }
            return list;
        }
        public List<ViewSanPham> GetListViewSanPhamById(int id)
        {
            List<ViewSanPham> list = new List<ViewSanPham>();
            string query = "SELECT SAN_PHAM.ID, SAN_PHAM.TEN, SAN_PHAM.MAUSAC, SAN_PHAM.GIABAN, BANG_SIZE.TENSIZE, HANG_SAN_XUAT.TENHANG, SAN_PHAM.SOLUONG, KHO.TENKHO FROM SAN_PHAM INNER JOIN BANG_SIZE ON SAN_PHAM.idSIZE = BANG_SIZE.ID INNER JOIN HANG_SAN_XUAT ON SAN_PHAM.idHANGSX = HANG_SAN_XUAT.ID INNER JOIN KHO ON SAN_PHAM.idKHO = KHO.ID WHERE SAN_PHAM.ID =" + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ViewSanPham sanPham = new ViewSanPham(item);
                list.Add(sanPham);
            }
            return list;
        }
    }
}
