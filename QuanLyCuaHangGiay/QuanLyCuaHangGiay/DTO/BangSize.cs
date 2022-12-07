using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiBanGiay.DTO
{
    public class BangSize
    {
        private int id;
        private int tensize;

        public BangSize(int id,int tensize)
        {
            this.Id = id;
            this.Tensize = tensize;
        }
        public BangSize(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tensize = (int)row["tensize"];
        }
        public int Id { get => id; set => id = value; }
     
        public int Tensize { get => tensize; set => tensize = value; }
    }
}
