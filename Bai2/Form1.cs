using System.Globalization;

namespace Bai2
{
    public partial class FormDatPhong : Form
    {
        public FormDatPhong()
        {
            InitializeComponent();
            txtHoTen.Validated += TextBox_Validated;
            txtCCCD.Validated += TextBox_Validated;
            txtNgayNhan.Validated += TextBox_Validated;
            txtNgayTra.Validated += TextBox_Validated;
            txtSoNguoiLon.Validated += TextBox_Validated;
            txtSoTreEm.Validated += TextBox_Validated;
        }

        private void textBox1_TextChanged(object? sender, EventArgs e)
        {

        }

        private void txtHoTen_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống.");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }
        }

        private void txtCCCD_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCCCD.Text.Length != 12 || !txtCCCD.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "Số CCCD phải gồm đúng 12 chữ số."); 
                txtCCCD.BackColor = Color.MistyRose; 
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
            }
        }

        private void txtNgayNhan_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!DateTime.TryParseExact(txtNgayNhan.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime ngayNhan) || ngayNhan.Date < DateTime.Now.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phòng phải có định dạng dd/MM/yyyy và từ hôm nay trở đi."); 
                txtNgayNhan.BackColor = Color.MistyRose; 
            }
            else
            {
                errorProvider1.SetError(txtNgayNhan, ""); 
            }
        }

        private void txtNgayTra_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime.TryParseExact(txtNgayNhan.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime ngayNhan);
            if (!DateTime.TryParseExact(txtNgayTra.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime ngayTra) || ngayTra.Date <= ngayNhan.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phòng phải có định dạng dd/MM/yyyy và sau ngày nhận."); 
                txtNgayTra.BackColor = Color.MistyRose; 
            }
            else
            {
                errorProvider1.SetError(txtNgayTra, ""); 
            }
        }

        private void txtSoNguoiLon_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(txtSoNguoiLon.Text, out int soNguoiLon) || soNguoiLon < 1 || soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoNguoiLon, "Số người lớn phải là số nguyên từ 1 đến 4."); 
                txtSoNguoiLon.BackColor = Color.MistyRose; 
            }
            else
            {
                errorProvider1.SetError(txtSoNguoiLon, ""); 
            }
        }

        private void txtSoTreEm_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(txtSoTreEm.Text, out int soTreEm) || soTreEm < 0 || soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoTreEm, "Số trẻ em phải là số nguyên từ 0 đến 3."); 
                txtSoTreEm.BackColor = Color.MistyRose; 
            }
            else
            {
                errorProvider1.SetError(txtSoTreEm, ""); 
            }
        }
        private void TextBox_Validated(object? sender, EventArgs e)
        {
            // Khi field đã hợp lệ, đổi màu nền thành xanh lá nhạt (Honeydew)[cite: 3, 4]
            TextBox? txt = sender as TextBox;
            if (txt != null)
            { 
                txt.BackColor = Color.Honeydew; 
            }
        }

        private void btnDatPhong_Click(object? sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                // Parse lại ngày để tính số đêm[cite: 4]
                DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text, "dd/MM/yyyy", null);
                DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text, "dd/MM/yyyy", null);

                int soDem = (ngayTra - ngayNhan).Days; // Tính số đêm[cite: 4]

                // Hiển thị MessageBox thông báo thành công[cite: 4]
                string thongBao = $"Khách hàng: {txtHoTen.Text}\n" +
                                  $"Số đêm: {soDem}\n" +
                                  $"Số người lớn: {txtSoNguoiLon.Text}, Trẻ em: {txtSoTreEm.Text}";

                MessageBox.Show(thongBao, "Đặt phòng thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
    }
}
