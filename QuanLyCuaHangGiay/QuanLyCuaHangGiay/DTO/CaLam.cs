using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiBanGiay.DTO
{
    public class CaLam
    {
        private int id;
        private string tenca;
        private int thoigian;

        public CaLam()
        {
            this.Id = id;
            this.Tenca = tenca;
            this.Thoigian = thoigian;
        }
        public CaLam(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenca = row["tenca"].ToString();
            this.Thoigian = (int)row["thoigian"];
        }
        public int Id { get => id; set => id = value; }
        public string Tenca { get => tenca; set => tenca = value; }
        public int Thoigian { get => thoigian; set => thoigian = value; }
    }
}
