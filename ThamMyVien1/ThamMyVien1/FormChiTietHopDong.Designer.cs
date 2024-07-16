namespace ThamMyVien1
{
    partial class FormChiTietHopDong
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
            gb_lichsu = new GroupBox();
            dgv_lichsu = new DataGridView();
            gb_lichsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_lichsu).BeginInit();
            SuspendLayout();
            // 
            // gb_lichsu
            // 
            gb_lichsu.Controls.Add(dgv_lichsu);
            gb_lichsu.Location = new Point(12, 12);
            gb_lichsu.Name = "gb_lichsu";
            gb_lichsu.Size = new Size(822, 510);
            gb_lichsu.TabIndex = 0;
            gb_lichsu.TabStop = false;
            gb_lichsu.Text = "Lịch sử thăm khám của bệnh nhân";
            // 
            // dgv_lichsu
            // 
            dgv_lichsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lichsu.Location = new Point(19, 26);
            dgv_lichsu.Name = "dgv_lichsu";
            dgv_lichsu.RowHeadersWidth = 51;
            dgv_lichsu.Size = new Size(789, 464);
            dgv_lichsu.TabIndex = 0;
            dgv_lichsu.CellContentDoubleClick += dgv_lichsu_CellContentDoubleClick;
            // 
            // FormChiTietHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 545);
            Controls.Add(gb_lichsu);
            Name = "FormChiTietHopDong";
            Text = "Chi tiết hợp đồng";
            gb_lichsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_lichsu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_lichsu;
        private DataGridView dgv_lichsu;
    }
}