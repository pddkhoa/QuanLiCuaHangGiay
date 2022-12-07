using QuanLiBanGiay.DTO;
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
    public partial class fProduct : Form
    {
        BindingSource sanphamList = new BindingSource();
        public fProduct()
        {
            InitializeComponent();
            LoadData();


        }
        void LoadData()
        {
            LoadProduct();
        }
        public void ShowInforSanPham(int id)
        {
            List<ViewSanPham> listViewSanPham = ViewSanPhamDAO.Instance.GetListViewSanPhamById(id);
            foreach(ViewSanPham item in listViewSanPham)
            { 
                TextId.Text = item.Id.ToString();
                textTenSp.Text = item.Tensp.ToString();
                textMausac.Text = item.Mausac.ToString();
                textGiaBan.Text = item.Giaban.ToString();
                textKho.Text = item.Tenkho.ToString();
                textSize.Text = item.Tensize.ToString();
                textHang.Text = item.Tenhang.ToString();
                textSoLuong.Text = item.Soluong.ToString();
            }    
        }
        public void LoadProduct()
        {
            List<ViewSanPham> listSanPham = ViewSanPhamDAO.Instance.GetListViewSanPham();
            foreach(ViewSanPham item in listSanPham)
            {
                Button btn = new Button() { Width = ViewSanPhamDAO.SanPhamWidth, Height = ViewSanPhamDAO.SanPhamHeight };
                btn.Text = item.Tensp + Environment.NewLine + item.Tensize;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Tensp)
                {
                    case "Giày Jordan":
                        btn.Image = Image.FromFile(@"D:\Đồ Án CNTT\QuanLyCuaHangGiayHieu\QuanLyCuaHangGiay\images\giaythethao2.jpg");
                        break;
                    case "Giày Adidas":
                        btn.Image = Image.FromFile(@"D:\Đồ Án CNTT\QuanLyCuaHangGiayHieu\QuanLyCuaHangGiay\images\giayadidas.jpg");
                        break;
                    case "Giày Vans":
                        btn.Image = Image.FromFile(@"D:\Đồ Án CNTT\QuanLyCuaHangGiayHieu\QuanLyCuaHangGiay\images\giayvans.jpg");
                        break;
                    case "Giày Converse":
                        btn.Image = Image.FromFile(@"D:\Đồ Án CNTT\QuanLyCuaHangGiayHieu\QuanLyCuaHangGiay\images\giayconverse.jpg");
                        break;
                    default:
                        btn.BackColor = Color.Aqua;
                        break;
                }    
                flowSanPham.Controls.Add(btn);
            }    
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as ViewSanPham).Id;
            ShowInforSanPham(id);
            
        }

        
      
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form frm = new fAddProduct();
            frm.ShowDialog();
            LoadProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            Form frm = new fPhieuNhap();
            frm.ShowDialog();
            LoadProduct();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
