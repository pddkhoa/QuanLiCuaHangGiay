using QuanLiBanGiay.DTO;
using QuanLyCuaHangGiay.DAO;
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
    public partial class fOder : Form
    {
       
        public fOder()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            LoadOrder();
            LoadKhachHang();
        }
        public void LoadOrder()
        {
            DataProvider provider = new DataProvider();
            string query = "SELECT HOA_DON.ID AS IDHOADON,HOA_DON.NGAYLAPHD,KHACH_HANG.HOTEN, HOA_DON.TONGTIEN FROM HOA_DON INNER JOIN KHACH_HANG ON HOA_DON.idKhachHang = KHACH_HANG.ID WHERE HOA_DON.TRANGTHAI = 1";
            dgvOrder.DataSource = provider.ExecuteQuery(query);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            fAddOder f = new fAddOder();
            f.ShowDialog();
            LoadOrder();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadKhachHang()
        {
            List<KhachHang> khachHangs = KhachHangDAO.Instance.GetListKhachHang();
            dgvKhachHang.DataSource = khachHangs;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frm = new fAddCustomer();
            frm.ShowDialog();
            LoadKhachHang();
        }
    }
}
