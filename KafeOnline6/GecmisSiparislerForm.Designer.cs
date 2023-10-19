namespace KafeOnline6
{
    partial class GecmisSiparislerForm
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
            splitContainer1 = new SplitContainer();
            dgvSiparisler = new DataGridView();
            dgvSiparisDetaylar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisDetaylar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 2;
            label1.Text = "ŞİPARİŞLER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-1, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 3;
            label2.Text = "SİPARİŞ DETAYLARI";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 45);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvSiparisler);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvSiparisDetaylar);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(649, 460);
            splitContainer1.SplitterDistance = 230;
            splitContainer1.TabIndex = 4;
            // 
            // dgvSiparisler
            // 
            dgvSiparisler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisler.Location = new Point(3, 3);
            dgvSiparisler.Name = "dgvSiparisler";
            dgvSiparisler.RowTemplate.Height = 25;
            dgvSiparisler.Size = new Size(643, 194);
            dgvSiparisler.TabIndex = 3;
            // 
            // dgvSiparisDetaylar
            // 
            dgvSiparisDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisDetaylar.Location = new Point(3, 29);
            dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            dgvSiparisDetaylar.RowTemplate.Height = 25;
            dgvSiparisDetaylar.Size = new Size(643, 194);
            dgvSiparisDetaylar.TabIndex = 4;
            // 
            // GecmisSiparislerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 557);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            Name = "GecmisSiparislerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GecmisSiparislerForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private SplitContainer splitContainer1;
        private DataGridView dgvSiparisler;
        private DataGridView dgvSiparisDetaylar;
    }
}