namespace KafeOnline6
{
    partial class UrunlerForm
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
            txtUrunAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nudBirimFiyat = new NumericUpDown();
            btnEkle = new Button();
            dgvUrunler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(5, 44);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(169, 23);
            txtUrunAd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 20);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 1;
            label1.Text = "ÜRÜN ADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(186, 20);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 2;
            label2.Text = "BİRİM FİYAT (₺)";
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.Location = new Point(186, 44);
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(120, 23);
            nudBirimFiyat.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(312, 44);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(5, 73);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.Size = new Size(496, 335);
            dgvUrunler.TabIndex = 5;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 424);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(nudBirimFiyat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUrunAd);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UrunlerForm";
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrunAd;
        private Label label1;
        private Label label2;
        private NumericUpDown nudBirimFiyat;
        private Button btnEkle;
        private DataGridView dgvUrunler;
    }
}