using QuanLiBanGiay.DTO;
using QuanLyCuaHangGiay.DAO;
using QuanLyCuaHangGiay.DTO;
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
    public partial class fPhieuNhap : Form
    {
        BindingSource phieuNhaplist = new BindingSource();
        public fPhieuNhap()
        {

            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgvPhieuNhap.DataSource = phieuNhaplist;
            LoadPhieuNhap();
            LoadBangSize();
            LoadNhanVien();
            LoadNhaCungCap();
           
            AddBindingPhieuNhap();
        }
        public void LoadPhieuNhap()
        {
            List<ViewPhieuNhap> listPhieuNhap =  ViewPhieuNhapDAO.Instance.GetlistViewPhieuNhap();
            phieuNhaplist.DataSource = listPhieuNhap;
        }
        public void LoadBangSize()
        {
            List<BangSize> bangSizes = BangSizeDAO.Instance.GetListBangSize();
            cbSize.DataSource = bangSizes;
            cbSize.DisplayMember = "tensize";
        }
        public void LoadSanPham(int id)
        {
            List<SanPham> listSanPham = SanPhamDAO.Instance.GetListSanPhamByIdSize(id);
            cbSanPham.DataSource = listSanPham;
            cbSanPham.DisplayMember = "ten";
        }
        public void LoadNhanVien()
        {
            List<NhanVien> nhanViens = NhanVienDAO.Instance.GetListNhanVien();
            cbNhanVien.DataSource = nhanViens;
            cbNhanVien.DisplayMember = "hoten";
        }
        public void LoadNhaCungCap()
        {
            List<NhaCungCap> nhaCungCaps = NhaCungCapDAO.Instance.GetListNhaCungCap();
            cbNhaCC.DataSource = nhaCungCaps;
            cbNhaCC.DisplayMember = "tenncc";
        }
        public void AddBindingPhieuNhap()
        {
            textID.DataBindings.Add(new Binding("Text", dgvPhieuNhap.DataSource, "id"));
            dateNgayNhap.DataBindings.Add(new Binding("Text", dgvPhieuNhap.DataSource, "ngaynhap"));
            numberSoLuong.DataBindings.Add(new Binding("Text", dgvPhieuNhap.DataSource, "soluong"));
            textGiaNhap.DataBindings.Add(new Binding("Text", dgvPhieuNhap.DataSource, "gianhap"));
            textTongTien.DataBindings.Add(new Binding("Text", dgvPhieuNhap.DataSource, "tongtien"));
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {
            if(dgvPhieuNhap.SelectedCells.Count > 0)
            {
               
                int idNhacc = (int)dgvPhieuNhap.SelectedCells[0].OwningRow.Cells["idncc"].Value;
                int idNhanVien = (int)dgvPhieuNhap.SelectedCells[0].OwningRow.Cells["idnhanvien"].Value;
                int idSanPham = (int)dgvPhieuNhap.SelectedCells[0].OwningRow.Cells["idsanpham"].Value;
                int idSize = (int)dgvPhieuNhap.SelectedCells[0].OwningRow.Cells["idsize"].Value;
                NhaCungCap nhaCungCap = NhaCungCapDAO.Instance.GetNhaCungCapByID(idNhacc);
                NhanVien nhanVien = NhanVienDAO.Instance.GetNhanVienByID(idNhanVien);
                SanPham sanPham = SanPhamDAO.Instance.GetSanPhamByID(idSanPham);
                BangSize bangSize = BangSizeDAO.Instance.GetBangSizeByID(idSize);

                cbNhaCC.SelectedItem = nhaCungCap;
                cbNhanVien.SelectedItem = nhanVien;
                cbSize.SelectedItem = bangSize;
                cbSanPham.SelectedItem = sanPham;
                int indexncc = -1;
                int indexnhanvien = -1;
                int indexsize = -1;
                int indexsanpham = -1;
                int incc = 0;
                int inhanvien = 0;
                int isize = 0;
                int isanpham = 0;
                foreach (NhaCungCap item in cbNhaCC.Items)
                {
                    if (item.Id == nhaCungCap.Id)
                    {
                        indexncc = incc;
                        break;
                    }
                    incc++;
                }
                cbNhaCC.SelectedIndex = indexncc;
                foreach (NhanVien item in cbNhanVien.Items)
                {
                    if (item.Id == nhanVien.Id)
                    {
                        indexnhanvien = inhanvien;
                        break;
                    }
                    inhanvien++;
                }
                cbNhanVien.SelectedIndex = indexnhanvien;
                foreach (SanPham item in cbSanPham.Items)
                {
                    if (item.Id == sanPham.Id)
                    {
                        indexsanpham = isanpham;
                        break;
                    }
                    isanpham++;
                }
                cbSanPham.SelectedIndex = indexsanpham;
                foreach (BangSize item in cbSize.Items)
                {
                    if (item.Id == bangSize.Id)
                    {
                        indexsize = isize;
                        break;
                    }
                    isize++;
                }
                cbSize.SelectedIndex = indexsize;


            }    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int idnhanvien = (cbNhanVien.SelectedItem as NhanVien).Id;
            int idnhacc = (cbNhaCC.SelectedItem as NhaCungCap).Id;
            int idsanpham = (cbSanPham.SelectedItem as SanPham).Id;
            int soluong = (int)numberSoLuong.Value;
            int gianhap = Convert.ToInt32(textGiaNhap.Text);
            if (ViewPhieuNhapDAO.Instance.InsertPhieuNhap(idnhanvien, idnhacc, idsanpham, soluong, gianhap))
            {
                MessageBox.Show("Thêm thành công!");
                LoadPhieuNhap();
            }    
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }    

        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            BangSize selected = cb.SelectedItem as BangSize;
            id = selected.Id;
            LoadSanPham(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            int idnhanvien = (cbNhanVien.SelectedItem as NhanVien).Id;
            int idnhacc = (cbNhaCC.SelectedItem as NhaCungCap).Id;
            int idsanpham = (cbSanPham.SelectedItem as SanPham).Id;
            int soluong = (int)numberSoLuong.Value;
            int gianhap = Convert.ToInt32(textGiaNhap.Text);
            if (ViewPhieuNhapDAO.Instance.UpdatePhieuNhap(id,idnhanvien, idnhacc, idsanpham, soluong, gianhap))
            {
                MessageBox.Show("Sửa thành công!");
                LoadPhieuNhap();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            if(ViewPhieuNhapDAO.Instance.DeletePhieuNhap(id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadPhieuNhap();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");

            }
        }
    }
}
