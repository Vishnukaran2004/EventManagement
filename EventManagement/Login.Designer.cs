﻿namespace EventManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtemal = new System.Windows.Forms.TextBox();
            this.lbregister = new System.Windows.Forms.LinkLabel();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtemal
            // 
            this.txtemal.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemal.Location = new System.Drawing.Point(365, 110);
            this.txtemal.Name = "txtemal";
            this.txtemal.Size = new System.Drawing.Size(269, 39);
            this.txtemal.TabIndex = 1;
            // 
            // lbregister
            // 
            this.lbregister.AutoSize = true;
            this.lbregister.BackColor = System.Drawing.Color.Transparent;
            this.lbregister.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbregister.Location = new System.Drawing.Point(520, 385);
            this.lbregister.Name = "lbregister";
            this.lbregister.Size = new System.Drawing.Size(114, 33);
            this.lbregister.TabIndex = 2;
            this.lbregister.TabStop = true;
            this.lbregister.Text = "Register ";
            this.lbregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtpw
            // 
            this.txtpw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpw.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.Location = new System.Drawing.Point(365, 173);
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '*';
            this.txtpw.Size = new System.Drawing.Size(269, 39);
            this.txtpw.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.LightSalmon;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(233, 281);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(115, 44);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(455, 281);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 44);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Don\'t have an account ?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::EventManagement.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbregister);
            this.Controls.Add(this.txtemal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemal;
        private System.Windows.Forms.LinkLabel lbregister;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
    }
}