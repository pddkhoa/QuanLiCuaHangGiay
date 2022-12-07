using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiBanGiay.DTO
{
    public class NhaCungCap
    {
        private int id;
        private string tenncc;
        private string diachi;

        public NhaCungCap(int id, string tenncc,string diachi)
        {
            this.Id = id;
            this.Tenncc = tenncc;
            this.Diachi = diachi;
        }
        public NhaCungCap(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenncc = row["tenncc"].ToString();
            this.Diachi = row["diachi"].ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
