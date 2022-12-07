using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiBanGiay.DTO
{
    public class Kho
    {
        private int id;
        private string tenkho;
        private string diachi;

        public Kho(int id,string tenkho,string diachi)
        {
            this.Id = id;
            this.Tenkho = tenkho;
            this.Diachi = diachi;
        }
        public Kho(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenkho = row["tenkho"].ToString();
            this.Diachi = row["diachi"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Tenkho { get => tenkho; set => tenkho = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
