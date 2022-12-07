using QuanLyCuaHangGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiay.DAO
{
    public class ThongKeDAO
    {
        private static ThongKeDAO instance;
        public static ThongKeDAO Instance
        {
            get { if (instance == null) instance = new ThongKeDAO(); return ThongKeDAO.instance; }
            set { ThongKeDAO.instance = value; }
        }
        private ThongKeDAO()
        { }
        public List<ViewThongKe> ThongKeTheoNgay(DateTime checkout, DateTime checkin)
        {
            List<ViewThongKe> lists = new List<ViewThongKe>();
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("ThongKeDoanhThuTheoNgay @CheckOut , @CheckIn", new object[] { checkout, checkin });
            foreach (DataRow item in data.Rows)
            {
                ViewThongKe thongKe = new ViewThongKe(item);
                lists.Add(thongKe);
            }
            return lists;
        }
    }
}
