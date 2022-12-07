using QuanLyCuaHangGiay.DAO;
using QuanLyCuaHangGiay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiay
{
    public partial class fReport : Form
    {
       

        public fReport()
        {
            InitializeComponent();
            
        }
        public void LoadCustomer()
        {
          
        }
        public void LoadThongKe(DateTime checkout, DateTime checkin)
        {
            List<ViewThongKe> listThongKe = ThongKeDAO.Instance.ThongKeTheoNgay(checkout, checkin);
            dgvReport.DataSource = listThongKe;
            int doanhthu = 0;
            foreach(ViewThongKe item in listThongKe )
            {
                doanhthu += item.Tongtien;
            }
            txtDoanhThu.Text = doanhthu.ToString();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
            LoadThongKe(dateOut.Value, dateIn.Value);
        }
    }
}
