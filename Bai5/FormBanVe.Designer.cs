namespace Bai5
{
    partial class FormBanVe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblPhim = new Label();
            cboPhim = new ComboBox();
            lblSuatChieu = new Label();
            cboSuatChieu = new ComboBox();
            lblGheDaChon = new Label();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();

            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new Point(20, 20);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(82, 20);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách:";

            txtTenKhach.Location = new Point(20, 45);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(340, 27);
            txtTenKhach.TabIndex = 1;

            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(20, 85);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(45, 20);
            lblPhim.TabIndex = 2;
            lblPhim.Text = "Phim:";

            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(20, 110);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(340, 28);
            cboPhim.TabIndex = 3;

            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Location = new Point(20, 150);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(81, 20);
            lblSuatChieu.TabIndex = 4;
            lblSuatChieu.Text = "Suất chiếu:";

            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Location = new Point(20, 175);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(340, 28);
            cboSuatChieu.TabIndex = 5;

            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(20, 215);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(95, 20);
            lblGheDaChon.TabIndex = 6;
            lblGheDaChon.Text = "Ghế đã chọn:";

            txtGheDaChon.Location = new Point(20, 240);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(340, 27);
            txtGheDaChon.TabIndex = 7;

            btnChonGhe.Location = new Point(65, 290);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(95, 35);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;

            btnDatVe.Location = new Point(170, 290);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(95, 35);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;

            btnHuy.Location = new Point(275, 290);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(85, 35);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 346);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(lblGheDaChon);
            Controls.Add(cboSuatChieu);
            Controls.Add(lblSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(lblPhim);
            Controls.Add(txtTenKhach);
            Controls.Add(lblTenKhach);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán vé xem phim";
            Load += FormBanVe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTenKhach;
        private TextBox txtTenKhach;
        private Label lblPhim;
        private ComboBox cboPhim;
        private Label lblSuatChieu;
        private ComboBox cboSuatChieu;
        private Label lblGheDaChon;
        private TextBox txtGheDaChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
