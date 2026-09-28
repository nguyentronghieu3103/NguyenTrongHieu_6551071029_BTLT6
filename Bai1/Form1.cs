namespace Bai1
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }
        private bool KiemTraHopLe()
        {
            bool hopLe = true;
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống và phải có ít nhất 3 ký tự.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }
            if (txtSDT.Text.Length != 10 || !txtSDT.Text.StartsWith("0") || !txtSDT.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            int atIndex = txtEmail.Text.IndexOf('@');
            int dotIndex = txtEmail.Text.LastIndexOf('.');
            if (atIndex == -1 || dotIndex == -1 || dotIndex < atIndex)
            {
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng (phải chứa '@' và dấu '.' phía sau).");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            if (txtXacNhanMK.Text != txtMatKhau.Text || string.IsNullOrEmpty(txtXacNhanMK.Text))
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            this.Close();
        }
    }
}
