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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concertBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concertManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.paymentDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 8, 0, 8);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.movieBookingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.movieBookingToolStripMenuItem.Text = "Movie Booking";
            // 
            // concertBookingToolStripMenuItem
            // 
            this.concertBookingToolStripMenuItem.Name = "concertBookingToolStripMenuItem";
            this.concertBookingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concertBookingToolStripMenuItem.Text = "Concert Booking";
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
            this.movieManageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.movieManageToolStripMenuItem.Text = "Movie Manage";
            // 
            // concertManageToolStripMenuItem
            // 
            this.concertManageToolStripMenuItem.Name = "concertManageToolStripMenuItem";
            this.concertManageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concertManageToolStripMenuItem.Text = "Concert Manage";
            // 
            // paymentDetailsToolStripMenuItem
            // 
            this.paymentDetailsToolStripMenuItem.Name = "paymentDetailsToolStripMenuItem";
            this.paymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.paymentDetailsToolStripMenuItem.Text = "Payment Details";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 68F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1054);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 13, 4, 13);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
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
        private System.Windows.Forms.ToolStripMenuItem paymentDetailsToolStripMenuItem;
    }
}