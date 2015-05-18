namespace getWindows.core.ui.forms
{
    partial class mainForm
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.ver = new System.Windows.Forms.ToolStripStatusLabel();
            this.spacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.counter = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winlist = new System.Windows.Forms.ListView();
            this.windowhandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.windowname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.minWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showWindowNormalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.popupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ver,
            this.spacer,
            this.counter});
            this.statusBar.Location = new System.Drawing.Point(0, 379);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(433, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // ver
            // 
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(41, 17);
            this.ver.Text = "ver 1.0";
            // 
            // spacer
            // 
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(329, 17);
            this.spacer.Spring = true;
            // 
            // counter
            // 
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(48, 17);
            this.counter.Text = "counter";
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(433, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutMenuItem.Text = "About getWindows";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // winlist
            // 
            this.winlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.windowhandle,
            this.windowname});
            this.winlist.ContextMenuStrip = this.popupMenu;
            this.winlist.FullRowSelect = true;
            this.winlist.Location = new System.Drawing.Point(0, 27);
            this.winlist.MultiSelect = false;
            this.winlist.Name = "winlist";
            this.winlist.Size = new System.Drawing.Size(433, 349);
            this.winlist.TabIndex = 5;
            this.winlist.UseCompatibleStateImageBehavior = false;
            this.winlist.View = System.Windows.Forms.View.Details;
            this.winlist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.winlist_MouseClick);
            // 
            // windowhandle
            // 
            this.windowhandle.Text = "Window Handle ID";
            this.windowhandle.Width = 120;
            // 
            // windowname
            // 
            this.windowname.Text = "Window Title";
            this.windowname.Width = 300;
            // 
            // popupMenu
            // 
            this.popupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minWindowMenuItem,
            this.maxWindowMenuItem,
            this.hideWindowMenuItem,
            this.showWindowNormalMenuItem});
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Size = new System.Drawing.Size(192, 92);
            this.popupMenu.Opening += new System.ComponentModel.CancelEventHandler(this.popupMenu_Opening);
            // 
            // minWindowMenuItem
            // 
            this.minWindowMenuItem.Name = "minWindowMenuItem";
            this.minWindowMenuItem.Size = new System.Drawing.Size(191, 22);
            this.minWindowMenuItem.Text = "Minimize Window";
            this.minWindowMenuItem.Click += new System.EventHandler(this.minWindowMenuItem_Click);
            // 
            // maxWindowMenuItem
            // 
            this.maxWindowMenuItem.Name = "maxWindowMenuItem";
            this.maxWindowMenuItem.Size = new System.Drawing.Size(191, 22);
            this.maxWindowMenuItem.Text = "Maximize Window";
            this.maxWindowMenuItem.Click += new System.EventHandler(this.maxWindowMenuItem_Click);
            // 
            // hideWindowMenuItem
            // 
            this.hideWindowMenuItem.Name = "hideWindowMenuItem";
            this.hideWindowMenuItem.Size = new System.Drawing.Size(191, 22);
            this.hideWindowMenuItem.Text = "Hide Window";
            this.hideWindowMenuItem.Click += new System.EventHandler(this.hideWindowMenuItem_Click);
            // 
            // showWindowNormalMenuItem
            // 
            this.showWindowNormalMenuItem.Name = "showWindowNormalMenuItem";
            this.showWindowNormalMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showWindowNormalMenuItem.Text = "Show Window normal";
            this.showWindowNormalMenuItem.Click += new System.EventHandler(this.showWindowNormalMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 401);
            this.Controls.Add(this.winlist);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "getWindows - Manage Opened Windows";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.popupMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ver;
        private System.Windows.Forms.ToolStripStatusLabel counter;
        private System.Windows.Forms.ToolStripStatusLabel spacer;
        private System.Windows.Forms.ListView winlist;
        private System.Windows.Forms.ColumnHeader windowhandle;
        private System.Windows.Forms.ColumnHeader windowname;
        private System.Windows.Forms.ContextMenuStrip popupMenu;
        private System.Windows.Forms.ToolStripMenuItem minWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showWindowNormalMenuItem;
    }
}

