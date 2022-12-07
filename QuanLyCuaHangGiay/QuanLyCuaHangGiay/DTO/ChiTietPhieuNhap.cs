using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiBanGiay.DTO
{
    public class ChiTietPhieuNhap
    {
        private int id;
        private int idSanPham;
        private int soluong;
        private int gianhap;
        private int tongtien;

        public ChiTietPhieuNhap(int id,int idSanPham,int soluong,int gianhap,int tongtien)
        {
            this.Id = id;
            this.IdSanPham = idSanPham;
            this.Soluong = soluong;
            this.Gianhap = gianhap;
            this.Tongtien = tongtien;
        }
        public ChiTietPhieuNhap(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdSanPham = (int)row["idSanPham"];
            this.Soluong = (int)row["soluong"];
            this.Gianhap = (int)row["gianhap"];
            this.Tongtien = (int)row["tongtien"];
        }
        public int Id { get => id; set => id = value; }
        public int IdSanPham { get => idSanPham; set => idSanPham = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gianhap { get => gianhap; set => gianhap = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
