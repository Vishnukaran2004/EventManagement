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
            this.txtpri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datetymcon = new System.Windows.Forms.DateTimePicker();
            this.numseat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbgen = new System.Windows.Forms.RadioButton();
            this.rbvvip = new System.Windows.Forms.RadioButton();
            this.rbvip = new System.Windows.Forms.RadioButton();
            this.btnmenu = new System.Windows.Forms.Button();
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
            // 
            // txtpri
            // 
            this.txtpri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpri.Location = new System.Drawing.Point(325, 283);
            this.txtpri.Name = "txtpri";
            this.txtpri.ReadOnly = true;
            this.txtpri.Size = new System.Drawing.Size(244, 34);
            this.txtpri.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 288);
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
            this.label4.Location = new System.Drawing.Point(84, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "DATE /TIME";
            // 
            // datetymcon
            // 
            this.datetymcon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetymcon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetymcon.Location = new System.Drawing.Point(325, 231);
            this.datetymcon.Name = "datetymcon";
            this.datetymcon.Size = new System.Drawing.Size(200, 34);
            this.datetymcon.TabIndex = 22;
            // 
            // numseat
            // 
            this.numseat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numseat.Location = new System.Drawing.Point(325, 109);
            this.numseat.Name = "numseat";
            this.numseat.Size = new System.Drawing.Size(129, 34);
            this.numseat.TabIndex = 21;
            this.numseat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "SEATS";
            // 
            // cbcon
            // 
            this.cbcon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcon.FormattingEnabled = true;
            this.cbcon.Items.AddRange(new object[] {
            "RETURN OF DRAGON",
            "HUKUM",
            "ARR LIVE",
            "MAESTRO RAJA",
            "BLUE DIAMOND",
            "MENIKE",
            "HARRIS ALIVE",
            "VIBE ANTONY",
            "SL vs BAN",
            "RUGBY"});
            this.cbcon.Location = new System.Drawing.Point(325, 41);
            this.cbcon.Name = "cbcon";
            this.cbcon.Size = new System.Drawing.Size(244, 34);
            this.cbcon.TabIndex = 15;
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
            this.label2.Location = new System.Drawing.Point(84, 164);
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
            this.rbgen.Location = new System.Drawing.Point(325, 171);
            this.rbgen.Name = "rbgen";
            this.rbgen.Size = new System.Drawing.Size(121, 26);
            this.rbgen.TabIndex = 29;
            this.rbgen.TabStop = true;
            this.rbgen.Text = "GENERAL";
            this.rbgen.UseVisualStyleBackColor = false;
            // 
            // rbvvip
            // 
            this.rbvvip.AutoSize = true;
            this.rbvvip.BackColor = System.Drawing.Color.Transparent;
            this.rbvvip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbvvip.Location = new System.Drawing.Point(544, 170);
            this.rbvvip.Name = "rbvvip";
            this.rbvvip.Size = new System.Drawing.Size(74, 26);
            this.rbvvip.TabIndex = 30;
            this.rbvvip.TabStop = true;
            this.rbvvip.Text = "VVIP";
            this.rbvvip.UseVisualStyleBackColor = false;
            // 
            // rbvip
            // 
            this.rbvip.AutoSize = true;
            this.rbvip.BackColor = System.Drawing.Color.Transparent;
            this.rbvip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbvip.Location = new System.Drawing.Point(460, 171);
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
            // Concertbooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::EventManagement.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.rbvip);
            this.Controls.Add(this.rbvvip);
            this.Controls.Add(this.rbgen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.txtpri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetymcon);
            this.Controls.Add(this.numseat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbcon);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Concertbooking";
            this.Text = "Concertbooking";
            ((System.ComponentModel.ISupportInitialize)(this.numseat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.TextBox txtpri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetymcon;
        private System.Windows.Forms.NumericUpDown numseat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbgen;
        private System.Windows.Forms.RadioButton rbvvip;
        private System.Windows.Forms.RadioButton rbvip;
        private System.Windows.Forms.Button btnmenu;
    }
}