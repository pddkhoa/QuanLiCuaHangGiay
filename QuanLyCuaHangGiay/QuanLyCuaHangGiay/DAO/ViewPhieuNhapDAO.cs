using QuanLyCuaHangGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
    public class ViewPhieuNhapDAO
    {
        private static ViewPhieuNhapDAO instance;
        public static ViewPhieuNhapDAO Instance
        {
            get { if (instance == null) instance = new ViewPhieuNhapDAO(); return ViewPhieuNhapDAO.instance; }
            set { ViewPhieuNhapDAO.instance = value; }
        }
        private ViewPhieuNhapDAO() { }

        public List<ViewPhieuNhap> GetlistViewPhieuNhap()
        {
            List<ViewPhieuNhap> list = new List<ViewPhieuNhap>();
            string query = "EXEC VIEW_PHIEUNHAP";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ViewPhieuNhap viewPhieu = new ViewPhieuNhap(item);
                list.Add(viewPhieu);
            }
            return list;
        }
        public bool InsertPhieuNhap(int idnhanvien, int idnhacc, int idsanpham, int soluong, int gianhap)
        { 
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery("EXEC ADD_PHIEUNHAP @IDNhanVien , @idNhaCC , @idSanPham , @SoLuong , @GiaNhap", new object[] {idnhanvien,idnhacc,idsanpham,soluong,gianhap });
            return result > 0;
        }
        public bool UpdatePhieuNhap(int id,int idnhanvien, int idnhacc, int idsanpham, int soluong, int gianhap)
        {
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery("EXEC UP_PHIEUNHAP @ID , @IDNhanVien , @idNhaCC , @idSanPham , @SoLuong , @GiaNhap", new object[] { id,idnhanvien, idnhacc, idsanpham, soluong, gianhap });
            return result > 0;
        }
        public bool DeletePhieuNhap(int id)
        {
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery("EXEC DEL_PHIEUNHAP @ID", new object[] { id});
            return result > 0;
        }

    }
}
