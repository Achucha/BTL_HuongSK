namespace BTL
{
    partial class Form1
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
            this.gr_Goods = new System.Windows.Forms.GroupBox();
            this.btn_innhomhang = new System.Windows.Forms.Button();
            this.btn_inds = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tb_loaihang = new System.Windows.Forms.TextBox();
            this.cb_maloaihang = new System.Windows.Forms.ComboBox();
            this.dtp_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_ngaynhap = new System.Windows.Forms.MaskedTextBox();
            this.tb_dvt = new System.Windows.Forms.TextBox();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.tb_tenhang = new System.Windows.Forms.TextBox();
            this.tb_mahang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_index = new System.Windows.Forms.Label();
            this.dgv_dshh = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_dshh = new System.Windows.Forms.GroupBox();
            this.gr_Goods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dshh)).BeginInit();
            this.gb_dshh.SuspendLayout();
            this.SuspendLayout();
            // 
            // gr_Goods
            // 
            this.gr_Goods.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gr_Goods.Controls.Add(this.btn_innhomhang);
            this.gr_Goods.Controls.Add(this.btn_inds);
            this.gr_Goods.Controls.Add(this.btn_thoat);
            this.gr_Goods.Controls.Add(this.btn_timkiem);
            this.gr_Goods.Controls.Add(this.btn_xoa);
            this.gr_Goods.Controls.Add(this.btn_sua);
            this.gr_Goods.Controls.Add(this.btn_them);
            this.gr_Goods.Controls.Add(this.tb_loaihang);
            this.gr_Goods.Controls.Add(this.cb_maloaihang);
            this.gr_Goods.Controls.Add(this.dtp_ngaynhap);
            this.gr_Goods.Controls.Add(this.label4);
            this.gr_Goods.Controls.Add(this.mtb_ngaynhap);
            this.gr_Goods.Controls.Add(this.tb_dvt);
            this.gr_Goods.Controls.Add(this.tb_soluong);
            this.gr_Goods.Controls.Add(this.tb_tenhang);
            this.gr_Goods.Controls.Add(this.tb_mahang);
            this.gr_Goods.Controls.Add(this.label3);
            this.gr_Goods.Controls.Add(this.label2);
            this.gr_Goods.Controls.Add(this.label1);
            this.gr_Goods.Controls.Add(this.lb_Date);
            this.gr_Goods.Controls.Add(this.lb_name);
            this.gr_Goods.Controls.Add(this.lb_index);
            this.gr_Goods.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr_Goods.Location = new System.Drawing.Point(0, 13);
            this.gr_Goods.Name = "gr_Goods";
            this.gr_Goods.Size = new System.Drawing.Size(824, 304);
            this.gr_Goods.TabIndex = 0;
            this.gr_Goods.TabStop = false;
            this.gr_Goods.Text = "Thông tin hàng hóa";
            // 
            // btn_innhomhang
            // 
            this.btn_innhomhang.BackColor = System.Drawing.SystemColors.Control;
            this.btn_innhomhang.Location = new System.Drawing.Point(605, 218);
            this.btn_innhomhang.Name = "btn_innhomhang";
            this.btn_innhomhang.Size = new System.Drawing.Size(118, 33);
            this.btn_innhomhang.TabIndex = 25;
            this.btn_innhomhang.Text = "In nhóm hàng";
            this.btn_innhomhang.UseVisualStyleBackColor = false;
            this.btn_innhomhang.Click += new System.EventHandler(this.btn_innhomhang_Click);
            // 
            // btn_inds
            // 
            this.btn_inds.BackColor = System.Drawing.SystemColors.Control;
            this.btn_inds.Location = new System.Drawing.Point(605, 177);
            this.btn_inds.Name = "btn_inds";
            this.btn_inds.Size = new System.Drawing.Size(118, 33);
            this.btn_inds.TabIndex = 24;
            this.btn_inds.Text = "In DSHH";
            this.btn_inds.UseVisualStyleBackColor = false;
            this.btn_inds.Click += new System.EventHandler(this.btn_inds_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_thoat.Location = new System.Drawing.Point(605, 257);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(118, 33);
            this.btn_thoat.TabIndex = 23;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_timkiem.Location = new System.Drawing.Point(605, 139);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(118, 33);
            this.btn_timkiem.TabIndex = 22;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Control;
            this.btn_xoa.Location = new System.Drawing.Point(605, 99);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(118, 33);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa bỏ";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sua.Location = new System.Drawing.Point(605, 61);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(118, 33);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Chỉnh sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Control;
            this.btn_them.Location = new System.Drawing.Point(605, 25);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(118, 33);
            this.btn_them.TabIndex = 19;
            this.btn_them.Text = "Thêm mới";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tb_loaihang
            // 
            this.tb_loaihang.Location = new System.Drawing.Point(140, 265);
            this.tb_loaihang.Name = "tb_loaihang";
            this.tb_loaihang.Size = new System.Drawing.Size(267, 27);
            this.tb_loaihang.TabIndex = 18;
            // 
            // cb_maloaihang
            // 
            this.cb_maloaihang.FormattingEnabled = true;
            this.cb_maloaihang.Location = new System.Drawing.Point(140, 225);
            this.cb_maloaihang.Name = "cb_maloaihang";
            this.cb_maloaihang.Size = new System.Drawing.Size(267, 27);
            this.cb_maloaihang.TabIndex = 17;
            // 
            // dtp_ngaynhap
            // 
            this.dtp_ngaynhap.Location = new System.Drawing.Point(381, 103);
            this.dtp_ngaynhap.Name = "dtp_ngaynhap";
            this.dtp_ngaynhap.Size = new System.Drawing.Size(26, 27);
            this.dtp_ngaynhap.TabIndex = 16;
            this.dtp_ngaynhap.ValueChanged += new System.EventHandler(this.dtp_ngaynhap_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Loại hàng:";
            // 
            // mtb_ngaynhap
            // 
            this.mtb_ngaynhap.Location = new System.Drawing.Point(140, 103);
            this.mtb_ngaynhap.Mask = "00/00/0000";
            this.mtb_ngaynhap.Name = "mtb_ngaynhap";
            this.mtb_ngaynhap.Size = new System.Drawing.Size(267, 27);
            this.mtb_ngaynhap.TabIndex = 14;
            this.mtb_ngaynhap.ValidatingType = typeof(System.DateTime);
            this.mtb_ngaynhap.Validating += new System.ComponentModel.CancelEventHandler(this.mtb_ngaynhap_Validating);
            // 
            // tb_dvt
            // 
            this.tb_dvt.Location = new System.Drawing.Point(140, 181);
            this.tb_dvt.Name = "tb_dvt";
            this.tb_dvt.Size = new System.Drawing.Size(267, 27);
            this.tb_dvt.TabIndex = 12;
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(140, 143);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(267, 27);
            this.tb_soluong.TabIndex = 11;
            this.tb_soluong.TextChanged += new System.EventHandler(this.tb_soluong_TextChanged);
            // 
            // tb_tenhang
            // 
            this.tb_tenhang.Location = new System.Drawing.Point(140, 68);
            this.tb_tenhang.Name = "tb_tenhang";
            this.tb_tenhang.Size = new System.Drawing.Size(267, 27);
            this.tb_tenhang.TabIndex = 9;
            this.tb_tenhang.TextChanged += new System.EventHandler(this.tb_tenhang_TextChanged);
            // 
            // tb_mahang
            // 
            this.tb_mahang.Location = new System.Drawing.Point(140, 29);
            this.tb_mahang.Name = "tb_mahang";
            this.tb_mahang.Size = new System.Drawing.Size(267, 27);
            this.tb_mahang.TabIndex = 8;
            this.tb_mahang.TextChanged += new System.EventHandler(this.tb_mahang_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã loại hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đơn vị tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lượng:";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Location = new System.Drawing.Point(23, 107);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(93, 19);
            this.lb_Date.TabIndex = 2;
            this.lb_Date.Text = "Ngày nhập:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(23, 68);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(82, 19);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Tên hàng:";
            // 
            // lb_index
            // 
            this.lb_index.AutoSize = true;
            this.lb_index.Location = new System.Drawing.Point(23, 32);
            this.lb_index.Name = "lb_index";
            this.lb_index.Size = new System.Drawing.Size(77, 19);
            this.lb_index.TabIndex = 0;
            this.lb_index.Text = "Mã hàng:";
            // 
            // dgv_dshh
            // 
            this.dgv_dshh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dshh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.NgayNhap,
            this.SoLuong,
            this.DVT2,
            this.MaLoaiHang,
            this.TenLoaiHang});
            this.dgv_dshh.Location = new System.Drawing.Point(0, 21);
            this.dgv_dshh.Name = "dgv_dshh";
            this.dgv_dshh.RowHeadersWidth = 51;
            this.dgv_dshh.RowTemplate.Height = 24;
            this.dgv_dshh.Size = new System.Drawing.Size(824, 251);
            this.dgv_dshh.TabIndex = 7;
            this.dgv_dshh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dshh_CellClick);
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            this.MaHang.Width = 125;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 125;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DVT2
            // 
            this.DVT2.DataPropertyName = "DVT2";
            this.DVT2.HeaderText = "Đơn vị tính";
            this.DVT2.MinimumWidth = 6;
            this.DVT2.Name = "DVT2";
            this.DVT2.Width = 125;
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.DataPropertyName = "MaLoaiHang";
            this.MaLoaiHang.HeaderText = "Mã loại hàng";
            this.MaLoaiHang.MinimumWidth = 6;
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.Width = 125;
            // 
            // TenLoaiHang
            // 
            this.TenLoaiHang.DataPropertyName = "TenLoaiHang";
            this.TenLoaiHang.HeaderText = "Loại hàng";
            this.TenLoaiHang.MinimumWidth = 6;
            this.TenLoaiHang.Name = "TenLoaiHang";
            this.TenLoaiHang.Width = 125;
            // 
            // gb_dshh
            // 
            this.gb_dshh.Controls.Add(this.dgv_dshh);
            this.gb_dshh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_dshh.Location = new System.Drawing.Point(0, 341);
            this.gb_dshh.Name = "gb_dshh";
            this.gb_dshh.Size = new System.Drawing.Size(824, 272);
            this.gb_dshh.TabIndex = 8;
            this.gb_dshh.TabStop = false;
            this.gb_dshh.Text = "Danh sách hàng hóa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 618);
            this.Controls.Add(this.gb_dshh);
            this.Controls.Add(this.gr_Goods);
            this.Name = "Form1";
            this.Text = "Mặt hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gr_Goods.ResumeLayout(false);
            this.gr_Goods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dshh)).EndInit();
            this.gb_dshh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_Goods;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_dvt;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.TextBox tb_tenhang;
        private System.Windows.Forms.TextBox tb_mahang;
        private System.Windows.Forms.DataGridView dgv_dshh;
        private System.Windows.Forms.MaskedTextBox mtb_ngaynhap;
        private System.Windows.Forms.GroupBox gb_dshh;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tb_loaihang;
        private System.Windows.Forms.ComboBox cb_maloaihang;
        private System.Windows.Forms.DateTimePicker dtp_ngaynhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_innhomhang;
        private System.Windows.Forms.Button btn_inds;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiHang;
    }
}

