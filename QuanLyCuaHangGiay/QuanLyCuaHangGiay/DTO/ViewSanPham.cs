using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DTO
{
    public class ViewSanPham
    {
        private int id;
        private string tensp;
        private string mausac;
        private int giaban;
        private int tensize;
        private string tenhang;
        private string tenkho;
        private int soluong;

        public ViewSanPham(int id, string tensp, string mausac, int giaban, int tensize, string tenhang, string tenkho, int soluong)
        {
            this.Id = id;
            this.Tensp = tensp;
            this.Mausac = mausac;
            this.Giaban = giaban;
            this.Tensize = tensize;
            this.Tenhang = tenhang;
            this.Tenkho = tenkho;
            this.Soluong = soluong;
        }
        public ViewSanPham(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tensp = row["ten"].ToString();
            this.Mausac = row["mausac"].ToString();
            this.Giaban = (int)row["giaban"];
            this.Tensize = (int)row["tensize"];
            this.Tenhang = row["tenhang"].ToString();
            this.Tenkho = row["tenkho"].ToString();
            this.Soluong = (int)row["soluong"];
        }

        public int Id { get => id; set => id = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Mausac { get => mausac; set => mausac = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public int Tensize { get => tensize; set => tensize = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Tenkho { get => tenkho; set => tenkho = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
