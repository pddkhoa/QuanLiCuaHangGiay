using QuanLiBanGiay.DTO;
using QuanLyCuaHangGiay.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiay
{
    public partial class fAddCustomer : Form
    {
        BindingSource khachhangList = new BindingSource();
        public fAddCustomer()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgvKhachHang.DataSource = khachhangList;
            LoadKhachHang();
            AddBindingKhachHang();
        }
        public void LoadKhachHang()
        {
            List<KhachHang> khachHangs = KhachHangDAO.Instance.GetListKhachHang();
            khachhangList.DataSource = khachHangs;
        }
        void AddBindingKhachHang()
        {
            textId.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "id"));
            textHoten.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "hoten"));
            ngaysinhKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "ngaysinh"));
            txtSdt.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "sdt"));
            txtDiachi.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "diachi"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string hoten = textHoten.Text;
            DateTime ngaysinh = ngaysinhKH.Value;
            string sdt = txtSdt.Text;
            string diachi = txtDiachi.Text;

            if (KhachHangDAO.Instance.InsertKhachHang(hoten, ngaysinh, sdt, diachi))
            {
                MessageBox.Show("Thêm thành công!");
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);
            string hoten = textHoten.Text;
            DateTime ngaysinh = ngaysinhKH.Value;
            string sdt = txtSdt.Text;
            string diachi = txtDiachi.Text;

            if (KhachHangDAO.Instance.UpdateKhachHang(id, hoten, ngaysinh, sdt, diachi))
            {
                MessageBox.Show("Sửa thành công!");
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);
            if (KhachHangDAO.Instance.DeleteKhachHang(id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void fAddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
