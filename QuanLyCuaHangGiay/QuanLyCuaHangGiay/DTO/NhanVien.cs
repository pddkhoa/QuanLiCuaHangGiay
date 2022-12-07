using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanGiay.DTO
{
    public class NhanVien
    {
        private int id;
        private string hoten;
        private bool gioitinh;
        private DateTime ngaysinh;
        private string cmnd;
        private string sdt;
        private string diachi;
        private int idChucvu;
        private int idCalam;

        public NhanVien(int id, string hoten, bool gioitinh, DateTime ngaysinh, string cmnd, string sdt,string diachi, int idCalam, int idChucvu)
        {
            this.Id = id;
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.Cmnd = cmnd;
            this.Sdt = sdt;
            this.Diachi = diachi;
            this.IdCalam = idCalam;
            this.IdChucvu = idChucvu;
        }
        public NhanVien(DataRow row)
        {
            this.Id = (int)row["id"];
           
            this.Hoten = row["hoten"].ToString();
            this.Gioitinh = (bool)row["gioitinh"];
            this.Ngaysinh = (DateTime)row["ngaysinh"];
            this.Cmnd = row["cmnd"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.IdCalam = (int)row["idCALAM"];
            this.IdChucvu = (int)row["idCHUCVU"];

        }
        public int Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int IdChucvu { get => idChucvu; set => idChucvu = value; }
        public int IdCalam { get => idCalam; set => idCalam = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
