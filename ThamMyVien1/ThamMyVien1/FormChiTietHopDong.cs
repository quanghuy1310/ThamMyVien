using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThamMyVien1
{
    public partial class FormChiTietHopDong : Form
    {
        private string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = ThamMyVien; Integrated Security = True;";
        private string maBenhNhan;
        public string SelectedRecord { get; private set; } // Property to hold selected record
        public string SelectedNgay { get; private set; }
        public string SelectedThang { get; private set; }
        public string SelectedNam { get; private set; }

        public string SelectedService { get; private set; }

        public FormChiTietHopDong(string maBenhNhan)
        {
            InitializeComponent();
            this.maBenhNhan = maBenhNhan;
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Ngay, MaBN, TenDV FROM tblHopDong JOIN tblDichVu ON tblHopDong.MaDV = tblDichVu.IDDV WHERE MaBN = @MaBN ORDER BY Ngay";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBN", maBenhNhan);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_lichsu.DataSource = dt;

                if (dgv_lichsu.Columns["Ngay"] != null)
                {
                    dgv_lichsu.Columns["Ngay"].DefaultCellStyle.Format = "yyyy-MM-dd"; // Use your desired format
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có bản ghi nào.");
                }
            }
        }
        private void dgv_lichsu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow selectedRow = dgv_lichsu.Rows[e.RowIndex];
                DateTime ngay = (DateTime)selectedRow.Cells["Ngay"].Value;
                //string ngay = selectedRow.Cells["Ngay"].Value.ToString();
                string maBN = selectedRow.Cells["MaBN"].Value.ToString();
                string tenDV = selectedRow.Cells["TenDV"].Value.ToString();
                SelectedNgay = ngay.Day.ToString();
                SelectedThang = ngay.Month.ToString();
                SelectedNam = ngay.Year.ToString();
                SelectedService = tenDV.ToString();
                SelectedRecord = $"Ngày: {SelectedNgay}/{SelectedThang}/{SelectedNam}, Mã BN: {maBN}, Dịch vụ: {tenDV}";
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bản ghi.");
            }
        }
    }
}
