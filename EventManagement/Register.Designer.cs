namespace EventManagement
{
    partial class frmRegister
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
            this.TBregname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBregemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBregpnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBregpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBregcname = new System.Windows.Forms.TextBox();
            this.RegBackbtn = new System.Windows.Forms.Button();
            this.RegOkbtn = new System.Windows.Forms.Button();
            this.RegLoginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBregname
            // 
            this.TBregname.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TBregname.Location = new System.Drawing.Point(367, 72);
            this.TBregname.Name = "TBregname";
            this.TBregname.Size = new System.Drawing.Size(268, 34);
            this.TBregname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // TBregemail
            // 
            this.TBregemail.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TBregemail.Location = new System.Drawing.Point(367, 124);
            this.TBregemail.Name = "TBregemail";
            this.TBregemail.Size = new System.Drawing.Size(268, 34);
            this.TBregemail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label3.Location = new System.Drawing.Point(148, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone number";
            // 
            // TBregpnum
            // 
            this.TBregpnum.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TBregpnum.Location = new System.Drawing.Point(367, 186);
            this.TBregpnum.Name = "TBregpnum";
            this.TBregpnum.Size = new System.Drawing.Size(268, 34);
            this.TBregpnum.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label4.Location = new System.Drawing.Point(148, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // TBregpass
            // 
            this.TBregpass.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TBregpass.Location = new System.Drawing.Point(367, 235);
            this.TBregpass.Name = "TBregpass";
            this.TBregpass.Size = new System.Drawing.Size(268, 34);
            this.TBregpass.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label5.Location = new System.Drawing.Point(148, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirm password";
            // 
            // TBregcname
            // 
            this.TBregcname.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TBregcname.Location = new System.Drawing.Point(367, 294);
            this.TBregcname.Name = "TBregcname";
            this.TBregcname.Size = new System.Drawing.Size(268, 34);
            this.TBregcname.TabIndex = 8;
            // 
            // RegBackbtn
            // 
            this.RegBackbtn.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.RegBackbtn.Location = new System.Drawing.Point(153, 394);
            this.RegBackbtn.Name = "RegBackbtn";
            this.RegBackbtn.Size = new System.Drawing.Size(103, 34);
            this.RegBackbtn.TabIndex = 10;
            this.RegBackbtn.Text = "Back";
            this.RegBackbtn.UseVisualStyleBackColor = true;
            this.RegBackbtn.Click += new System.EventHandler(this.RegBackbtn_Click);
            // 
            // RegOkbtn
            // 
            this.RegOkbtn.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.RegOkbtn.Location = new System.Drawing.Point(532, 394);
            this.RegOkbtn.Name = "RegOkbtn";
            this.RegOkbtn.Size = new System.Drawing.Size(103, 34);
            this.RegOkbtn.TabIndex = 11;
            this.RegOkbtn.Text = "Ok";
            this.RegOkbtn.UseVisualStyleBackColor = true;
            // 
            // RegLoginbtn
            // 
            this.RegLoginbtn.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.RegLoginbtn.Location = new System.Drawing.Point(345, 394);
            this.RegLoginbtn.Name = "RegLoginbtn";
            this.RegLoginbtn.Size = new System.Drawing.Size(103, 34);
            this.RegLoginbtn.TabIndex = 12;
            this.RegLoginbtn.Text = "Login";
            this.RegLoginbtn.UseVisualStyleBackColor = true;
            this.RegLoginbtn.Click += new System.EventHandler(this.RegLoginbtn_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegLoginbtn);
            this.Controls.Add(this.RegOkbtn);
            this.Controls.Add(this.RegBackbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBregcname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBregpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBregpnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBregemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBregname);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBregname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBregemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBregpnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBregpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBregcname;
        private System.Windows.Forms.Button RegBackbtn;
        private System.Windows.Forms.Button RegOkbtn;
        private System.Windows.Forms.Button RegLoginbtn;
    }
}