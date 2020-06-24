namespace WindowsFormsApp1.Controller
{
    partial class FormTimNhanVien
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
            this.dtgr = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TienLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MaPB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtime_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgr
            // 
            this.dtgr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgr.Location = new System.Drawing.Point(0, 0);
            this.dtgr.Name = "dtgr";
            this.dtgr.RowTemplate.Height = 24;
            this.dtgr.Size = new System.Drawing.Size(800, 243);
            this.dtgr.TabIndex = 0;
            this.dtgr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgr_CellContentClick);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(103, 443);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(133, 22);
            this.txt_TimKiem.TabIndex = 3;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tìm Mã:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TienLuong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_MaPB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_GioiTinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtime_NgaySinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_TenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txt_TienLuong
            // 
            this.txt_TienLuong.Location = new System.Drawing.Point(458, 71);
            this.txt_TienLuong.Name = "txt_TienLuong";
            this.txt_TienLuong.Size = new System.Drawing.Size(150, 22);
            this.txt_TienLuong.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Lương";
            // 
            // txt_MaPB
            // 
            this.txt_MaPB.Location = new System.Drawing.Point(458, 128);
            this.txt_MaPB.Name = "txt_MaPB";
            this.txt_MaPB.Size = new System.Drawing.Size(150, 22);
            this.txt_MaPB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "MaPB";
            // 
            // cb_GioiTinh
            // 
            this.cb_GioiTinh.FormattingEnabled = true;
            this.cb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GioiTinh.Location = new System.Drawing.Point(481, 23);
            this.cb_GioiTinh.Name = "cb_GioiTinh";
            this.cb_GioiTinh.Size = new System.Drawing.Size(117, 24);
            this.cb_GioiTinh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới Tính";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtime_NgaySinh
            // 
            this.dtime_NgaySinh.CustomFormat = "yyyy/MM/dd";
            this.dtime_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime_NgaySinh.Location = new System.Drawing.Point(111, 110);
            this.dtime_NgaySinh.Name = "dtime_NgaySinh";
            this.dtime_NgaySinh.Size = new System.Drawing.Size(113, 22);
            this.dtime_NgaySinh.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Sinh";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(111, 67);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(188, 22);
            this.txt_TenNV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NV";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(111, 23);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(188, 22);
            this.txt_MaNV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaNV";
            // 
            // FormTimNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgr);
            this.Name = "FormTimNhanVien";
            this.Text = "FormTimNhanVien";
            this.Load += new System.EventHandler(this.FormTimNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgr;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TienLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_MaPB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_GioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtime_NgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label1;
    }
}