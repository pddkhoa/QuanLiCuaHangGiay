using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiBanGiay.DTO
{
    public class KhachHang
    {
        private int id;
        private string hoten;
        private DateTime ngaysinh;
        private string sdt;
        private string diachi;

        public KhachHang(int id, string hoten, DateTime ngaysinh, string sdt, string diachi)
        {
            this.Id = id;
            this.Hoten = hoten;
            this.Ngaysinh = ngaysinh;
            this.Sdt = sdt;
            this.Diachi = diachi;
        }
        public KhachHang(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Hoten = row["hoten"].ToString();
            this.Ngaysinh = (DateTime)row["ngaysinh"];
            this.Sdt = row["sdt"].ToString();
            this.Diachi = row["diachi"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
