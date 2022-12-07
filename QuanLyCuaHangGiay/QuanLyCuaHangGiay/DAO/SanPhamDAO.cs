using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiBanGiay.DTO;

namespace QuanLyCuaHangGiay.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return SanPhamDAO.instance; }
            set { SanPhamDAO.instance = value; }
        }
        public static int SanPhamWidth = 170;
        public static int SanPhamHeight = 170;
        private SanPhamDAO()
        { }

        public List<SanPham> GetListSanPham()
        {
            List<SanPham> list = new List<SanPham>();
            string query = "SELECT * FROM SAN_PHAM";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPham sanPham = new SanPham(item);
                list.Add(sanPham);
            }
            return list;
        }

        public List<SanPham> GetListSanPhamByIdSize(int id)
        {
            List<SanPham> list = new List<SanPham>();
            string query = "SELECT * FROM SAN_PHAM Where IDSIZE = "+id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPham sanPham = new SanPham(item);
                list.Add(sanPham);
            }
            return list;
        }
        public SanPham GetSanPhamByID(int id)
        {
            SanPham sanPham = null;
            string query = String.Format("Select * From San_Pham where id={0}", id);
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                sanPham = new SanPham(item);
                return sanPham;
            }
            return sanPham;
        }

        public List<SanPham> GetListSanPhamByIdSanPham(int id)
        {
            List<SanPham> list = new List<SanPham>();
            string query = "SELECT * FROM SAN_PHAM Where ID = " + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPham sanPham = new SanPham(item);
                list.Add(sanPham);
            }
            return list;
        }

        public bool InsertSanPham(string ten, string mausac, int idsize,int giaban,int idhangsx,int idkho,int soluong)
        {
            string query = string.Format("INSERT San_Pham(ten ,mausac ,idsize ,giaban ,idhangsx ,idkho ,soluong ) VALUES(N'{0}',N'{1}',{2},{3},{4},{5},{6}); ", ten,mausac,idsize,giaban,idhangsx,idkho, soluong);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateSanPham(int id, string ten, string mausac, int idsize, int giaban, int idhangsx, int idkho,int soluong)
        {
            string query = string.Format("Update SAN_PHAM Set TEN = N'{0}' ,MAUSAC= N'{1}' ,idSIZE={2} ,GIABAN={3} ,idHANGSX={4} ,idKHO={5}, SOLUONG={6} where ID = {7}; ", ten, mausac, idsize, giaban, idhangsx, idkho,soluong,id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteSanPham(int id)
        {
            GioHangDAO.Instance.DeleteGioHangBySanPham(id);
            PhieuNhapDAO.Instance.DeletePhieuNhapByIdSanPham(id);
            string query = string.Format("Delete San_Pham where id = {0};", id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public void DeleteSanPhamByIdHangSanXuat(int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("Delete San_Pham where idhangsx = " + id);
        }
        public void DeleteSanPhamByIdKho(int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("Delete San_Pham where idkho = " + id);
        }
        public void DeleteSanPhamByIdBangSize(int id)
        {
            
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("Delete San_Pham where idsize = " + id);
        }




    }
}
