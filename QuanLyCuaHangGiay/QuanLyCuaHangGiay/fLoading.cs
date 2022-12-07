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
    public partial class fLoading : Form
    {
        public fLoading()
        {
            InitializeComponent();
            timer1.Start();
        }
        int startPoint = 0;
       
        private void fLoading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startPoint += 2;
            progressBar1.Value = startPoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                fLogin f = new fLogin();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
