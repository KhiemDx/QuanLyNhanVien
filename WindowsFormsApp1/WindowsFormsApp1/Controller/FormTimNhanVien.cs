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

namespace WindowsFormsApp1.Controller
{
    public partial class FormTimNhanVien : Form
    {
        public FormTimNhanVien()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-1HGH8ER\\SQLEXPRESS;database = QuanLyNhanVien; integrated security = SSPI");

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void HienThi(string truyvan)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(truyvan, con); // lay du lieu vao da
            DataTable tb = new DataTable();
            da.Fill(tb); // do du lieu vao table
            dtgr.DataSource = tb; // do table len view
            con.Close();
        }

        private void FormTimNhanVien_Load(object sender, EventArgs e)
        {
            HienThi("select * from NhanVien");
        }

        private void dtgr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dtgr.CurrentRow.Cells[0].Value.ToString();
            
            txt_TenNV.Text = dtgr.CurrentRow.Cells[1].Value.ToString();
            dtime_NgaySinh.Text = dtgr.CurrentRow.Cells[2].Value.ToString();
            cb_GioiTinh.Text = dtgr.CurrentRow.Cells[3].Value.ToString();
            
            txt_TienLuong.Text = dtgr.CurrentRow.Cells[4].Value.ToString();
            txt_MaPB.Text = dtgr.CurrentRow.Cells[5].Value.ToString();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string q = string.Format("select * from NhanVien where MaNV like '%{0}%'", txt_TimKiem.Text);
            HienThi(q);
        }
    }
}
