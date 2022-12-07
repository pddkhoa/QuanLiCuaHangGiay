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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        //to show subform form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void fMain_Load(object sender, EventArgs e)
        {
            switch (PhanQuyen.type)
            {
                case 7:
                    btnProduct.Enabled = true;
                    pictureBoxOders.Enabled = true;
                    pictureBoxCustomer.Enabled = true;
                    pictureBoxStaff.Enabled = true;
                    pictureBoxUser.Enabled = true;
                    pictureHome.Enabled = true;
                    break;
                case 5:
                    btnProduct.Enabled = true;
                    pictureBoxOders.Enabled = true;
                    pictureBoxCustomer.Enabled = false;
                    pictureBoxStaff.Enabled = false;
                    pictureBoxUser.Enabled = false;
                    pictureHome.Enabled = false;
                    break;
                case 6:
                    btnProduct.Enabled = true;
                    pictureBoxOders.Enabled = false;
                    pictureBoxCustomer.Enabled = false;
                    pictureBoxStaff.Enabled = false;
                    pictureBoxUser.Enabled = false;
                    pictureHome.Enabled = false;
                    break;
                case 2:
                    btnProduct.Enabled = true;
                    pictureBoxOders.Enabled = true;
                    pictureBoxCustomer.Enabled = true;
                    pictureBoxStaff.Enabled = true;
                    pictureBoxUser.Enabled = true;
                    pictureHome.Enabled = false;
                    break;


            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new fProduct());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
            openChildForm(new fUser());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new fReport());
        }

      

        private void pictureBoxStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new fStaff());
        }

        private void pictureBoxOders_Click(object sender, EventArgs e)
        {
            openChildForm(new fOder());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openChildForm(new fHome());
        }
    }
}
