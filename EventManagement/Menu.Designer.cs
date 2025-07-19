namespace EventManagement
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btncam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmushroom = new System.Windows.Forms.Button();
            this.btncyum = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncon2 = new System.Windows.Forms.Button();
            this.btncon3 = new System.Windows.Forms.Button();
            this.btncon1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.concertsToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // concertsToolStripMenuItem
            // 
            this.concertsToolStripMenuItem.Name = "concertsToolStripMenuItem";
            this.concertsToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.concertsToolStripMenuItem.Text = "Concerts";
            this.concertsToolStripMenuItem.Click += new System.EventHandler(this.concertsToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // btncam
            // 
            this.btncam.Location = new System.Drawing.Point(62, 54);
            this.btncam.Name = "btncam";
            this.btncam.Size = new System.Drawing.Size(261, 164);
            this.btncam.TabIndex = 1;
            this.btncam.Text = "CAMATHAR";
            this.btncam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncam.UseVisualStyleBackColor = true;
            this.btncam.Click += new System.EventHandler(this.btncam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmushroom);
            this.groupBox1.Controls.Add(this.btncyum);
            this.groupBox1.Controls.Add(this.btncam);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movies";
            // 
            // btnmushroom
            // 
            this.btnmushroom.Location = new System.Drawing.Point(655, 54);
            this.btnmushroom.Name = "btnmushroom";
            this.btnmushroom.Size = new System.Drawing.Size(218, 164);
            this.btnmushroom.TabIndex = 3;
            this.btnmushroom.Text = "MUSHROOM";
            this.btnmushroom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmushroom.UseVisualStyleBackColor = true;
            this.btnmushroom.Click += new System.EventHandler(this.btnmushroom_Click);
            // 
            // btncyum
            // 
            this.btncyum.Location = new System.Drawing.Point(366, 54);
            this.btncyum.Name = "btncyum";
            this.btncyum.Size = new System.Drawing.Size(240, 164);
            this.btncyum.TabIndex = 2;
            this.btncyum.Text = "C  YUM";
            this.btncyum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncyum.UseVisualStyleBackColor = true;
            this.btncyum.Click += new System.EventHandler(this.btncyum_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncon2);
            this.groupBox2.Controls.Add(this.btncon3);
            this.groupBox2.Controls.Add(this.btncon1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 240);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Events";
            // 
            // btncon2
            // 
            this.btncon2.Location = new System.Drawing.Point(409, 37);
            this.btncon2.Name = "btncon2";
            this.btncon2.Size = new System.Drawing.Size(166, 169);
            this.btncon2.TabIndex = 3;
            this.btncon2.Text = "MENIKE";
            this.btncon2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncon2.UseVisualStyleBackColor = true;
            this.btncon2.Click += new System.EventHandler(this.btncon2_Click);
            // 
            // btncon3
            // 
            this.btncon3.Location = new System.Drawing.Point(678, 37);
            this.btncon3.Name = "btncon3";
            this.btncon3.Size = new System.Drawing.Size(164, 169);
            this.btncon3.TabIndex = 2;
            this.btncon3.Text = "SL vs Ban T20";
            this.btncon3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncon3.UseVisualStyleBackColor = true;
            this.btncon3.Click += new System.EventHandler(this.btncon3_Click);
            // 
            // btncon1
            // 
            this.btncon1.Location = new System.Drawing.Point(133, 37);
            this.btncon1.Name = "btncon1";
            this.btncon1.Size = new System.Drawing.Size(166, 169);
            this.btncon1.TabIndex = 1;
            this.btncon1.Text = "VIBE ANTONY";
            this.btncon1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncon1.UseVisualStyleBackColor = true;
            this.btncon1.Click += new System.EventHandler(this.btncon1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(894, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button btncam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmushroom;
        private System.Windows.Forms.Button btncyum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncon3;
        private System.Windows.Forms.Button btncon1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btncon2;
    }
}