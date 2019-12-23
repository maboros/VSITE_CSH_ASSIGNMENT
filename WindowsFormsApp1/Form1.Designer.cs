namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LoadFile = new System.Windows.Forms.ToolStripButton();
            this.SaveFile = new System.Windows.Forms.ToolStripButton();
            this.SvaVelikaSlova = new System.Windows.Forms.ToolStripButton();
            this.PremaPravopisu = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 138);
            this.textBox1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFile,
            this.SaveFile,
            this.SvaVelikaSlova,
            this.PremaPravopisu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(283, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LoadFile
            // 
            this.LoadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoadFile.Image = ((System.Drawing.Image)(resources.GetObject("LoadFile.Image")));
            this.LoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(23, 22);
            this.LoadFile.Text = "&Load File";
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("SaveFile.Image")));
            this.SaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(23, 22);
            this.SaveFile.Text = "&Save File";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // SvaVelikaSlova
            // 
            this.SvaVelikaSlova.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SvaVelikaSlova.Image = ((System.Drawing.Image)(resources.GetObject("SvaVelikaSlova.Image")));
            this.SvaVelikaSlova.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SvaVelikaSlova.Name = "SvaVelikaSlova";
            this.SvaVelikaSlova.Size = new System.Drawing.Size(23, 22);
            this.SvaVelikaSlova.Text = "Sva &Velika Slova";
            this.SvaVelikaSlova.Click += new System.EventHandler(this.SvaVelikaSlova_Click);
            // 
            // PremaPravopisu
            // 
            this.PremaPravopisu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PremaPravopisu.Image = ((System.Drawing.Image)(resources.GetObject("PremaPravopisu.Image")));
            this.PremaPravopisu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PremaPravopisu.Name = "PremaPravopisu";
            this.PremaPravopisu.Size = new System.Drawing.Size(23, 22);
            this.PremaPravopisu.Text = "Prema &Pravopisu";
            this.PremaPravopisu.Click += new System.EventHandler(this.PremaPravopisu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 175);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LoadFile;
        private System.Windows.Forms.ToolStripButton SaveFile;
        private System.Windows.Forms.ToolStripButton SvaVelikaSlova;
        private System.Windows.Forms.ToolStripButton PremaPravopisu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

