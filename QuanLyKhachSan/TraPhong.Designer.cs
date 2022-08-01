namespace QuanLyKhachSan
{
    partial class TraPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.dataGridView_ThuePhong = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bang = new System.Windows.Forms.GroupBox();
            this.dataGridView_GiaPhong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.txtNgayDen = new System.Windows.Forms.TextBox();
            this.txtNgayDi = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtSoNgayO = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMATP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThuePhong)).BeginInit();
            this.Bang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GiaPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm Khách hàng thuê phòng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(401, 35);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(258, 22);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // dataGridView_ThuePhong
            // 
            this.dataGridView_ThuePhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView_ThuePhong.Location = new System.Drawing.Point(45, 87);
            this.dataGridView_ThuePhong.Name = "dataGridView_ThuePhong";
            this.dataGridView_ThuePhong.RowTemplate.Height = 24;
            this.dataGridView_ThuePhong.Size = new System.Drawing.Size(1223, 150);
            this.dataGridView_ThuePhong.TabIndex = 2;
            this.dataGridView_ThuePhong.SelectionChanged += new System.EventHandler(this.dataGridView_ThuePhong_SelectionChanged);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MATP";
            this.Column3.HeaderText = "Mã Thuê Phòng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MANV";
            this.Column4.HeaderText = "Mã Nhân Viên";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MAKH";
            this.Column5.HeaderText = "Mã Khách Hàng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NGAYDEN";
            this.Column6.HeaderText = "Ngày Đến";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgayDi";
            this.Column7.HeaderText = "Ngày Đi";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaPH";
            this.Column8.HeaderText = "Mã Phòng";
            this.Column8.Name = "Column8";
            // 
            // Bang
            // 
            this.Bang.Controls.Add(this.dataGridView_GiaPhong);
            this.Bang.Location = new System.Drawing.Point(45, 296);
            this.Bang.Name = "Bang";
            this.Bang.Size = new System.Drawing.Size(427, 319);
            this.Bang.TabIndex = 3;
            this.Bang.TabStop = false;
            this.Bang.Text = "Bảng Giá Thuê Phòng";
            // 
            // dataGridView_GiaPhong
            // 
            this.dataGridView_GiaPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_GiaPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GiaPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_GiaPhong.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_GiaPhong.Name = "dataGridView_GiaPhong";
            this.dataGridView_GiaPhong.ReadOnly = true;
            this.dataGridView_GiaPhong.RowTemplate.Height = 24;
            this.dataGridView_GiaPhong.Size = new System.Drawing.Size(415, 292);
            this.dataGridView_GiaPhong.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LoaiPH";
            this.Column1.HeaderText = "Loại Phòng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GiaPH";
            this.Column2.HeaderText = "Giá Phòng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Đi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loại Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số Ngày ở";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 607);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giá phòng(Ngày)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 685);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tổng Tiền";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 797);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Tạo Hóa Đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 804);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "ReLoad";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtNameKH
            // 
            this.txtNameKH.Enabled = false;
            this.txtNameKH.Location = new System.Drawing.Point(790, 263);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.Size = new System.Drawing.Size(208, 22);
            this.txtNameKH.TabIndex = 14;
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Enabled = false;
            this.txtNgayDen.Location = new System.Drawing.Point(790, 352);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(208, 22);
            this.txtNgayDen.TabIndex = 15;
            // 
            // txtNgayDi
            // 
            this.txtNgayDi.Enabled = false;
            this.txtNgayDi.Location = new System.Drawing.Point(790, 400);
            this.txtNgayDi.Name = "txtNgayDi";
            this.txtNgayDi.Size = new System.Drawing.Size(208, 22);
            this.txtNgayDi.TabIndex = 16;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Enabled = false;
            this.txtLoaiPhong.Location = new System.Drawing.Point(790, 449);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(208, 22);
            this.txtLoaiPhong.TabIndex = 17;
            // 
            // txtSoNgayO
            // 
            this.txtSoNgayO.Enabled = false;
            this.txtSoNgayO.Location = new System.Drawing.Point(790, 525);
            this.txtSoNgayO.Name = "txtSoNgayO";
            this.txtSoNgayO.Size = new System.Drawing.Size(208, 22);
            this.txtSoNgayO.TabIndex = 18;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Enabled = false;
            this.txtGiaPhong.Location = new System.Drawing.Point(790, 602);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(208, 22);
            this.txtGiaPhong.TabIndex = 19;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(790, 680);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(208, 22);
            this.txtTongTien.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(563, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(790, 305);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(208, 22);
            this.txtMaNV.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(940, 792);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 48);
            this.button4.TabIndex = 23;
            this.button4.Text = "Xem Hóa Đơn";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 752);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mã Thuê Phòng";
            // 
            // txtMATP
            // 
            this.txtMATP.Enabled = false;
            this.txtMATP.Location = new System.Drawing.Point(790, 752);
            this.txtMATP.Name = "txtMATP";
            this.txtMATP.Size = new System.Drawing.Size(208, 22);
            this.txtMATP.TabIndex = 25;
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 875);
            this.Controls.Add(this.txtMATP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtGiaPhong);
            this.Controls.Add(this.txtSoNgayO);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.txtNgayDi);
            this.Controls.Add(this.txtNgayDen);
            this.Controls.Add(this.txtNameKH);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bang);
            this.Controls.Add(this.dataGridView_ThuePhong);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label1);
            this.Name = "TraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraPhong";
            this.Load += new System.EventHandler(this.TraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThuePhong)).EndInit();
            this.Bang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GiaPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DataGridView dataGridView_ThuePhong;
        private System.Windows.Forms.GroupBox Bang;
        private System.Windows.Forms.DataGridView dataGridView_GiaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNameKH;
        private System.Windows.Forms.TextBox txtNgayDen;
        private System.Windows.Forms.TextBox txtNgayDi;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtSoNgayO;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMATP;
    }
}