using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLiBanGiay.DTO
{
    public class SanPham
    {
        private int id;
        private string ten;
        private string mausac;
        private int idsize;
        private int giaban;
        private int idhangsx;
        private int idkho;
        private int soluong;
     
        public SanPham(int id,string ten,string mausac,int idsize,int giaban,int idhangsx,int idkho, int soluong)
        {
            this.Id = id;
            this.Ten = ten;
            this.Mausac = mausac;
            this.Idsize = idsize;
            this.Giaban = giaban;
            this.Idhangsx = idhangsx;
            this.Idkho = idkho;
            this.Soluong = soluong;
          
   
        }
        public SanPham(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Ten = row["ten"].ToString();
            this.Mausac = row["mausac"].ToString();
            this.Idsize = (int)row["idsize"];
            this.Giaban = (int)row["giaban"];
            this.Idhangsx = (int)row["idhangsx"];
            this.Idkho = (int)row["idKho"];
            this.Soluong = (int)row["soluong"];


        }
        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Mausac { get => mausac; set => mausac = value; }
        public int Giaban { get => giaban; set => giaban = value; }

        public int Idsize { get => idsize; set => idsize = value; }
        public int Idhangsx { get => idhangsx; set => idhangsx = value; }
        public int Idkho { get => idkho; set => idkho = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
