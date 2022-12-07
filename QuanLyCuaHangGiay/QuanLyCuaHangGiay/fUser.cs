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
using QuanLyCuaHangGiay.DTO;
using System.Security.Cryptography;

namespace QuanLyCuaHangGiay
{
    public partial class fUser : Form
    {

        public fUser()
        {
            InitializeComponent();
            LoadData();
          
        }
        public void LoadData()
        {
            LoadUser();
        }
        public void LoadUser()
        {
            List<User> listUser = UserDAO.Instance.GetListUser();
            dgvUser.DataSource = listUser;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            fAddUser f = new fAddUser();
            f.btnSave.Enabled = true;
            f.btnUpdate.Enabled = false;
            f.ShowDialog();
            LoadUser();

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                fAddUser f = new fAddUser();
                f.txtuid.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtUserName.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
               
                f.txtPass.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.cbChucVu.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();

                f.btnSave.Enabled = false;
                f.btnUpdate.Enabled = true;
                f.txtUserName.Enabled = false;
                f.btnClear.Enabled = false;
                f.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc là muốn xoá người dùng này không?", "Xoá người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UserDAO.Instance.DeleteUser(int.Parse(dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    MessageBox.Show("Hoàn tất xoá người dùng ra khỏi hệ thống!");
                }
            }
            LoadUser();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
