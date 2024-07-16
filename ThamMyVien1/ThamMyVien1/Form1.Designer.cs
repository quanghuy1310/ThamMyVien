namespace ThamMyVien1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_ttbn = new GroupBox();
            rtb_dsdv = new RichTextBox();
            tb_nam = new TextBox();
            tb_thang = new TextBox();
            tb_ngay = new TextBox();
            tb_tbn = new TextBox();
            cb_chondv = new ComboBox();
            cb_mbn = new ComboBox();
            lb_nam = new Label();
            lb_thang = new Label();
            lb_dsdv = new Label();
            lb_chondv = new Label();
            lb_ngay = new Label();
            lb_tbn = new Label();
            lb_mbn = new Label();
            btn_chon = new Button();
            btn_tieptuc = new Button();
            btn_thoat = new Button();
            lb_ketqua = new Label();
            rtb_ketqua = new RichTextBox();
            btn_xemlichsu = new Button();
            gb_ttbn.SuspendLayout();
            SuspendLayout();
            // 
            // gb_ttbn
            // 
            gb_ttbn.Controls.Add(rtb_dsdv);
            gb_ttbn.Controls.Add(tb_nam);
            gb_ttbn.Controls.Add(tb_thang);
            gb_ttbn.Controls.Add(tb_ngay);
            gb_ttbn.Controls.Add(tb_tbn);
            gb_ttbn.Controls.Add(cb_chondv);
            gb_ttbn.Controls.Add(cb_mbn);
            gb_ttbn.Controls.Add(lb_nam);
            gb_ttbn.Controls.Add(lb_thang);
            gb_ttbn.Controls.Add(lb_dsdv);
            gb_ttbn.Controls.Add(lb_chondv);
            gb_ttbn.Controls.Add(lb_ngay);
            gb_ttbn.Controls.Add(lb_tbn);
            gb_ttbn.Controls.Add(lb_mbn);
            gb_ttbn.Location = new Point(12, 12);
            gb_ttbn.Name = "gb_ttbn";
            gb_ttbn.Size = new Size(916, 398);
            gb_ttbn.TabIndex = 0;
            gb_ttbn.TabStop = false;
            gb_ttbn.Text = "Thông tin bệnh nhân";
            // 
            // rtb_dsdv
            // 
            rtb_dsdv.Location = new Point(594, 216);
            rtb_dsdv.Name = "rtb_dsdv";
            rtb_dsdv.ReadOnly = true;
            rtb_dsdv.Size = new Size(279, 158);
            rtb_dsdv.TabIndex = 4;
            rtb_dsdv.Text = "";
            rtb_dsdv.TextChanged += rtb_dsdv_TextChanged;
            // 
            // tb_nam
            // 
            tb_nam.Location = new Point(410, 150);
            tb_nam.Name = "tb_nam";
            tb_nam.Size = new Size(94, 27);
            tb_nam.TabIndex = 3;
            tb_nam.TextChanged += tb_nam_TextChanged;
            // 
            // tb_thang
            // 
            tb_thang.Location = new Point(255, 150);
            tb_thang.Name = "tb_thang";
            tb_thang.Size = new Size(94, 27);
            tb_thang.TabIndex = 3;
            tb_thang.TextChanged += tb_thang_TextChanged;
            // 
            // tb_ngay
            // 
            tb_ngay.Location = new Point(90, 150);
            tb_ngay.Name = "tb_ngay";
            tb_ngay.Size = new Size(94, 27);
            tb_ngay.TabIndex = 3;
            tb_ngay.TextChanged += tb_ngay_TextChanged;
            // 
            // tb_tbn
            // 
            tb_tbn.Location = new Point(160, 98);
            tb_tbn.Name = "tb_tbn";
            tb_tbn.Size = new Size(299, 27);
            tb_tbn.TabIndex = 2;
            tb_tbn.TextChanged += tb_tbn_TextChanged;
            // 
            // cb_chondv
            // 
            cb_chondv.FormattingEnabled = true;
            cb_chondv.Location = new Point(140, 216);
            cb_chondv.Name = "cb_chondv";
            cb_chondv.Size = new Size(284, 28);
            cb_chondv.TabIndex = 1;
            cb_chondv.SelectedIndexChanged += cb_chondv_SelectedIndexChanged;
            // 
            // cb_mbn
            // 
            cb_mbn.FormattingEnabled = true;
            cb_mbn.Location = new Point(160, 43);
            cb_mbn.Name = "cb_mbn";
            cb_mbn.Size = new Size(299, 28);
            cb_mbn.TabIndex = 1;
            cb_mbn.SelectedIndexChanged += cb_mbn_SelectedIndexChanged;
            // 
            // lb_nam
            // 
            lb_nam.AutoSize = true;
            lb_nam.Location = new Point(363, 153);
            lb_nam.Name = "lb_nam";
            lb_nam.Size = new Size(41, 20);
            lb_nam.TabIndex = 0;
            lb_nam.Text = "Năm";
            // 
            // lb_thang
            // 
            lb_thang.AutoSize = true;
            lb_thang.Location = new Point(199, 153);
            lb_thang.Name = "lb_thang";
            lb_thang.Size = new Size(50, 20);
            lb_thang.TabIndex = 0;
            lb_thang.Text = "Tháng";
            // 
            // lb_dsdv
            // 
            lb_dsdv.AutoSize = true;
            lb_dsdv.Location = new Point(460, 219);
            lb_dsdv.Name = "lb_dsdv";
            lb_dsdv.Size = new Size(128, 20);
            lb_dsdv.TabIndex = 0;
            lb_dsdv.Text = "Danh sách dịch vụ";
            lb_dsdv.Click += lb_dsdv_Click;
            // 
            // lb_chondv
            // 
            lb_chondv.AutoSize = true;
            lb_chondv.Location = new Point(40, 219);
            lb_chondv.Name = "lb_chondv";
            lb_chondv.Size = new Size(94, 20);
            lb_chondv.TabIndex = 0;
            lb_chondv.Text = "Chọn dịch vụ";
            lb_chondv.Click += lb_chondv_Click;
            // 
            // lb_ngay
            // 
            lb_ngay.AutoSize = true;
            lb_ngay.Location = new Point(40, 153);
            lb_ngay.Name = "lb_ngay";
            lb_ngay.Size = new Size(44, 20);
            lb_ngay.TabIndex = 0;
            lb_ngay.Text = "Ngày";
            lb_ngay.Click += lb_ngay_Click;
            // 
            // lb_tbn
            // 
            lb_tbn.AutoSize = true;
            lb_tbn.Location = new Point(40, 105);
            lb_tbn.Name = "lb_tbn";
            lb_tbn.Size = new Size(105, 20);
            lb_tbn.TabIndex = 0;
            lb_tbn.Text = "Tên bệnh nhân";
            // 
            // lb_mbn
            // 
            lb_mbn.AutoSize = true;
            lb_mbn.Location = new Point(40, 46);
            lb_mbn.Name = "lb_mbn";
            lb_mbn.Size = new Size(103, 20);
            lb_mbn.TabIndex = 0;
            lb_mbn.Text = "Mã bệnh nhân";
            // 
            // btn_chon
            // 
            btn_chon.Location = new Point(102, 431);
            btn_chon.Name = "btn_chon";
            btn_chon.Size = new Size(175, 37);
            btn_chon.TabIndex = 1;
            btn_chon.Text = "Chọn";
            btn_chon.UseVisualStyleBackColor = true;
            btn_chon.Click += btn_chon_Click;
            // 
            // btn_tieptuc
            // 
            btn_tieptuc.Location = new Point(341, 431);
            btn_tieptuc.Name = "btn_tieptuc";
            btn_tieptuc.Size = new Size(175, 37);
            btn_tieptuc.TabIndex = 1;
            btn_tieptuc.Text = "Tiếp tục";
            btn_tieptuc.UseVisualStyleBackColor = true;
            btn_tieptuc.Click += btn_tieptuc_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(577, 431);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(175, 37);
            btn_thoat.TabIndex = 1;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // lb_ketqua
            // 
            lb_ketqua.AutoSize = true;
            lb_ketqua.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_ketqua.ForeColor = Color.Red;
            lb_ketqua.Location = new Point(16, 487);
            lb_ketqua.Name = "lb_ketqua";
            lb_ketqua.Size = new Size(80, 25);
            lb_ketqua.TabIndex = 2;
            lb_ketqua.Text = "Kết quả";
            lb_ketqua.Click += lb_ketqua_Click;
            // 
            // rtb_ketqua
            // 
            rtb_ketqua.ForeColor = Color.DodgerBlue;
            rtb_ketqua.Location = new Point(52, 531);
            rtb_ketqua.Name = "rtb_ketqua";
            rtb_ketqua.Size = new Size(833, 253);
            rtb_ketqua.TabIndex = 3;
            rtb_ketqua.Text = "";
            rtb_ketqua.TextChanged += rtb_ketqua_TextChanged;
            // 
            // btn_xemlichsu
            // 
            btn_xemlichsu.Image = Properties.Resources.Screenshot_2024_07_06_134142;
            btn_xemlichsu.Location = new Point(834, 426);
            btn_xemlichsu.Name = "btn_xemlichsu";
            btn_xemlichsu.Size = new Size(51, 46);
            btn_xemlichsu.TabIndex = 4;
            btn_xemlichsu.UseVisualStyleBackColor = true;
            btn_xemlichsu.Click += btn_xemlichsu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 811);
            Controls.Add(btn_xemlichsu);
            Controls.Add(rtb_ketqua);
            Controls.Add(lb_ketqua);
            Controls.Add(btn_thoat);
            Controls.Add(btn_tieptuc);
            Controls.Add(btn_chon);
            Controls.Add(gb_ttbn);
            Name = "Form1";
            Text = "Thẩm mỹ viện";
            Load += Form1_Load;
            gb_ttbn.ResumeLayout(false);
            gb_ttbn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_ttbn;
        private Label lb_nam;
        private Label lb_thang;
        private Label lb_ngay;
        private Label lb_tbn;
        private Label lb_mbn;
        private Label lb_dsdv;
        private Label lb_chondv;
        private RichTextBox rtb_dsdv;
        private TextBox tb_nam;
        private TextBox tb_thang;
        private TextBox tb_ngay;
        private TextBox tb_tbn;
        private ComboBox cb_chondv;
        private ComboBox cb_mbn;
        private Button btn_chon;
        private Button btn_tieptuc;
        private Button btn_thoat;
        private Label lb_ketqua;
        private RichTextBox rtb_ketqua;
        private Button btn_xemlichsu;
    }
}
