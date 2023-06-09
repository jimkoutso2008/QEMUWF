﻿namespace QEMUWF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.fileToolStripMenuItem = new System.Windows.Forms.MenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.MenuItem();
			this.qemuPath = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.exitMenu = new System.Windows.Forms.MenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.MenuItem();
			this.thereIsNoHelpToolStripMenuItem = new System.Windows.Forms.MenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.MenuItem();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.newButton = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			groupBox1 = new System.Windows.Forms.GroupBox();
			groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			groupBox1.Controls.Add(this.flowLayoutPanel1);
			groupBox1.Location = new System.Drawing.Point(2, -5);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(225, 490);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(219, 469);
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
            this.newToolStripMenuItem,
            this.qemuPath,
            this.menuItem2,
            this.exitMenu});
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Index = 0;
			this.newToolStripMenuItem.Text = "New VM";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// qemuPath
			// 
			this.qemuPath.Index = 1;
			this.qemuPath.Text = "Change QEMU path";
			this.qemuPath.Click += new System.EventHandler(this.qemuPath_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.Text = "-";
			// 
			// exitMenu
			// 
			this.exitMenu.Index = 3;
			this.exitMenu.Text = "Exit";
			this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
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
			// toolBar1
			// 
			this.toolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toolBar1.AutoSize = false;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.newButton});
			this.toolBar1.Divider = false;
			this.toolBar1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(227, 1);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(513, 38);
			this.toolBar1.TabIndex = 3;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// newButton
			// 
			this.newButton.ImageIndex = 0;
			this.newButton.Name = "newButton";
			this.newButton.Text = "Add";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "plus.png");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(739, 488);
			this.Controls.Add(this.toolBar1);
			this.Controls.Add(groupBox1);
			this.DoubleBuffered = true;
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
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton newButton;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MenuItem qemuPath;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem exitMenu;
	}
}

