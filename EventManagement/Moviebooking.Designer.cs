﻿namespace EventManagement
{
    partial class Moviebooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moviebooking));
            this.label1 = new System.Windows.Forms.Label();
            this.cbtitle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numseat = new System.Windows.Forms.NumericUpDown();
            this.datebk = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnbook = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.txtgenere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtime = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbodc = new System.Windows.Forms.RadioButton();
            this.rbbalcony = new System.Windows.Forms.RadioButton();
            this.rblux = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numseat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // cbtitle
            // 
            this.cbtitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtitle.FormattingEnabled = true;
            this.cbtitle.Location = new System.Drawing.Point(278, 69);
            this.cbtitle.Name = "cbtitle";
            this.cbtitle.Size = new System.Drawing.Size(308, 31);
            this.cbtitle.TabIndex = 1;
            this.cbtitle.SelectedIndexChanged += new System.EventHandler(this.cbtitle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seats";
            // 
            // numseat
            // 
            this.numseat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numseat.Location = new System.Drawing.Point(278, 347);
            this.numseat.Name = "numseat";
            this.numseat.Size = new System.Drawing.Size(98, 30);
            this.numseat.TabIndex = 7;
            this.numseat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numseat.ValueChanged += new System.EventHandler(this.numseat_ValueChanged);
            // 
            // datebk
            // 
            this.datebk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datebk.Location = new System.Drawing.Point(278, 186);
            this.datebk.Name = "datebk";
            this.datebk.Size = new System.Drawing.Size(308, 30);
            this.datebk.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(278, 405);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(308, 30);
            this.txtprice.TabIndex = 11;
            this.txtprice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.Color.LightSalmon;
            this.btnbook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbook.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.Location = new System.Drawing.Point(481, 464);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(137, 46);
            this.btnbook.TabIndex = 12;
            this.btnbook.Text = "Book";
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(239, 464);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(137, 46);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.LightSalmon;
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.Location = new System.Drawing.Point(658, 12);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(122, 33);
            this.btnmenu.TabIndex = 14;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // txtgenere
            // 
            this.txtgenere.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgenere.Location = new System.Drawing.Point(278, 125);
            this.txtgenere.Name = "txtgenere";
            this.txtgenere.ReadOnly = true;
            this.txtgenere.Size = new System.Drawing.Size(308, 30);
            this.txtgenere.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Genere";
            // 
            // cbtime
            // 
            this.cbtime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtime.FormattingEnabled = true;
            this.cbtime.Items.AddRange(new object[] {
            "Morning Show - 10.00 am ",
            "Afternoon Show - 2.00 pm",
            "Evening Show - 6.00 pm",
            "Night Show - 10.00 pm"});
            this.cbtime.Location = new System.Drawing.Point(278, 242);
            this.cbtime.Name = "cbtime";
            this.cbtime.Size = new System.Drawing.Size(308, 31);
            this.cbtime.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Show time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Seat Type";
            // 
            // rbodc
            // 
            this.rbodc.AutoSize = true;
            this.rbodc.BackColor = System.Drawing.Color.Transparent;
            this.rbodc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbodc.Location = new System.Drawing.Point(278, 304);
            this.rbodc.Name = "rbodc";
            this.rbodc.Size = new System.Drawing.Size(72, 26);
            this.rbodc.TabIndex = 20;
            this.rbodc.TabStop = true;
            this.rbodc.Text = "ODC";
            this.rbodc.UseVisualStyleBackColor = false;
            this.rbodc.CheckedChanged += new System.EventHandler(this.rbodc_CheckedChanged);
            // 
            // rbbalcony
            // 
            this.rbbalcony.AutoSize = true;
            this.rbbalcony.BackColor = System.Drawing.Color.Transparent;
            this.rbbalcony.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbbalcony.Location = new System.Drawing.Point(400, 305);
            this.rbbalcony.Name = "rbbalcony";
            this.rbbalcony.Size = new System.Drawing.Size(96, 26);
            this.rbbalcony.TabIndex = 21;
            this.rbbalcony.TabStop = true;
            this.rbbalcony.Text = "Balcony";
            this.rbbalcony.UseVisualStyleBackColor = false;
            this.rbbalcony.CheckedChanged += new System.EventHandler(this.rbbalcony_CheckedChanged);
            // 
            // rblux
            // 
            this.rblux.AutoSize = true;
            this.rblux.BackColor = System.Drawing.Color.Transparent;
            this.rblux.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblux.Location = new System.Drawing.Point(524, 305);
            this.rblux.Name = "rblux";
            this.rblux.Size = new System.Drawing.Size(85, 26);
            this.rblux.TabIndex = 22;
            this.rblux.TabStop = true;
            this.rblux.Text = "Luxury";
            this.rblux.UseVisualStyleBackColor = false;
            this.rblux.CheckedChanged += new System.EventHandler(this.rblux_CheckedChanged);
            // 
            // Moviebooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::EventManagement.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 539);
            this.Controls.Add(this.rblux);
            this.Controls.Add(this.rbbalcony);
            this.Controls.Add(this.rbodc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbtime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtgenere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datebk);
            this.Controls.Add(this.numseat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbtitle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Moviebooking";
            this.Text = "Moviebooking";
            this.Load += new System.EventHandler(this.Moviebooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numseat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numseat;
        private System.Windows.Forms.DateTimePicker datebk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.TextBox txtgenere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbtime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbodc;
        private System.Windows.Forms.RadioButton rbbalcony;
        private System.Windows.Forms.RadioButton rblux;
    }
}