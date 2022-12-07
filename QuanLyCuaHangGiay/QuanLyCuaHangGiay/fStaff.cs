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

    public partial class fStaff : Form
    {
      
        public fStaff()
        {
            InitializeComponent();
            LoadData();
         
        }
        public void LoadData()
        {
            LoadStaff();
        }
        public void LoadStaff()
        {
            List<NhanVien> listNhanVien = NhanVienDAO.Instance.searchNhanVien(txtSearch.Text);
            dgvStaff.DataSource = listNhanVien;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStaff.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                fAddStaff f = new fAddStaff();
                f.txtsid.Text = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtStName.Text = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
                if(dgvStaff.SelectedRows.Count >0)
                {
                    if (dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString() == "true")
                    {
                        f.cbNam.Checked = true;
                    }
                    else
                    {
                        f.cbNu.Checked = true;
                    }
                }
                f.dtpStBirth.Text = dgvStaff.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.txtStIden.Text = dgvStaff.Rows[e.RowIndex].Cells[6].Value.ToString();
                f.txtStPhone.Text = dgvStaff.Rows[e.RowIndex].Cells[7].Value.ToString();
               
                f.cbCaLam.Text = dgvStaff.Rows[e.RowIndex].Cells[8].Value.ToString();
                f.cbChucVu.Text = dgvStaff.Rows[e.RowIndex].Cells[9].Value.ToString();
                f.txtStAddress.Text = dgvStaff.Rows[e.RowIndex].Cells[10].Value.ToString();
                f.btnSave.Enabled = false;
                f.btnUpdate.Enabled = true;
               
                f.btnClear.Enabled = false;
                f.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc là muốn xoá nhân viên này không?", "Xoá nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    NhanVienDAO.Instance.DeleteNhanVien(int.Parse(dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    MessageBox.Show("Hoàn tất xoá nhân viên ra khỏi hệ thống!");
                }
            }
            LoadStaff();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            fAddStaff f = new fAddStaff();
            f.btnSave.Enabled = true;
            f.btnUpdate.Enabled = false;
            f.ShowDialog();
            LoadStaff();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
