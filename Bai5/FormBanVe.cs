namespace Bai5
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
        }

        private void FormBanVe_Load(object sender, EventArgs e)
        {
            cboPhim.Items.AddRange(new string[] { "Chiến binh cuối cùng", "Avatar 2", "Doraemon", "Conan" });
            cboSuatChieu.Items.AddRange(new string[] { "17:00", "19:00", "21:00" });
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhim.Focus();
                return;
            }

            if (cboSuatChieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSuatChieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng chọn ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChonGhe.Focus();
                return;
            }

            string thongTin = $"XÁC NHẬN ĐẶT VÉ\n\nTên khách: {txtTenKhach.Text.Trim()}\nPhim: {cboPhim.SelectedItem}\nSuất chiếu: {cboSuatChieu.SelectedItem}\nGhế: {txtGheDaChon.Text}\nGiá vé: 75.000đ/vé";
            MessageBox.Show(thongTin, "Thông tin đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = -1;
            cboSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();
            txtTenKhach.Focus();
        }
    }
}
