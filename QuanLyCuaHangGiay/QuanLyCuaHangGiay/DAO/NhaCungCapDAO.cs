using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiBanGiay.DTO;

namespace QuanLyCuaHangGiay.DAO
{
   public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO Instance
        {
            get { if (instance == null) instance = new NhaCungCapDAO(); return NhaCungCapDAO.instance; }
            set { NhaCungCapDAO.instance = value; }
        }
        public NhaCungCapDAO() { }
        public List<NhaCungCap> GetListNhaCungCap()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            string query = "SELECT * FROM NHA_CUNG_CAP";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                NhaCungCap nhaCungCap = new NhaCungCap(item);
                list.Add(nhaCungCap);
            }
            return list;
        }
        public NhaCungCap GetNhaCungCapByID(int id)
        {
            NhaCungCap ncc = null;
            string query = String.Format("Select * From Nha_Cung_Cap where id={0}", id);
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ncc = new NhaCungCap(item);
                return ncc;
            }
            return ncc;
        }
    }
}
