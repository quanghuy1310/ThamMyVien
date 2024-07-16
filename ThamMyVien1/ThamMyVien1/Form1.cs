using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ThamMyVien1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = ThamMyVien; Integrated Security = True;";
        public Form1()
        {
            InitializeComponent();
            LoadMaBenhNhan();
            LoadChonDichVu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMaBenhNhan();
            LoadChonDichVu();
            rtb_dsdv.Clear(); // Đảm bảo RichTextBox rỗng khi chương trình chạy
        }

        private void LoadMaBenhNhan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaBN FROM tblBenhNhan";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb_mbn.DisplayMember = "MaBN";
                cb_mbn.ValueMember = "MaBN";
                cb_mbn.DataSource = dt;
            }
        }

        private void LoadChonDichVu()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IDDV, TenDV FROM tblDichVu";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb_chondv.DisplayMember = "TenDV";
                cb_chondv.ValueMember = "IDDV";
                cb_chondv.DataSource = dt;
                cb_chondv.SelectedIndex = -1; // Đảm bảo ComboBox không có mục nào được chọn khi tải form
            }
        }

        private void lb_ngay_Click(object sender, EventArgs e)
        {

        }

        private void cb_mbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_mbn.SelectedValue != null)
            {
                int maBN = (int)cb_mbn.SelectedValue;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT TenBN FROM tblBenhNhan WHERE MaBN = @MaBN";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaBN", maBN);
                    conn.Open();

                    string tenBN = (string)cmd.ExecuteScalar();
                    tb_tbn.Text = tenBN;
                }
            }
            else
            {
                {
                    tb_tbn.Clear(); // Clear tên bệnh nhân khi không có mã bệnh nhân được chọn
                }
            }
        }

        private void lb_chondv_Click(object sender, EventArgs e)
        {

        }

        private void lb_dsdv_Click(object sender, EventArgs e)
        {

        }

        private void tb_tbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ngay_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_thang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nam_TextChanged(object sender, EventArgs e)
        {

        }
        private void cb_chondv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedService = cb_chondv.Text;

            if (!string.IsNullOrEmpty(selectedService) && !rtb_dsdv.Text.Contains(selectedService))
            {
                rtb_dsdv.AppendText(selectedService + "\n");
            }
        }

        private void rtb_dsdv_TextChanged(object sender, EventArgs e)
        {
        }
        private void btn_chon_Click(object sender, EventArgs e)
        {
            int maBN = int.Parse(cb_mbn.Text);
            string tenBN = tb_tbn.Text;
            DateTime ngayKham = new DateTime(int.Parse(tb_nam.Text), int.Parse(tb_thang.Text), int.Parse(tb_ngay.Text));
            int maDV = (int)cb_chondv.SelectedValue;
            string tenDV = cb_chondv.Text;

            // Hiển thị kết quả trong RichTextBox
            rtb_ketqua.Text = $"Tên bệnh nhân: {tenBN}\nNgày khám: {ngayKham:dd/MM/yyyy}\nDịch vụ khám: {rtb_dsdv.Text}\n\n";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Kiểm tra và thêm bệnh nhân mới nếu cần
                string checkQuery = "SELECT COUNT(*) FROM tblBenhNhan WHERE MaBN = @MaBN";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaBN", maBN);
                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    string insertBenhNhanQuery = "INSERT INTO tblBenhNhan (MaBN, TenBN) VALUES (@MaBN, @TenBN)";
                    SqlCommand insertBenhNhanCmd = new SqlCommand(insertBenhNhanQuery, conn);
                    insertBenhNhanCmd.Parameters.AddWithValue("@MaBN", maBN);
                    insertBenhNhanCmd.Parameters.AddWithValue("@TenBN", tenBN);
                    insertBenhNhanCmd.ExecuteNonQuery();
                }

                // Thêm vào tblHopDong
                string insertHopDongQuery = "INSERT INTO tblHopDong (Ngay, MaBN, MaDV) VALUES (@Ngay, @MaBN, @MaDV)";
                SqlCommand insertHopDongCmd = new SqlCommand(insertHopDongQuery, conn);
                insertHopDongCmd.Parameters.AddWithValue("@Ngay", ngayKham);
                insertHopDongCmd.Parameters.AddWithValue("@MaBN", maBN);
                insertHopDongCmd.Parameters.AddWithValue("@MaDV", maDV);
                insertHopDongCmd.ExecuteNonQuery();

                var selectedValue = cb_mbn.SelectedValue;
                        // Khôi phục giá trị đã chọn

                LoadMaBenhNhan(); // Cập nhật lại ComboBox Mã bệnh nhân
                cb_mbn.SelectedValue = selectedValue;
                if (cb_mbn.SelectedValue != null)
                {
                    int selectedMaBN = (int)cb_mbn.SelectedValue;
                    string query = "SELECT TenBN FROM tblBenhNhan WHERE MaBN = @MaBN";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaBN", selectedMaBN);
                    //string tenBN = (string)cmd.ExecuteScalar();
                    tb_tbn.Text = tenBN; // Cập nhật lại TextBox Tên bệnh nhân
                }


            }
        }
        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            // Reset tất cả các điều khiển trên form về trạng thái ban đầu
            cb_mbn.SelectedIndex = -1;
            tb_tbn.Clear();
            tb_ngay.Clear();
            tb_thang.Clear();
            tb_nam.Clear();
            cb_chondv.SelectedIndex = -1;
            rtb_dsdv.Clear();
            rtb_ketqua.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            // Thoát chương trình
            Application.Exit();
        }

        private void rtb_ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_ketqua_Click(object sender, EventArgs e)
        {

        }

        private void btn_xemlichsu_Click(object sender, EventArgs e)
        {
            string maBenhNhan = cb_mbn.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maBenhNhan))
            {
                MessageBox.Show("Không có bản ghi nào.");
                return;
            }
            // Tạo và hiển thị FormChiTietHopDong với dữ liệu tương ứng
            FormChiTietHopDong formChiTietHopDong = new FormChiTietHopDong(maBenhNhan);
            if (formChiTietHopDong.ShowDialog() == DialogResult.OK)
            {
                rtb_ketqua.Text = formChiTietHopDong.SelectedRecord;
                tb_ngay.Text = formChiTietHopDong.SelectedNgay;
                tb_thang.Text = formChiTietHopDong.SelectedThang;
                tb_nam.Text = formChiTietHopDong.SelectedNam;
                rtb_dsdv.Text = formChiTietHopDong.SelectedService;
            }
            formChiTietHopDong.Owner = this;  // Đặt Form1 làm Owner của FormChiTietHopDong
        }
        public void SetData(string maBenhNhan, string ngayThang, string tenDV)
        {
            cb_mbn.SelectedValue = maBenhNhan;
            var parts = ngayThang.Split('/');
            tb_ngay.Text = parts[0];
            tb_thang.Text = parts[1];
            tb_nam.Text = parts[2];
            rtb_dsdv.Text = tenDV;
        }
    }
}
