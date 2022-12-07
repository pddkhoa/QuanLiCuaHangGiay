using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanGiay.DTO
{
    public class HoaDon
    {
        private int id;
        private DateTime? ngaylaphd;
        private int idKhachhang;
 
        private bool trangthai;

        public HoaDon(int id, DateTime ngaylaphd, int idKhachhang, bool trangthai)
        {
            this.Id = id;
            this.Ngaylaphd = ngaylaphd;
            this.IdKhachhang = idKhachhang;
            this.Trangthai = trangthai;
        }
        public HoaDon(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Ngaylaphd = (DateTime?)row["ngaylaphd"];
            this.IdKhachhang = (int)row["idKhachhang"];
            
            this.trangthai = (bool)row["trangthai"];
        }
        public int Id { get => id; set => id = value; }
        public DateTime? Ngaylaphd { get => ngaylaphd; set => ngaylaphd = value; }
        public int IdKhachhang { get => idKhachhang; set => idKhachhang = value; }
     
        public bool Trangthai { get => trangthai; set => trangthai = value; }
    }
}
