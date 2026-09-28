namespace Bai2
{
    partial class FormDatPhong
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
            lblHoTen = new Label();
            lblCCCD = new Label();
            lblNgayNhan = new Label();
            lblNgayTra = new Label();
            lblSoNguoiLon = new Label();
            lblSoTreEm = new Label();
            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            txtSoTreEm = new TextBox();
            txtSoNguoiLon = new TextBox();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(192, 35);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ Tên";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(192, 100);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(68, 20);
            lblCCCD.TabIndex = 1;
            lblCCCD.Text = "Số CCCD";
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Location = new Point(192, 163);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new Size(131, 20);
            lblNgayNhan.TabIndex = 2;
            lblNgayNhan.Text = "Ngày nhận phòng ";
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(192, 229);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(117, 20);
            lblNgayTra.TabIndex = 3;
            lblNgayTra.Text = "Ngày trả phòng ";
            // 
            // lblSoNguoiLon
            // 
            lblSoNguoiLon.AutoSize = true;
            lblSoNguoiLon.Location = new Point(192, 296);
            lblSoNguoiLon.Name = "lblSoNguoiLon";
            lblSoNguoiLon.Size = new Size(98, 20);
            lblSoNguoiLon.TabIndex = 4;
            lblSoNguoiLon.Text = "Số người lớn ";
            // 
            // lblSoTreEm
            // 
            lblSoTreEm.AutoSize = true;
            lblSoTreEm.Location = new Point(192, 368);
            lblSoTreEm.Name = "lblSoTreEm";
            lblSoTreEm.Size = new Size(77, 20);
            lblSoTreEm.TabIndex = 5;
            lblSoTreEm.Text = "Số trẻ em ";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(192, 58);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(199, 27);
            txtHoTen.TabIndex = 6;
            txtHoTen.TextChanged += textBox1_TextChanged;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += textBox1_TextChanged;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(192, 123);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(199, 27);
            txtCCCD.TabIndex = 7;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += textBox1_TextChanged;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(192, 186);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(199, 27);
            txtNgayNhan.TabIndex = 8;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += textBox1_TextChanged;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(192, 252);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(199, 27);
            txtNgayTra.TabIndex = 9;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += textBox1_TextChanged;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(192, 391);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(199, 27);
            txtSoTreEm.TabIndex = 10;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += textBox1_TextChanged;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(192, 319);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(199, 27);
            txtSoNguoiLon.TabIndex = 11;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += textBox1_TextChanged;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.Cyan;
            btnDatPhong.FlatStyle = FlatStyle.Flat;
            btnDatPhong.Location = new Point(192, 444);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(201, 34);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt phòng ";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(557, 522);
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Controls.Add(lblSoTreEm);
            Controls.Add(lblSoNguoiLon);
            Controls.Add(lblNgayTra);
            Controls.Add(lblNgayNhan);
            Controls.Add(lblCCCD);
            Controls.Add(lblHoTen);
            Name = "FormDatPhong";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblCCCD;
        private Label lblNgayNhan;
        private Label lblNgayTra;
        private Label lblSoNguoiLon;
        private Label lblSoTreEm;
        private TextBox txtHoTen;
        private TextBox txtCCCD;
        private TextBox txtNgayNhan;
        private TextBox txtNgayTra;
        private TextBox txtSoTreEm;
        private TextBox txtSoNguoiLon;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
