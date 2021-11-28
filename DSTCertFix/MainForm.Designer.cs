namespace DSTCertFix
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fixSubmit = new System.Windows.Forms.Button();
            this.currentUserRadio = new System.Windows.Forms.RadioButton();
            this.localMachineRadio = new System.Windows.Forms.RadioButton();
            this.BottomstatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.paddingStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LanguagesDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaingroupBox = new System.Windows.Forms.GroupBox();
            this.RdImgpanel = new System.Windows.Forms.Panel();
            this.UACpictureBox = new System.Windows.Forms.PictureBox();
            this.BottomstatusStrip.SuspendLayout();
            this.MaingroupBox.SuspendLayout();
            this.RdImgpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UACpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fixSubmit
            // 
            this.fixSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fixSubmit.Enabled = false;
            this.fixSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fixSubmit.Location = new System.Drawing.Point(13, 111);
            this.fixSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fixSubmit.Name = "fixSubmit";
            this.fixSubmit.Size = new System.Drawing.Size(358, 35);
            this.fixSubmit.TabIndex = 1;
            this.fixSubmit.Text = "Fix";
            this.fixSubmit.UseVisualStyleBackColor = true;
            this.fixSubmit.Click += new System.EventHandler(this.FixSubmit_Click);
            // 
            // currentUserRadio
            // 
            this.currentUserRadio.AutoSize = true;
            this.currentUserRadio.Location = new System.Drawing.Point(3, 3);
            this.currentUserRadio.Name = "currentUserRadio";
            this.currentUserRadio.Size = new System.Drawing.Size(105, 24);
            this.currentUserRadio.TabIndex = 2;
            this.currentUserRadio.Text = "For me only";
            this.currentUserRadio.UseVisualStyleBackColor = true;
            this.currentUserRadio.CheckedChanged += new System.EventHandler(this.EnableFix_btn);
            // 
            // localMachineRadio
            // 
            this.localMachineRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localMachineRadio.AutoSize = true;
            this.localMachineRadio.Location = new System.Drawing.Point(3, 33);
            this.localMachineRadio.Name = "localMachineRadio";
            this.localMachineRadio.Size = new System.Drawing.Size(216, 24);
            this.localMachineRadio.TabIndex = 3;
            this.localMachineRadio.Text = "For all users in this computer";
            this.localMachineRadio.UseVisualStyleBackColor = true;
            this.localMachineRadio.CheckedChanged += new System.EventHandler(this.EnableFix_btn);
            // 
            // BottomstatusStrip
            // 
            this.BottomstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.paddingStatusLabel,
            this.helpStatusLabel,
            this.LanguagesDropDown});
            this.BottomstatusStrip.Location = new System.Drawing.Point(0, 157);
            this.BottomstatusStrip.Name = "BottomstatusStrip";
            this.BottomstatusStrip.Size = new System.Drawing.Size(384, 22);
            this.BottomstatusStrip.SizingGrip = false;
            this.BottomstatusStrip.TabIndex = 5;
            this.BottomstatusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.MarqueeAnimationSpeed = 30;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(200, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // paddingStatusLabel
            // 
            this.paddingStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.paddingStatusLabel.Name = "paddingStatusLabel";
            this.paddingStatusLabel.Size = new System.Drawing.Size(75, 17);
            this.paddingStatusLabel.Spring = true;
            // 
            // helpStatusLabel
            // 
            this.helpStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.helpStatusLabel.IsLink = true;
            this.helpStatusLabel.Name = "helpStatusLabel";
            this.helpStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.helpStatusLabel.Text = "Help";
            this.helpStatusLabel.Click += new System.EventHandler(this.HelpStatusLabel_Click);
            // 
            // LanguagesDropDown
            // 
            this.LanguagesDropDown.AutoToolTip = false;
            this.LanguagesDropDown.BackColor = System.Drawing.SystemColors.Control;
            this.LanguagesDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LanguagesDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.greekToolStripMenuItem});
            this.LanguagesDropDown.Image = global::DSTCertFix.Properties.Resources.languages;
            this.LanguagesDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LanguagesDropDown.Name = "LanguagesDropDown";
            this.LanguagesDropDown.Size = new System.Drawing.Size(29, 20);
            this.LanguagesDropDown.Text = "Select language";
            this.LanguagesDropDown.ToolTipText = "Select language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Image = global::DSTCertFix.Properties.Resources.usa;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // greekToolStripMenuItem
            // 
            this.greekToolStripMenuItem.Image = global::DSTCertFix.Properties.Resources.greece;
            this.greekToolStripMenuItem.Name = "greekToolStripMenuItem";
            this.greekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greekToolStripMenuItem.Text = "Greek";
            this.greekToolStripMenuItem.Click += new System.EventHandler(this.GreekToolStripMenuItem_Click);
            // 
            // MaingroupBox
            // 
            this.MaingroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MaingroupBox.Controls.Add(this.RdImgpanel);
            this.MaingroupBox.Location = new System.Drawing.Point(12, 12);
            this.MaingroupBox.Name = "MaingroupBox";
            this.MaingroupBox.Size = new System.Drawing.Size(359, 91);
            this.MaingroupBox.TabIndex = 0;
            this.MaingroupBox.TabStop = false;
            this.MaingroupBox.Text = "Select the user account you would like to fix:";
            // 
            // RdImgpanel
            // 
            this.RdImgpanel.AutoSize = true;
            this.RdImgpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RdImgpanel.Controls.Add(this.currentUserRadio);
            this.RdImgpanel.Controls.Add(this.UACpictureBox);
            this.RdImgpanel.Controls.Add(this.localMachineRadio);
            this.RdImgpanel.Location = new System.Drawing.Point(6, 23);
            this.RdImgpanel.Name = "RdImgpanel";
            this.RdImgpanel.Size = new System.Drawing.Size(302, 60);
            this.RdImgpanel.TabIndex = 5;
            // 
            // UACpictureBox
            // 
            this.UACpictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UACpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UACpictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UACpictureBox.Location = new System.Drawing.Point(219, 37);
            this.UACpictureBox.Name = "UACpictureBox";
            this.UACpictureBox.Size = new System.Drawing.Size(16, 16);
            this.UACpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UACpictureBox.TabIndex = 4;
            this.UACpictureBox.TabStop = false;
            this.UACpictureBox.Visible = false;
            this.UACpictureBox.Click += new System.EventHandler(this.UACpictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 179);
            this.Controls.Add(this.MaingroupBox);
            this.Controls.Add(this.fixSubmit);
            this.Controls.Add(this.BottomstatusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DST Certificate Fix";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BottomstatusStrip.ResumeLayout(false);
            this.BottomstatusStrip.PerformLayout();
            this.MaingroupBox.ResumeLayout(false);
            this.MaingroupBox.PerformLayout();
            this.RdImgpanel.ResumeLayout(false);
            this.RdImgpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UACpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fixSubmit;
        private System.Windows.Forms.RadioButton currentUserRadio;
        private System.Windows.Forms.RadioButton localMachineRadio;
        private System.Windows.Forms.StatusStrip BottomstatusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel paddingStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel helpStatusLabel;
        private System.Windows.Forms.GroupBox MaingroupBox;
        private System.Windows.Forms.PictureBox UACpictureBox;
        private System.Windows.Forms.ToolStripDropDownButton LanguagesDropDown;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greekToolStripMenuItem;
        private System.Windows.Forms.Panel RdImgpanel;
    }
}

