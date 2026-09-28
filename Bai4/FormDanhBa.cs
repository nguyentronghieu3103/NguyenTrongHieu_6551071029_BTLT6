namespace Bai4
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên và Số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lienHe = $"{txtTen.Text.Trim()} - {txtSDT.Text.Trim()}";

            if (_indexDangSua == -1)
            {
                lstLienHe.Items.Add(lienHe);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items[_indexDangSua] = lienHe;
                _indexDangSua = -1;
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtTen.Clear();
            txtSDT.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selected = lstLienHe.SelectedItem?.ToString() ?? "";
            int index = selected.IndexOf(" - ");
            if (index != -1)
            {
                txtTen.Text = selected.Substring(0, index);
                txtSDT.Text = selected.Substring(index + 3);
            }
            else
            {
                txtTen.Text = selected;
                txtSDT.Text = "";
            }

            _indexDangSua = lstLienHe.SelectedIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selected = lstLienHe.SelectedItem?.ToString() ?? "";
            string ten = selected;
            int index = selected.IndexOf(" - ");
            if (index != -1)
            {
                ten = selected.Substring(0, index);
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa liên hệ {ten}?\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _indexDangSua = -1;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                }
                else if (result == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void lstLienHe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
