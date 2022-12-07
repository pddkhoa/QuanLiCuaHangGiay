using QuanLiBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyCuaHangGiay.DAO
{
     public class CaLamDAO
    {
        private static CaLamDAO instance;
        public static CaLamDAO Instance
        {
            get { if (instance == null) instance = new CaLamDAO(); return CaLamDAO.instance; }
            set { CaLamDAO.instance = value; }
        }
        private CaLamDAO() { }
        public List<CaLam> GetListCaLam()
        {
            List<CaLam> list = new List<CaLam>();
            string query = "SELECT * FROM CA_LAM";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                CaLam caLam = new CaLam(item);
                list.Add(caLam);
            }
            return list;

        }
        public bool InsertCaLam(string tenca, int thoigian)
        {
            string query = string.Format("INSERT into Ca_Lam(tenca, thoigian) VALUES(N'{0}', {1}); ", tenca, thoigian);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCaLam(string tenca, int thoigian, int id)
        {
            string query = string.Format("Update Ca_Lam Set tenca = N'{0}' , thoigian = {1} where id = {2}; ", tenca, thoigian, id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCaLam(int id)
        {
            string query = string.Format("Delete Ca_Lam where id = {0};", id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
