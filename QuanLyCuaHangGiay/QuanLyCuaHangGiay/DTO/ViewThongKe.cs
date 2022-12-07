using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DTO
{
    public class ViewThongKe
    {
        private int id;
        private DateTime ngaylaphd;
        private string hoten;
        private int tongtien;
        private bool trangthai;

        public ViewThongKe(int id, DateTime ngaylaphd, string hoten, int tongtien, bool trangthai)
        {
            this.Id = id;
            this.Ngaylaphd = ngaylaphd;
            this.Hoten = hoten;
            this.Tongtien = tongtien;
            this.Trangthai = trangthai;
        }

        public ViewThongKe(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Ngaylaphd = (DateTime)row["ngaylaphd"];
            this.Hoten = row["hoten"].ToString();
            this.Tongtien = (int)row["tongtien"];
            this.Trangthai = (bool)row["trangthai"];
        }

        public int Id { get => id; set => id = value; }
        public DateTime Ngaylaphd { get => ngaylaphd; set => ngaylaphd = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
    }
}
