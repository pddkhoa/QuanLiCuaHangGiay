using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiBanGiay.DTO
{
    public class GioHang
    {
        private int id;
        private int idHoaDon;
        private int idSanPham;
        private int soluong;


        public GioHang(int id,int idHoaDon,int idSanPham,int soluong)
        {
            this.Id = id;
            this.IdHoaDon = idHoaDon;
            this.IdSanPham = idSanPham;
            this.Soluong = soluong;
        }
        public GioHang(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdHoaDon = (int)row["idHoaDon"];
            this.IdSanPham = (int)row["idSanPham"];
            this.Soluong = (int)row["soluong"];
        }
        public int Id { get => id; set => id = value; }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdSanPham { get => idSanPham; set => idSanPham = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
