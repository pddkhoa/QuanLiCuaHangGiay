using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLiBanGiay.DTO;
using QuanLyCuaHangGiay.DAO;

namespace QuanLyCuaHangGiay
{
    public partial class fAddUser : Form
    {
       
        public fAddUser()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            LoadChucVu();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /* int idnhanvien = (cbNhanVien.SelectedItem as NhanVien).Id;
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
             }*/
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRepass.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn lưu người dùng này không?", "Lưu người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String uN = txtUserName.Text;
                    String ps = txtPass.Text;
                    int type = (cbChucVu.SelectedItem as ChucVu).Id;
                    UserDAO.Instance.InsertUser(uN, ps, type);
                    MessageBox.Show("Hoàn tất thêm người dùng.");
                    Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void LoadChucVu()
        {
            cbChucVu.Items.Clear();
            List<ChucVu> vitri = ChucVuDAO.Instance.GetlistChucVu();
            cbChucVu.DataSource = vitri;
            cbChucVu.DisplayMember = "TENCHUCVU";
        }
        private void fAddUser_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txtUserName.Clear();
           
            txtPass.Clear();
            txtRepass.Clear();
            cbChucVu.Items.Clear();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRepass.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn cập nhật người dùng này không?", "Cập nhật người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int uid = Convert.ToInt16(txtuid.Text);
                    String uN = txtUserName.Text;
                    String ps = txtPass.Text;
                    int type = Convert.ToInt16((cbChucVu.SelectedItem as ChucVu).Id);
                    UserDAO.Instance.UpdateUser(uid, uN, ps, type);
                    MessageBox.Show("Hoàn tất cập nhật người dùng!");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
