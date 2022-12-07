using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DTO
{
    public class ViewGioHang
    {
        
        private string tensanpham;
        private string mausac;
        private int tensize;
        private int giaban;
        private int soluong;
        private int tongtien;

        public ViewGioHang(string tensanpham, string mausac, int tensize, int giaban, int soluong, int tongtien)
        {
            this.Tensanpham = tensanpham;
            this.Mausac = mausac;
            this.Tensize = tensize;
            this.Giaban = giaban;
            this.Soluong = soluong;
            this.Tongtien = tongtien;
        }

        public ViewGioHang(DataRow row)
        {
            this.Tensanpham = row["ten"].ToString();
            this.Mausac = row["mausac"].ToString();
            this.Tensize = (int)row["tensize"];
            this.Giaban = (int)row["giaban"];
            this.Soluong = (int)row["soluong"];
            this.Tongtien = (int)row["tongtien"];
        }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public string Mausac { get => mausac; set => mausac = value; }
        public int Tensize { get => tensize; set => tensize = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
