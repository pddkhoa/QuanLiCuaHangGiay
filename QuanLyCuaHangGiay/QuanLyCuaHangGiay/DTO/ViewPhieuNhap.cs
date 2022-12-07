
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DTO
{
    public class ViewPhieuNhap
    {
        private int id;
        private DateTime ngaynhap;
        private int idnhanvien;
        private int idncc;
        private int idsanpham;
        private int idsize;
        private int soluong;
        private int gianhap;
        private int tongtien;
        private string tensize;
        private string hoten;
        private string tenncc;
        private string ten;
        public int Id { get => id; set => id = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
       
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gianhap { get => gianhap; set => gianhap = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public int Idnhanvien { get => idnhanvien; set => idnhanvien = value; }
        public int Idncc { get => idncc; set => idncc = value; }
        public int Idsanpham { get => idsanpham; set => idsanpham = value; }
        public int Idsize { get => idsize; set => idsize = value; }
        public string Tensize { get => tensize; set => tensize = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public string Ten { get => ten; set => ten = value; }

        public ViewPhieuNhap(int id, DateTime ngaynhap, int idnhanvien, int idncc, int idsanpham, int idsize, int soluong, int gianhap, int tongtien,string tensize, string hoten, string tenncc, string ten)
        {
            this.Id = id;
            this.Ngaynhap = ngaynhap;
            this.Idnhanvien = idnhanvien;
            this.Idncc = idncc;
            this.Idsanpham = idsanpham;
            this.Idsize = idsize;
            this.Soluong = soluong;
            this.Gianhap = gianhap;
            this.Tongtien = tongtien;
            this.Tensize = tensize;
            this.Hoten = hoten;
            this.Tenncc = tenncc;
            this.Ten = ten;
        }
        public ViewPhieuNhap(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Ngaynhap = (DateTime)row["ngaynhap"];
            this.Idnhanvien = (int)row["idnhanvien"];
            this.Idncc = (int)row["idnhacc"];
            this.Idsanpham = (int)row["idsanpham"];
            this.Idsize = (int)row["idsize"];
            this.Soluong = (int)row["soluong"];
            this.Gianhap = (int)row["gianhap"];
            this.Tongtien = (int)row["tongtien"];
            this.Tensize = row["tensize"].ToString();
            this.Hoten = row["hoten"].ToString();
            this.Tenncc = row["tenncc"].ToString();
            this.Ten = row["ten"].ToString();

        }


    }
}
