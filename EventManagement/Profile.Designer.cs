namespace EventManagement
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.btnupdate = new System.Windows.Forms.Button();
            this.ProfBackbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LightSalmon;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnupdate.Location = new System.Drawing.Point(481, 369);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(103, 34);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // ProfBackbtn
            // 
            this.ProfBackbtn.BackColor = System.Drawing.Color.LightSalmon;
            this.ProfBackbtn.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.ProfBackbtn.Location = new System.Drawing.Point(181, 369);
            this.ProfBackbtn.Name = "ProfBackbtn";
            this.ProfBackbtn.Size = new System.Drawing.Size(103, 34);
            this.ProfBackbtn.TabIndex = 23;
            this.ProfBackbtn.Text = "Back";
            this.ProfBackbtn.UseVisualStyleBackColor = false;
            this.ProfBackbtn.Click += new System.EventHandler(this.ProfBackbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label5.Location = new System.Drawing.Point(176, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Confirm password";
            // 
            // txtconpass
            // 
            this.txtconpass.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtconpass.Location = new System.Drawing.Point(395, 294);
            this.txtconpass.Name = "txtconpass";
            this.txtconpass.Size = new System.Drawing.Size(268, 34);
            this.txtconpass.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label4.Location = new System.Drawing.Point(176, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtpass.Location = new System.Drawing.Point(395, 235);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(268, 34);
            this.txtpass.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label3.Location = new System.Drawing.Point(176, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone number";
            // 
            // txtpnum
            // 
            this.txtpnum.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtpnum.Location = new System.Drawing.Point(395, 186);
            this.txtpnum.Name = "txtpnum";
            this.txtpnum.Size = new System.Drawing.Size(268, 34);
            this.txtpnum.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtemail.Location = new System.Drawing.Point(395, 124);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(268, 34);
            this.txtemail.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtname.Location = new System.Drawing.Point(395, 72);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(268, 34);
            this.txtname.TabIndex = 13;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.LightSalmon;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnlogout.Location = new System.Drawing.Point(681, 12);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(107, 34);
            this.btnlogout.TabIndex = 25;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::EventManagement.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.ProfBackbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtconpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ProfBackbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnlogout;
    }
}