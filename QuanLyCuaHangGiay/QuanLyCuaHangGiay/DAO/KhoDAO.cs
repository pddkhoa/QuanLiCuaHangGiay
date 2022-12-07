using QuanLiBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
    public class KhoDAO
    {
        private static KhoDAO instance;
        public static KhoDAO Instance
        {
            get { if (instance == null) instance = new KhoDAO(); return KhoDAO.instance; }
            set { KhoDAO.instance = value; }
        }
        private KhoDAO() { }
        public List<Kho> GetListKho()
        {
            List<Kho> list = new List<Kho>();
            string query = "Select * FROM Kho";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Kho kho = new Kho(item);
                list.Add(kho);
            }
            return list;
        }
        public Kho GetKhoByID(int id)
        {
            Kho kho = null;
            string query = String.Format("Select * From Kho where id={0}", id);
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                kho = new Kho(item);
                return kho;
            }
            return kho;
        }
        public bool InsertKho(string tenkho,string diachi)
        {
            string query = string.Format("INSERT into Kho(tenkho, diachi) VALUES(N'{0}', N'{1}'); ", tenkho,diachi);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateKho(int id,string tenkho, string diachi)
        {
            string query = string.Format("Update KHO Set tenkho = N'{0}' , diachi = N'{1}' where id = {2}; ", tenkho,diachi, id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteKho(int id)
        {
            SanPhamDAO.Instance.DeleteSanPhamByIdKho(id);
            string query = string.Format("Delete KHO where id = {0};", id);
            DataProvider provider = new DataProvider();
            int result = provider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
