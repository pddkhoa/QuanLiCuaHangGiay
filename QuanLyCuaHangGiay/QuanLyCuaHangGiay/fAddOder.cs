using QuanLiBanGiay.DTO;
using QuanLyCuaHangGiay.DAO;
using QuanLyCuaHangGiay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QuanLyCuaHangGiay
{
    public partial class fAddOder : Form
    {
        BindingSource giohangList = new BindingSource();

        BindingSource khachHangList = new BindingSource();
        BindingSource sanphamList = new BindingSource();
        public fAddOder()
        {
            InitializeComponent();
            LoadData();
            
            
        }
        public void LoadData()
        {
            dgvCustomer.DataSource = khachHangList;
            
            LoadKhachHang();
            AddBindingKhachHang();
            LoadSize();
           
        }
       
        public void LoadKhachHang()
        {
            List<KhachHang> listKhachHang = KhachHangDAO.Instance.GetListKhachHang();
            khachHangList.DataSource = listKhachHang;

        }
        public void AddBindingKhachHang()
        {
            txtCId.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "id"));
            txtCName.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "hoten"));
           
            
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

       
        public void LoadSize()
        {

            List<BangSize> listBangSize = BangSizeDAO.Instance.GetListBangSize();
            cbSize.DataSource = listBangSize;
            cbSize.DisplayMember = "tensize";
          


        }
      
        public void LoadSanPham(int id)
        {
            List<SanPham> listSanPham = SanPhamDAO.Instance.GetListSanPhamByIdSize(id);
            cbTenSanPham.DataSource = listSanPham;
            cbTenSanPham.DisplayMember = "ten";
            cbMauSac.DataSource = listSanPham;
            cbMauSac.DisplayMember = "mausac";
           
        }
        public void ShowBill(int id)
        {
            listGioHang.Items.Clear();
            int tongTien = 0;

            List<ViewGioHang> listgioHangs = ViewGioHangDAO.Instance.GetListViewGioHangByIDKhachHang(id); 
            foreach(ViewGioHang item in listgioHangs)
            {
                ListViewItem listViewItem = new ListViewItem(item.Tensanpham.ToString());
                listViewItem.SubItems.Add(item.Mausac.ToString());
                listViewItem.SubItems.Add(item.Tensize.ToString());
                listViewItem.SubItems.Add(item.Giaban.ToString());
                listViewItem.SubItems.Add(item.Soluong.ToString());
                listViewItem.SubItems.Add(item.Tongtien.ToString());
                
                tongTien += item.Tongtien;
                listGioHang.Items.Add(listViewItem);
            }
            
            txtTotal.Text = tongTien.ToString();
        }
        #region Events
        private void btnChon_Click(object sender, EventArgs e)
        {

            
           
            string id = txtCId.Text;
            int idHoaDon = HoaDonDAO.Instance.GetUncheckHoaDonByIDKhachHang(Convert.ToInt32(id));
            ShowBill(Convert.ToInt32(id));
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listGioHang_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string id = txtCId.Text;
            int idHoaDon = HoaDonDAO.Instance.GetUncheckHoaDonByIDKhachHang(Convert.ToInt32(id));
            int idSanPham = (cbTenSanPham.SelectedItem as SanPham).Id;
            int soluong = (int)NumberCount.Value;
           try
           {
                if (idHoaDon == -1)
                {
                    HoaDonDAO.Instance.InsertHoaDon(Convert.ToInt32(id));
                    GioHangDAO.Instance.InsertGioHang(HoaDonDAO.Instance.GetHoaDonMax(), idSanPham, soluong);
                }
                else
                {
                    GioHangDAO.Instance.InsertGioHang(idHoaDon, idSanPham, soluong);
                }
               
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR");
            }

            ShowBill(Convert.ToInt32(id));
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string id = txtCId.Text;
            int idHoaDon = HoaDonDAO.Instance.GetUncheckHoaDonByIDKhachHang(Convert.ToInt32(id));
            int tongTien = Convert.ToInt32(txtTotal.Text);
            if(idHoaDon != -1)
            {

                if (MessageBox.Show("Bạn có chắc muốn thanh toán hóa đơn!", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    HoaDonDAO.Instance.checkOut(tongTien,idHoaDon);
                    ShowBill(Convert.ToInt32(txtCId.Text));
                }    
            }    

        }

        
    }
}