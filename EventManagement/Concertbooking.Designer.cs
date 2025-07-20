namespace EventManagement
{
    partial class Concertbooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concertbooking));
            this.btncancel = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datetymcon = new System.Windows.Forms.DateTimePicker();
            this.numseat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbgen = new System.Windows.Forms.RadioButton();
            this.rbvvip = new System.Windows.Forms.RadioButton();
            this.rbvip = new System.Windows.Forms.RadioButton();
            this.btnmenu = new System.Windows.Forms.Button();
            this.txtvenue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numseat)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(236, 365);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(130, 51);
            this.btncancel.TabIndex = 27;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.Color.LightSalmon;
            this.btnbook.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.Location = new System.Drawing.Point(439, 365);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(130, 51);
            this.btnbook.TabIndex = 26;
            this.btnbook.Text = "Book";
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(325, 290);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(244, 34);
            this.txtprice.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "DATE";
            // 
            // datetymcon
            // 
            this.datetymcon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetymcon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetymcon.Location = new System.Drawing.Point(325, 98);
            this.datetymcon.Name = "datetymcon";
            this.datetymcon.Size = new System.Drawing.Size(200, 34);
            this.datetymcon.TabIndex = 22;
            // 
            // numseat
            // 
            this.numseat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numseat.Location = new System.Drawing.Point(325, 201);
            this.numseat.Name = "numseat";
            this.numseat.Size = new System.Drawing.Size(129, 34);
            this.numseat.TabIndex = 21;
            this.numseat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numseat.ValueChanged += new System.EventHandler(this.numseat_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "SEATS";
            // 
            // cbtitle
            // 
            this.cbtitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtitle.FormattingEnabled = true;
            this.cbtitle.Items.AddRange(new object[] {
            ""});
            this.cbtitle.Location = new System.Drawing.Point(325, 41);
            this.cbtitle.Name = "cbtitle";
            this.cbtitle.Size = new System.Drawing.Size(244, 34);
            this.cbtitle.TabIndex = 15;
            this.cbtitle.SelectedIndexChanged += new System.EventHandler(this.cbtitle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "CONCERT NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "CATEGORY";
            // 
            // rbgen
            // 
            this.rbgen.AutoSize = true;
            this.rbgen.BackColor = System.Drawing.Color.Transparent;
            this.rbgen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbgen.Location = new System.Drawing.Point(325, 249);
            this.rbgen.Name = "rbgen";
            this.rbgen.Size = new System.Drawing.Size(121, 26);
            this.rbgen.TabIndex = 29;
            this.rbgen.TabStop = true;
            this.rbgen.Text = "GENERAL";
            this.rbgen.UseVisualStyleBackColor = false;
            this.rbgen.CheckedChanged += new System.EventHandler(this.rbgen_CheckedChanged);
            // 
            // rbvvip
            // 
            this.rbvvip.AutoSize = true;
            this.rbvvip.BackColor = System.Drawing.Color.Transparent;
            this.rbvvip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbvvip.Location = new System.Drawing.Point(543, 249);
            this.rbvvip.Name = "rbvvip";
            this.rbvvip.Size = new System.Drawing.Size(74, 26);
            this.rbvvip.TabIndex = 30;
            this.rbvvip.TabStop = true;
            this.rbvvip.Text = "VVIP";
            this.rbvvip.UseVisualStyleBackColor = false;
            this.rbvvip.CheckedChanged += new System.EventHandler(this.rbvvip_CheckedChanged);
            // 
            // rbvip
            // 
            this.rbvip.AutoSize = true;
            this.rbvip.BackColor = System.Drawing.Color.Transparent;
            this.rbvip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbvip.Location = new System.Drawing.Point(460, 249);
            this.rbvip.Name = "rbvip";
            this.rbvip.Size = new System.Drawing.Size(61, 26);
            this.rbvip.TabIndex = 31;
            this.rbvip.TabStop = true;
            this.rbvip.Text = "VIP";
            this.rbvip.UseVisualStyleBackColor = false;
            this.rbvip.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.LightSalmon;
            this.btnmenu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.Location = new System.Drawing.Point(679, 12);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(109, 31);
            this.btnmenu.TabIndex = 32;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // txtvenue
            // 
            this.txtvenue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvenue.Location = new System.Drawing.Point(325, 147);
            this.txtvenue.Name = "txtvenue";
            this.txtvenue.ReadOnly = true;
            this.txtvenue.Size = new System.Drawing.Size(244, 34);
            this.txtvenue.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 33;
            this.label6.Text = "Venue";
            // 
            // Concertbooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::EventManagement.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtvenue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.rbvip);
            this.Controls.Add(this.rbvvip);
            this.Controls.Add(this.rbgen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetymcon);
            this.Controls.Add(this.numseat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbtitle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Concertbooking";
            this.Text = "Concertbooking";
            this.Load += new System.EventHandler(this.Concertbooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numseat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetymcon;
        private System.Windows.Forms.NumericUpDown numseat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbgen;
        private System.Windows.Forms.RadioButton rbvvip;
        private System.Windows.Forms.RadioButton rbvip;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.TextBox txtvenue;
        private System.Windows.Forms.Label label6;
    }
}