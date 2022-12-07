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
    public partial class fHome : Form
    {
        BindingSource sizeList = new BindingSource();
        BindingSource hangList = new BindingSource();
        BindingSource khoList = new BindingSource();
        BindingSource chucVuList = new BindingSource();
        BindingSource calamList = new BindingSource();
        public fHome()
        {

            InitializeComponent();
            vLoad();
        }
        void vLoad()
        {
            dgvCaLam.DataSource = calamList;
            dgvChucVu.DataSource = chucVuList;
            
            dgvHangsx.DataSource = hangList;
            dgvKho.DataSource = khoList;
           
            LoadHangSanXuat();
            LoadKho();
            LoadChucVu();
            LoadCaLam();
            AddCaLamBinding();
            AddChucVuBinding();
            
            AddHangSanXuatBinding();
            AddKhoBinding();
        }
        void LoadCaLam()
        {
            List<CaLam> listCaLam = CaLamDAO.Instance.GetListCaLam();
            calamList.DataSource = listCaLam;
        }
        void AddCaLamBinding()
        {
            textIDCaLam.DataBindings.Add(new Binding("Text", dgvCaLam.DataSource, "id"));
            textTenCa.DataBindings.Add(new Binding("Text", dgvCaLam.DataSource, "tenca"));
            textTimeCaLam.DataBindings.Add(new Binding("Text", dgvCaLam.DataSource, "thoigian"));
        }
        void LoadChucVu()
        {
            List<ChucVu> listChucVu = ChucVuDAO.Instance.GetlistChucVu();
            chucVuList.DataSource = listChucVu;
        }
        
        void AddChucVuBinding()
        {
            textIDChucVu.DataBindings.Add(new Binding("Text", dgvChucVu.DataSource, "id"));
            textTenChucVU.DataBindings.Add(new Binding("Text", dgvChucVu.DataSource, "tenchucvu"));
            textLuong.DataBindings.Add(new Binding("Text", dgvChucVu.DataSource, "luong"));
        }
        void AddKhoBinding()
        {
            textIDkho.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "id"));
            textTenKho.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "tenkho"));
            textDiachiKho.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "diachi"));

        }
        
        void AddHangSanXuatBinding()
        {
            textIDHang.DataBindings.Add(new Binding("Text", dgvHangsx.DataSource, "id"));
            textTenHang.DataBindings.Add(new Binding("Text", dgvHangsx.DataSource, "tenhang"));
            textdiachiHang.DataBindings.Add(new Binding("Text", dgvHangsx.DataSource, "diachi"));
        }
        void LoadHangSanXuat()
        {
            List<HangSanXuat> listHangSanXuat = HangSanXuatDAO.Instance.GetListHangSanXuat();
            hangList.DataSource = listHangSanXuat;
        }
        void LoadKho()
        {
            List<Kho> listKho = KhoDAO.Instance.GetListKho();
            khoList.DataSource = listKho;
        }
      
        

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textIDHang.Text);
            if (HangSanXuatDAO.Instance.DeleteHangSanXuat(id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadHangSanXuat();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnAddHang_Click(object sender, EventArgs e)
        {

            string tenhang = textTenHang.Text;
            string diachi = textdiachiHang.Text;
            if (HangSanXuatDAO.Instance.InsertHangSanXuat(tenhang, diachi))
            {
                MessageBox.Show("Thêm thành công!");
                LoadHangSanXuat();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnUpHang_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textIDHang.Text);
            string tenhang = textTenHang.Text;
            string diachi = textdiachiHang.Text;
            if (HangSanXuatDAO.Instance.UpdateHangSanXuat(id ,tenhang ,diachi))
            {
                MessageBox.Show("Sửa thành công!");
                LoadHangSanXuat();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnAddKho_Click(object sender, EventArgs e)
        {
          
            string tenkho = textTenKho.Text;
            string diachi = textDiachiKho.Text;
            if (KhoDAO.Instance.InsertKho(tenkho, diachi))
            {
                MessageBox.Show("Thêm thành công!");
                LoadKho();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnUpKho_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textIDkho.Text);
            string tenkho = textTenKho.Text;
            string diachi = textDiachiKho.Text;
            if (KhoDAO.Instance.UpdateKho(id, tenkho, diachi))
            {
                MessageBox.Show("Sửa thành công!");
                LoadKho();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

      
       

        private void btnXoaKho_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textIDkho.Text);
            if(KhoDAO.Instance.DeleteKho(id))
            {
                MessageBox.Show("Xóa thành công !");
                LoadKho();
            }    
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }    
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

      

        private void btnAddChucVu_Click(object sender, EventArgs e)
        {
            string tenchucvu = textTenChucVU.Text;
            int luong = Convert.ToInt32(textLuong.Text);
            if(ChucVuDAO.Instance.InsertChucVu(tenchucvu,luong))
            {
                MessageBox.Show("Thêm thành công!");
                LoadChucVu();
            }    
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }    
        }

        private void btnUpChucVu_Click(object sender, EventArgs e)
        {
            string tenchucvu = textTenChucVU.Text;
            int luong = Convert.ToInt32(textLuong.Text);
            int id = Convert.ToInt32(textIDChucVu.Text);
            if (ChucVuDAO.Instance.UpdateChucVu(tenchucvu, luong,id))
            {
                MessageBox.Show("Sửa thành công!");
                LoadChucVu();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnDelChucVu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textIDChucVu.Text);
            if(ChucVuDAO.Instance.DeleteChucVu(id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadChucVu();
            }    
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }    
        }

        private void btnAddCaLam_Click(object sender, EventArgs e)
        {
            string tenca = textTenCa.Text;
            int thoigian = Convert.ToInt32(textTimeCaLam.Text);
            if (CaLamDAO.Instance.InsertCaLam(tenca, thoigian))
            {
                MessageBox.Show("Thêm thành công!");
                LoadCaLam();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnUpCaLam_Click(object sender, EventArgs e)
        {
            string tenca = textTenCa.Text;
            int thoigian = Convert.ToInt32(textTimeCaLam.Text);
            int id = Convert.ToInt32(textIDCaLam.Text);
            if (CaLamDAO.Instance.UpdateCaLam(tenca, thoigian, id))
            {
                MessageBox.Show("Sửa thành công!");
                LoadCaLam();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnDelCaLam_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textIDCaLam.Text);
            if (CaLamDAO.Instance.DeleteCaLam(id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadCaLam();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
    }
}
