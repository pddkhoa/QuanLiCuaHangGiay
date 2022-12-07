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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyCuaHangGiay
{
    public partial class fAddStaff : Form
    {
       
        public fAddStaff()
        {
            InitializeComponent();
            LoadData();

           
        }
        public void LoadPosition()
        {
        }
        public void LoadData()
        {
            LoadChucVu();
            LoadCaLam();
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn thêm nhân viên này không?", "Lưu nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    String hoten = txtStName.Text;
                    bool gioitinh = true;
                   
                    if (cbNam.Checked == true || cbNu.Checked == true)
                    {
                        if
                            (cbNam.Checked == true)
                        {
                            gioitinh = true;
                        }
                        else
                        {

                            gioitinh= false;
                        }
                    }
                    else
                    {
                        
                    }
                    DateTime ngaysinh = dtpStBirth.Value;
                    String cmnd = txtStIden.Text;
                    String sdt = txtStPhone.Text;
                    String diachi = txtStAddress.Text;
                    int calam = (cbCaLam.SelectedItem as CaLam).Id;
                    
                    int type = (cbChucVu.SelectedItem as ChucVu).Id;
                    NhanVienDAO.Instance.InsertNhanVien(hoten, gioitinh, ngaysinh, cmnd, sdt, diachi, calam, type);
                    MessageBox.Show("Hoàn tất thêm nhân viên.");
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
        public void LoadCaLam()
        {
            cbCaLam.Items.Clear();
            List<CaLam> calam = CaLamDAO.Instance.GetListCaLam();
            cbCaLam.DataSource = calam;
            cbCaLam.DisplayMember = "TENCA";
        }
        public void Clear()
        {
            txtStName.Clear();
            cbNam.Checked = false;
            cbNu.Checked = false;
            dtpStBirth.Text = String.Empty;
            txtStIden.Clear();
            txtStPhone.Clear();
            txtStAddress.Clear();
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
                if (MessageBox.Show("Bạn có muốn cập nhật nhân viên này không?", "Lưu nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int sid = Convert.ToInt16(txtsid.Text);
                    String hoten = txtStName.Text;
                    bool gioitinh = true;

                    if (cbNam.Checked == true || cbNu.Checked == true)
                    {
                        if
                            (cbNam.Checked == true)
                        {
                            gioitinh = true;
                        }
                        else
                        {

                            gioitinh = false;
                        }
                    }
                    else
                    {

                    }
                    DateTime ngaysinh = dtpStBirth.Value;
                    String cmnd = txtStIden.Text;
                    String sdt = txtStPhone.Text;
                    String diachi = txtStAddress.Text;
                    int calam = (cbCaLam.SelectedItem as CaLam).Id;

                    int type = (cbChucVu.SelectedItem as ChucVu).Id;
                    NhanVienDAO.Instance.UpdateNhanVien(sid, hoten, gioitinh, ngaysinh, cmnd, sdt, diachi, calam, type);
                    MessageBox.Show("Hoàn tất cập nhật nhân viên.");
                    Clear();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void fAddStaff_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
