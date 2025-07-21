namespace EventManagement
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concertBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concertManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtmovie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtconcert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmbooking = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcbooking = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::EventManagement.Properties.Resources.bg;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(900, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieBookingToolStripMenuItem,
            this.concertBookingToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.viewToolStripMenuItem.Text = "View Booking";
            // 
            // movieBookingToolStripMenuItem
            // 
            this.movieBookingToolStripMenuItem.Name = "movieBookingToolStripMenuItem";
            this.movieBookingToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.movieBookingToolStripMenuItem.Text = "Movie Booking";
            this.movieBookingToolStripMenuItem.Click += new System.EventHandler(this.movieBookingToolStripMenuItem_Click);
            // 
            // concertBookingToolStripMenuItem
            // 
            this.concertBookingToolStripMenuItem.Name = "concertBookingToolStripMenuItem";
            this.concertBookingToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.concertBookingToolStripMenuItem.Text = "Concert Booking";
            this.concertBookingToolStripMenuItem.Click += new System.EventHandler(this.concertBookingToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieManageToolStripMenuItem,
            this.concertManageToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // movieManageToolStripMenuItem
            // 
            this.movieManageToolStripMenuItem.Name = "movieManageToolStripMenuItem";
            this.movieManageToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.movieManageToolStripMenuItem.Text = "Movie Manage";
            this.movieManageToolStripMenuItem.Click += new System.EventHandler(this.movieManageToolStripMenuItem_Click);
            // 
            // concertManageToolStripMenuItem
            // 
            this.concertManageToolStripMenuItem.Name = "concertManageToolStripMenuItem";
            this.concertManageToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.concertManageToolStripMenuItem.Text = "Concert Manage";
            this.concertManageToolStripMenuItem.Click += new System.EventHandler(this.concertManageToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "No of Users registered: ";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.LightCoral;
            this.txtuser.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(307, 96);
            this.txtuser.Name = "txtuser";
            this.txtuser.ReadOnly = true;
            this.txtuser.Size = new System.Drawing.Size(215, 34);
            this.txtuser.TabIndex = 2;
            // 
            // txtmovie
            // 
            this.txtmovie.BackColor = System.Drawing.Color.LightCoral;
            this.txtmovie.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmovie.Location = new System.Drawing.Point(307, 159);
            this.txtmovie.Name = "txtmovie";
            this.txtmovie.ReadOnly = true;
            this.txtmovie.Size = new System.Drawing.Size(215, 34);
            this.txtmovie.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "No of Movies registered: ";
            // 
            // txtconcert
            // 
            this.txtconcert.BackColor = System.Drawing.Color.LightCoral;
            this.txtconcert.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconcert.Location = new System.Drawing.Point(307, 226);
            this.txtconcert.Name = "txtconcert";
            this.txtconcert.ReadOnly = true;
            this.txtconcert.Size = new System.Drawing.Size(215, 34);
            this.txtconcert.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "No of Concerts registered: ";
            // 
            // txtmbooking
            // 
            this.txtmbooking.BackColor = System.Drawing.Color.LightCoral;
            this.txtmbooking.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmbooking.Location = new System.Drawing.Point(307, 290);
            this.txtmbooking.Name = "txtmbooking";
            this.txtmbooking.ReadOnly = true;
            this.txtmbooking.Size = new System.Drawing.Size(215, 34);
            this.txtmbooking.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "No of Movie Booking: ";
            // 
            // txtcbooking
            // 
            this.txtcbooking.BackColor = System.Drawing.Color.LightCoral;
            this.txtcbooking.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcbooking.Location = new System.Drawing.Point(307, 349);
            this.txtcbooking.Name = "txtcbooking";
            this.txtcbooking.ReadOnly = true;
            this.txtcbooking.Size = new System.Drawing.Size(215, 34);
            this.txtcbooking.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "No of Concert Booking: ";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::EventManagement.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 431);
            this.Controls.Add(this.txtcbooking);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmbooking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtconcert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concertBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concertManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtmovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtconcert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmbooking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcbooking;
        private System.Windows.Forms.Label label5;
    }
}