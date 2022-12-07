using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QuanLiBanGiay.DTO
{
    public class ChucVu
    {
        private int id;
        private string tenchucvu;
        private int luong;

        public ChucVu(int id,string tenchucvu,int luong)
        {
            this.Id = id;
            this.Tenchucvu = tenchucvu;
            this.Luong = luong;
        }
        public ChucVu(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenchucvu = row["tenchucvu"].ToString();
            this.Luong = (int)row["luong"];
        }

        public int Id { get => id; set => id = value; }
        public string Tenchucvu { get => tenchucvu; set => tenchucvu = value; }
        public int Luong { get => luong; set => luong = value; }
    }
}
