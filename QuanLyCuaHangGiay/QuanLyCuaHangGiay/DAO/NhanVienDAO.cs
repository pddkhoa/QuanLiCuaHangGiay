using QuanLiBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            set { NhanVienDAO.instance = value; }
        }
        private NhanVienDAO()
        { }
        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "Select * from Nhan_Vien";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                NhanVien nhanVien = new NhanVien(item);
                list.Add(nhanVien);
            }
            return list;
        }
        public NhanVien GetNhanVienByID(int id)
        {
            NhanVien nhanVien = null;
            string query = String.Format("Select * From Nhan_Vien where id={0}", id);
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                nhanVien = new NhanVien(item);
                return nhanVien;
            }
            return nhanVien;
        }
        public List<NhanVien> searchNhanVien(String txtS)
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "SELECT * FROM NHAN_VIEN WHERE CONCAT(ID, HOTEN, GIOITINH, NGAYSINH, CMND, SDT, DIACHI, idCALAM, idCHUCVU)  LIKE '%" + txtS + "%'";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanVien = new NhanVien(item);
                list.Add(nhanVien);
            }
            return list;
        }
        public bool InsertNhanVien(string hoten, bool gioitinh, DateTime ngaysinh, string cmnd, string sdt, string diachi, int idCalam, int idChucvu)
        {
            int val = gioitinh ? 1 : 0;
            string query = string.Format("INSERT INTO NHAN_VIEN(NHAN_VIEN.HOTEN, NHAN_VIEN.GIOITINH, NHAN_VIEN.NGAYSINH, NHAN_VIEN.CMND, NHAN_VIEN.SDT, NHAN_VIEN.DIACHI, NHAN_VIEN.idCALAM, NHAN_VIEN.idCHUCVU) VALUES (N'{0}', {1}, '{2}', '{3}', '{4}', N'{5}', {6}, {7});", hoten,val,ngaysinh,cmnd,sdt,diachi,idCalam,idChucvu);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateNhanVien(int id, string hoten, bool gioitinh, DateTime ngaysinh, string cmnd, string sdt, string diachi, int idCalam, int idChucvu)
        {
            int val = gioitinh ? 1 : 0;
            string query = string.Format("UPDATE NHAN_VIEN SET NHAN_VIEN.HOTEN = N'{0}', NHAN_VIEN.GIOITINH = {1}, NHAN_VIEN.NGAYSINH = '{2}', NHAN_VIEN.CMND = '{3}', NHAN_VIEN.SDT='{4}', NHAN_VIEN.DIACHI = N'{5}', NHAN_VIEN.idCALAM = {6}, NHAN_VIEN.idCHUCVU = {7} WHERE NHAN_VIEN.ID = {8};", hoten, val, ngaysinh, cmnd, sdt, diachi, idCalam, idChucvu, id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteNhanVien(int id)
        {
            PhieuNhapDAO.Instance.DeletePhieuNhapByIdNhanVien(id);
            string query = string.Format("Delete NHAN_VIEN where id = {0};", id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public void DeleteNhanVienByIDCaLam(int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("DELETE NHAN_VIEN WHERE NHAN_VIEN.idCALAM = " + id);
        }
        public void DeleteNhanVienByIDChucVu(int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("DELETE NHAN_VIEN WHERE NHAN_VIEN.idCHUCVU = " + id);
        }
    }
}
