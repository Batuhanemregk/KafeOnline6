namespace KafeOnline6
{
    partial class SiparisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboUrun = new ComboBox();
            nudAdet = new NumericUpDown();
            btnUrunEkle = new Button();
            cboMasaNo = new ComboBox();
            btnMasaTasi = new Button();
            dgvDetaylar = new DataGridView();
            btnOdemeAl = new Button();
            btnSiparisIptal = new Button();
            btnAnasayfayaDon = new Button();
            label5 = new Label();
            lblOdemeTutari = new Label();
            lblMasaNo = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 4;
            label1.Text = "Ürün";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(141, 4);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 0;
            label2.Text = "Adet";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(457, 4);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 2;
            label3.Text = "Masa No:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(418, 271);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 3;
            label4.Text = "Ödeme Tutarı";
            // 
            // cboUrun
            // 
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(12, 27);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(121, 23);
            cboUrun.TabIndex = 0;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(141, 27);
            nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(120, 23);
            nudAdet.TabIndex = 1;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunEkle.Location = new Point(267, 23);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(103, 27);
            btnUrunEkle.TabIndex = 2;
            btnUrunEkle.Text = "EKLE";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += button1_Click;
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.FormattingEnabled = true;
            cboMasaNo.Location = new Point(457, 28);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(121, 23);
            cboMasaNo.TabIndex = 3;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMasaTasi.Location = new Point(584, 28);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(74, 23);
            btnMasaTasi.TabIndex = 4;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Location = new Point(12, 56);
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.Size = new Size(385, 393);
            dgvDetaylar.TabIndex = 6;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdemeAl.Location = new Point(548, 352);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(124, 49);
            btnOdemeAl.TabIndex = 6;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = true;
            btnOdemeAl.Click += button3_Click;
            // 
            // btnSiparisIptal
            // 
            btnSiparisIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisIptal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisIptal.Location = new Point(418, 352);
            btnSiparisIptal.Name = "btnSiparisIptal";
            btnSiparisIptal.Size = new Size(120, 49);
            btnSiparisIptal.TabIndex = 5;
            btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            btnSiparisIptal.UseVisualStyleBackColor = true;
            btnSiparisIptal.Click += button4_Click;
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfayaDon.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnasayfayaDon.Location = new Point(418, 407);
            btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            btnAnasayfayaDon.Size = new Size(254, 42);
            btnAnasayfayaDon.TabIndex = 7;
            btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor = true;
            btnAnasayfayaDon.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(567, 276);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 14;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdemeTutari.Location = new Point(584, 271);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(53, 21);
            lblOdemeTutari.TabIndex = 16;
            lblOdemeTutari.Text = "₺ 0,00";
            // 
            // lblMasaNo
            // 
            lblMasaNo.BackColor = Color.Tomato;
            lblMasaNo.Font = new Font("Segoe UI Black", 70F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor = SystemColors.ControlLightLight;
            lblMasaNo.Location = new Point(457, 71);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(201, 155);
            lblMasaNo.TabIndex = 17;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(lblMasaNo);
            Controls.Add(lblOdemeTutari);
            Controls.Add(label5);
            Controls.Add(btnAnasayfayaDon);
            Controls.Add(btnSiparisIptal);
            Controls.Add(btnOdemeAl);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnMasaTasi);
            Controls.Add(cboMasaNo);
            Controls.Add(btnUrunEkle);
            Controls.Add(nudAdet);
            Controls.Add(cboUrun);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(600, 450);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboUrun;
        private NumericUpDown nudAdet;
        private Button btnUrunEkle;
        private ComboBox cboMasaNo;
        private Button btnMasaTasi;
        private DataGridView dgvDetaylar;
        private Button btnOdemeAl;
        private Button btnSiparisIptal;
        private Button btnAnasayfayaDon;
        private Label label5;
        private Label lblOdemeTutari;
        private Label lblMasaNo;
    }
}