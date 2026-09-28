namespace Bai4
{
    partial class FormDanhBa
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
            lstLienHe = new ListBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.Font = new Font("Segoe UI", 10F);
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(12, 12);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(320, 326);
            lstLienHe.TabIndex = 0;
            lstLienHe.SelectedIndexChanged += lstLienHe_SelectedIndexChanged;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 10F);
            lblTen.Location = new Point(350, 12);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(36, 23);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 10F);
            txtTen.Location = new Point(350, 38);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(300, 30);
            txtTen.TabIndex = 2;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 10F);
            lblSDT.Location = new Point(350, 80);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(111, 23);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 10F);
            txtSDT.Location = new Point(350, 106);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(300, 30);
            txtSDT.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.Location = new Point(510, 150);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(140, 35);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Location = new Point(510, 195);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(140, 35);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.Location = new Point(510, 240);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 35);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.Location = new Point(510, 303);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(140, 35);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormDanhBa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 355);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(lstLienHe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDanhBa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh bạ";
            FormClosing += FormDanhBa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox lstLienHe;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}
