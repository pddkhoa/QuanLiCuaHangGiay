using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanGiay.DTO
{
    public class PhieuNhap
    {
        private int id;
        private int idNhanVien;
        private DateTime ngaynhap;
        private int idNhaCC;
     

        public PhieuNhap(int id, int idNhanVien,DateTime ngaynhap,int idNhaCC)
        {
            this.Id = id;
            this.IdNhanVien = idNhanVien;
            this.Ngaynhap = ngaynhap;
            this.IdNhaCC = idNhaCC;
           
        }
        public PhieuNhap(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdNhanVien = (int)row["idNhanVien"];
            this.ngaynhap = (DateTime)row["ngaynhap"];
            this.IdNhaCC = (int)row["idNhaCC"];
           
        }
        public int Id { get => id; set => id = value; }
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public int IdNhaCC { get => idNhaCC; set => idNhaCC = value; }
        
    }
}
