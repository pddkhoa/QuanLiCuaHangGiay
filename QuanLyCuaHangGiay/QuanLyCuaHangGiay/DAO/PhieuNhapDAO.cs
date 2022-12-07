using QuanLiBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
   public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;

        public static PhieuNhapDAO Instance
        {
            get { if (instance == null) instance = new PhieuNhapDAO(); return PhieuNhapDAO.instance; }
            set { PhieuNhapDAO.instance = value; }
        }
        private PhieuNhapDAO()
        { }
        public void DeletePhieuNhapByIdSanPham(int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("Delete ChiTiet_PhieuNhap where idsanpham = " + id);
        }
        public void DeletePhieuNhapByIdNhanVien(int id)
        {
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery("DELETE PHIEU_NHAP WHERE idNhanVien = " + id);
        }

    }
}
