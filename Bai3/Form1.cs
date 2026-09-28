namespace Bai3
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
            txtToan.Enter += TextBoxDiem_Enter;
            txtVan.Enter += TextBoxDiem_Enter;
            txtAnh.Enter += TextBoxDiem_Enter;
        }

        private void txtToan_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void DangKyEnterChuyenField()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBoxBase textBoxBase)
                {
                    textBoxBase.KeyPress += (sender, e) =>
                    {
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            e.Handled = true;

                            // Kiểm tra sender (nếu sender không null)
                            if (sender != null && sender == txtAnh)
                            {
                                btnLuu.PerformClick();
                            }
                            else if (sender != null)
                            {
                                SelectNextControl((Control)sender, true, true, true, true);
                            }
                        }
                    };
                }
            }
        }
        private void TextBoxDiem_Enter(object? sender, EventArgs e)
        {
            if (sender is TextBoxBase txtBase)
            {
                txtBase.SelectAll();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (!KiemTraHopLeDiem(txtToan)) hopLe = false;
            if (!KiemTraHopLeDiem(txtVan)) hopLe = false;
            if (!KiemTraHopLeDiem(txtAnh)) hopLe = false;

            if (hopLe)
            {
                string dongMoi = $"{txtMaHS.Text} | {txtHoTen.Text} | T:{txtToan.Text} V:{txtVan.Text} A:{txtAnh.Text}";
                listBox1.Items.Add(dongMoi);

                txtMaHS.Clear();
                txtHoTen.Clear();
                txtToan.Clear();
                txtVan.Clear();
                txtAnh.Clear();
                txtMaHS.Focus();
            }
        }
        private bool KiemTraHopLeDiem(Control txt)
        {
            if (decimal.TryParse(txt.Text, out decimal diem) && diem >= 0 && diem <= 10)
            {
                return true;
            }
            else
            {
                errorProvider1.SetError(txt, "Điểm phải là số từ 0.0 đến 10.0");
                return false;
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            txtMaHS.Focus();
        }
    }
}
