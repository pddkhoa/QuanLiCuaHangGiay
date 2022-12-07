namespace QuanLyCuaHangGiay
{
    partial class fProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextId = new System.Windows.Forms.TextBox();
            this.textSize = new System.Windows.Forms.TextBox();
            this.textKho = new System.Windows.Forms.TextBox();
            this.textHang = new System.Windows.Forms.TextBox();
            this.textGiaBan = new System.Windows.Forms.TextBox();
            this.textSoLuong = new System.Windows.Forms.TextBox();
            this.textMausac = new System.Windows.Forms.TextBox();
            this.textTenSp = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.btnNhapHang);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 50);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnNhapHang.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnNhapHang.Location = new System.Drawing.Point(841, 6);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(128, 39);
            this.btnNhapHang.TabIndex = 28;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnReload.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Transparent;
            this.btnReload.Location = new System.Drawing.Point(258, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(128, 39);
            this.btnReload.TabIndex = 27;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(202, 6);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(38, 35);
            this.btnAddProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin giày";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowSanPham
            // 
            this.flowSanPham.AutoScroll = true;
            this.flowSanPham.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowSanPham.Location = new System.Drawing.Point(0, 0);
            this.flowSanPham.Name = "flowSanPham";
            this.flowSanPham.Size = new System.Drawing.Size(569, 451);
            this.flowSanPham.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TextId);
            this.panel2.Controls.Add(this.textSize);
            this.panel2.Controls.Add(this.textKho);
            this.panel2.Controls.Add(this.textHang);
            this.panel2.Controls.Add(this.textGiaBan);
            this.panel2.Controls.Add(this.textSoLuong);
            this.panel2.Controls.Add(this.textMausac);
            this.panel2.Controls.Add(this.textTenSp);
            this.panel2.Location = new System.Drawing.Point(566, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 405);
            this.panel2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Kho";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hãng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Màu sắc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // TextId
            // 
            this.TextId.Location = new System.Drawing.Point(124, 6);
            this.TextId.Multiline = true;
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(84, 28);
            this.TextId.TabIndex = 7;
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(277, 166);
            this.textSize.Multiline = true;
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(84, 35);
            this.textSize.TabIndex = 6;
            // 
            // textKho
            // 
            this.textKho.Location = new System.Drawing.Point(124, 355);
            this.textKho.Multiline = true;
            this.textKho.Name = "textKho";
            this.textKho.Size = new System.Drawing.Size(237, 31);
            this.textKho.TabIndex = 5;
            // 
            // textHang
            // 
            this.textHang.Location = new System.Drawing.Point(124, 292);
            this.textHang.Multiline = true;
            this.textHang.Name = "textHang";
            this.textHang.Size = new System.Drawing.Size(237, 34);
            this.textHang.TabIndex = 4;
            // 
            // textGiaBan
            // 
            this.textGiaBan.Location = new System.Drawing.Point(124, 228);
            this.textGiaBan.Multiline = true;
            this.textGiaBan.Name = "textGiaBan";
            this.textGiaBan.Size = new System.Drawing.Size(237, 34);
            this.textGiaBan.TabIndex = 3;
            // 
            // textSoLuong
            // 
            this.textSoLuong.Location = new System.Drawing.Point(124, 166);
            this.textSoLuong.Multiline = true;
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(84, 35);
            this.textSoLuong.TabIndex = 2;
            // 
            // textMausac
            // 
            this.textMausac.Location = new System.Drawing.Point(124, 110);
            this.textMausac.Multiline = true;
            this.textMausac.Name = "textMausac";
            this.textMausac.Size = new System.Drawing.Size(237, 32);
            this.textMausac.TabIndex = 1;
            // 
            // textTenSp
            // 
            this.textTenSp.Location = new System.Drawing.Point(124, 55);
            this.textTenSp.Multiline = true;
            this.textTenSp.Name = "textTenSp";
            this.textTenSp.Size = new System.Drawing.Size(237, 32);
            this.textTenSp.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(566, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 49);
            this.panel3.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(114, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Thông tin sản phẩm";
            // 
            // fProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowSanPham);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fProduct";
            this.Text = "fProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnAddProduct;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnReload;
        public System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.FlowLayoutPanel flowSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textKho;
        private System.Windows.Forms.TextBox textHang;
        private System.Windows.Forms.TextBox textGiaBan;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.TextBox textMausac;
        private System.Windows.Forms.TextBox textTenSp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextId;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}