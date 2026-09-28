namespace Bai3
{
    partial class FormNhapDiem
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
            txtMaHS = new MaskedTextBox();
            txtHoTen = new MaskedTextBox();
            txtToan = new MaskedTextBox();
            txtVan = new MaskedTextBox();
            txtAnh = new MaskedTextBox();
            lblMaHS = new Label();
            lblHoTen = new Label();
            lblToan = new Label();
            lblVan = new Label();
            lblAnh = new Label();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            errorProvider1 = new ErrorProvider(components);
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(27, 76);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(102, 27);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(145, 76);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(99, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(264, 76);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(95, 27);
            txtToan.TabIndex = 2;
            txtToan.MaskInputRejected += txtToan_MaskInputRejected;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(377, 76);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(94, 27);
            txtVan.TabIndex = 3;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(498, 76);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(86, 27);
            txtAnh.TabIndex = 4;
            // 
            // lblMaHS
            // 
            lblMaHS.AutoSize = true;
            lblMaHS.Location = new Point(27, 47);
            lblMaHS.Name = "lblMaHS";
            lblMaHS.Size = new Size(49, 20);
            lblMaHS.TabIndex = 5;
            lblMaHS.Text = "MaHS";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(145, 47);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 20);
            lblHoTen.TabIndex = 6;
            lblHoTen.Text = "Họ Tên";
            // 
            // lblToan
            // 
            lblToan.AutoSize = true;
            lblToan.Location = new Point(264, 46);
            lblToan.Name = "lblToan";
            lblToan.Size = new Size(79, 20);
            lblToan.TabIndex = 7;
            lblToan.Text = "Điểm toán";
            // 
            // lblVan
            // 
            lblVan.AutoSize = true;
            lblVan.Location = new Point(377, 47);
            lblVan.Name = "lblVan";
            lblVan.Size = new Size(76, 20);
            lblVan.TabIndex = 8;
            lblVan.Text = "Điểm văn ";
            // 
            // lblAnh
            // 
            lblAnh.AutoSize = true;
            lblAnh.Location = new Point(497, 46);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(73, 20);
            lblAnh.TabIndex = 9;
            lblAnh.Text = "Điểm anh";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(27, 128);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(145, 128);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(94, 29);
            btnXoaTrang.TabIndex = 11;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(27, 184);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(557, 244);
            listBox1.TabIndex = 12;
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(listBox1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(lblAnh);
            Controls.Add(lblVan);
            Controls.Add(lblToan);
            Controls.Add(lblHoTen);
            Controls.Add(lblMaHS);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Name = "FormNhapDiem";
            Text = "err";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtMaHS;
        private MaskedTextBox txtHoTen;
        private MaskedTextBox txtToan;
        private MaskedTextBox txtVan;
        private MaskedTextBox txtAnh;
        private Label lblMaHS;
        private Label lblHoTen;
        private Label lblToan;
        private Label lblVan;
        private Label lblAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ErrorProvider errorProvider1;
        private ListBox listBox1;
    }
}
