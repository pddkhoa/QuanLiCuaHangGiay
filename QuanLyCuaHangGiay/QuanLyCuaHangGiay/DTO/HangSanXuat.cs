using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiBanGiay.DTO
{
    public class HangSanXuat
    {
        private int id;
        private string tenhang;
        private string diachi;

       
        public HangSanXuat(int id,string tenhang,string diachi)
        {
            this.Id = id;
            this.Tenhang = tenhang;
            this.Diachi = diachi;
        }
        public HangSanXuat(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenhang = row["tenhang"].ToString();
            this.Diachi = row["diachi"].ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
