namespace KafeOnline6
{
    partial class Anaform
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
            lvwMasalar = new ListView();
            menuStrip1 = new MenuStrip();
            tsmiUrunler = new ToolStripMenuItem();
            tsmiGecmisSiparisler = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lvwMasalar
            // 
            lvwMasalar.Dock = DockStyle.Fill;
            lvwMasalar.Location = new Point(0, 24);
            lvwMasalar.Name = "lvwMasalar";
            lvwMasalar.Size = new Size(584, 437);
            lvwMasalar.TabIndex = 0;
            lvwMasalar.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiUrunler, tsmiGecmisSiparisler });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUrunler
            // 
            tsmiUrunler.Name = "tsmiUrunler";
            tsmiUrunler.Size = new Size(70, 20);
            tsmiUrunler.Text = "ÜRÜNLER";
            // 
            // tsmiGecmisSiparisler
            // 
            tsmiGecmisSiparisler.Name = "tsmiGecmisSiparisler";
            tsmiGecmisSiparisler.Size = new Size(122, 20);
            tsmiGecmisSiparisler.Text = "GEÇMİŞ SİPARİŞLER";
            // 
            // Anaform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
            Controls.Add(lvwMasalar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Anaform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anaform";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvwMasalar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiUrunler;
        private ToolStripMenuItem tsmiGecmisSiparisler;
    }
}