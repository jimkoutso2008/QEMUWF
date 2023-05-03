namespace QEMUWF
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox1;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.MenuItem();
            this.thereIsNoHelpToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.MenuItem();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            groupBox1.Controls.Add(this.flowLayoutPanel1);
            groupBox1.Location = new System.Drawing.Point(10, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(218, 472);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 451);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Index = 0;
            this.fileToolStripMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Index = 0;
            this.newToolStripMenuItem.Text = "New VM";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Index = 1;
            this.toolStripMenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.thereIsNoHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Text = "Help";
            // 
            // thereIsNoHelpToolStripMenuItem
            // 
            this.thereIsNoHelpToolStripMenuItem.Index = 0;
            this.thereIsNoHelpToolStripMenuItem.Text = "there is no help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Index = 1;
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(739, 488);
            this.Controls.Add(groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(747, 515);
            this.Name = "Form1";
            this.Text = "Form1";
            groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuItem newToolStripMenuItem;
		private System.Windows.Forms.MenuItem toolStripMenuItem1;
		private System.Windows.Forms.MenuItem thereIsNoHelpToolStripMenuItem;
		private System.Windows.Forms.MenuItem aboutToolStripMenuItem;
	}
}

