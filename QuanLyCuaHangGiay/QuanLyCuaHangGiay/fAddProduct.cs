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
using System.Xml.Linq;

namespace QuanLyCuaHangGiay
{
    public partial class fAddProduct : Form
    {
        BindingSource productList = new BindingSource();
        public fAddProduct()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgvProduct.DataSource = productList;
            LoadSize();
            LoadHangSX();
            LoadKho();
            LoadProduct();
            AddSanPhamBinding();
        }
        public void LoadKho()
        {
            List<Kho> listKho = KhoDAO.Instance.GetListKho();
            cbKho.DataSource = listKho;
            cbKho.DisplayMember = "tenkho";
        }
        public void LoadSize()
        {

            List<BangSize> listBangSize = BangSizeDAO.Instance.GetListBangSize();
            cbBangSize.DataSource = listBangSize;
            cbBangSize.DisplayMember = "tensize";
            

        }
        public void LoadHangSX()
        {
            List<HangSanXuat> listHangSanXuat = HangSanXuatDAO.Instance.GetListHangSanXuat();
            cbHang.DataSource = listHangSanXuat;
            cbHang.DisplayMember = "tenhang";
            

        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
       
        public void LoadProduct()
        {
            List<SanPham> listSanPham = SanPhamDAO.Instance.GetListSanPham();
            productList.DataSource = listSanPham;
            
            

        }
        public void AddSanPhamBinding()
        {
            textId.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "id"));
            textTen.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "ten"));
            txtDes.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "mausac"));
            txtPrice.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "giaban"));
            textSoluong.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "soluong"));

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string ten = textTen.Text;
            int giaban = Convert.ToInt32(txtPrice.Text);
            string mausac = txtDes.Text;
            int idsize = (cbBangSize.SelectedItem as BangSize).Id;
            int idhangsx = (cbHang.SelectedItem as HangSanXuat).Id;
            int idkho = (cbKho.SelectedItem as Kho).Id;
            int soluong = Convert.ToInt32(textSoluong.Text);
            if (SanPhamDAO.Instance.InsertSanPham(ten,mausac,idsize,giaban,idhangsx,idkho,soluong))
            {
                MessageBox.Show("Thêm thành công!");
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
            
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);
            string ten = textTen.Text;
            int giaban = Convert.ToInt32(txtPrice.Text);
            string mausac = txtDes.Text;
            int idsize = (cbBangSize.SelectedItem as BangSize).Id;
            int idhangsx = (cbHang.SelectedItem as HangSanXuat).Id;
            int idkho = (cbKho.SelectedItem as Kho).Id;
            int soluong = Convert.ToInt32(textSoluong.Text);
            if (SanPhamDAO.Instance.UpdateSanPham(id,ten,mausac,idsize,giaban,idhangsx,idkho,soluong))
            {
                MessageBox.Show("Sửa thành công!");
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }

        }
       

        private void fAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedCells.Count > 0)
            {
                int idsize = (int)dgvProduct.SelectedCells[0].OwningRow.Cells["idsize"].Value;
                int idhangsx = (int)dgvProduct.SelectedCells[0].OwningRow.Cells["idhangsx"].Value;
                int idkho = (int)dgvProduct.SelectedCells[0].OwningRow.Cells["idkho"].Value;
                BangSize bangSize = BangSizeDAO.Instance.GetBangSizeByID(idsize);
                HangSanXuat hangSanXuat = HangSanXuatDAO.Instance.GetHangSanXuatByID(idhangsx);
                Kho kho = KhoDAO.Instance.GetKhoByID(idkho);
                cbBangSize.SelectedItem = bangSize;
                cbHang.SelectedItem = hangSanXuat;
                cbKho.SelectedItem = kho;
                int indexsize = -1;
                int isize = 0;
                foreach(BangSize item in cbBangSize.Items)
                {
                    if(item.Id == bangSize.Id)
                    {
                        indexsize = isize;
                        break;
                    }
                    isize++;
                }
                
                cbBangSize.SelectedIndex = indexsize;
                int indexhang = -1;
                int ihang = 0;
                foreach (HangSanXuat item in cbHang.Items)
                {
                    if (item.Id == hangSanXuat.Id)
                    {
                        indexhang = ihang;
                        break;
                    }
                    ihang++;
                }
                cbHang.SelectedIndex = indexhang;
                int indexkho = -1;
                int ikho = 0;
                foreach (Kho item in cbKho.Items)
                {
                    if (item.Id == kho.Id)
                    {
                        indexkho = ikho;
                        break;
                    }
                    ikho++;
                }
                cbKho.SelectedIndex = indexkho;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);
            if(SanPhamDAO.Instance.DeleteSanPham(id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadProduct();
            }    
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }    
        }
    }
}
