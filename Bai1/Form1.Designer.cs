namespace Bai1
{
    partial class FormDangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTittile = new Label();
            lblText = new Label();
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblMatKhau = new Label();
            lblXacNhanMK = new Label();
            txtHoTen = new MaskedTextBox();
            txtSDT = new MaskedTextBox();
            txtEmail = new MaskedTextBox();
            txtMatKhau = new MaskedTextBox();
            txtXacNhanMK = new MaskedTextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTittile
            // 
            lblTittile.AutoSize = true;
            lblTittile.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTittile.Location = new Point(24, 23);
            lblTittile.Name = "lblTittile";
            lblTittile.Size = new Size(286, 35);
            lblTittile.TabIndex = 0;
            lblTittile.Text = "Đăng ký tài khoản mới ";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(24, 70);
            lblText.Name = "lblText";
            lblText.Size = new Size(218, 20);
            lblText.TabIndex = 1;
            lblText.Text = "Vui lòng nhập đầy đủ thông tin ";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(89, 123);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(63, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ Tên: ";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(52, 166);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(100, 20);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(103, 205);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(75, 242);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(77, 20);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu: ";
            // 
            // lblXacNhanMK
            // 
            lblXacNhanMK.AutoSize = true;
            lblXacNhanMK.Location = new Point(12, 282);
            lblXacNhanMK.Name = "lblXacNhanMK";
            lblXacNhanMK.Size = new Size(145, 20);
            lblXacNhanMK.TabIndex = 6;
            lblXacNhanMK.Text = "Xác nhận mật khẩu:  ";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(158, 123);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(177, 27);
            txtHoTen.TabIndex = 7;
            txtHoTen.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(158, 163);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(177, 27);
            txtSDT.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(158, 242);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(177, 27);
            txtMatKhau.TabIndex = 10;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(158, 282);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(177, 27);
            txtXacNhanMK.TabIndex = 11;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.DeepSkyBlue;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Location = new Point(128, 330);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(106, 31);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng ký ";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.CausesValidation = false;
            btnHuy.Location = new Point(262, 330);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblXacNhanMK);
            Controls.Add(lblMatKhau);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Controls.Add(lblText);
            Controls.Add(lblTittile);
            Name = "FormDangKy";
            Text = "Form1";
            Load += FormDangKy_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTittile;
        private Label lblText;
        private Label lblHoTen;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblMatKhau;
        private Label lblXacNhanMK;
        private MaskedTextBox txtHoTen;
        private MaskedTextBox txtSDT;
        private MaskedTextBox txtEmail;
        private MaskedTextBox txtMatKhau;
        private MaskedTextBox txtXacNhanMK;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
