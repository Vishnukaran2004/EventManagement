namespace EventManagement
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label2 = new System.Windows.Forms.Label();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.rbcard = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbadd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btnpay = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAYMENT METHOD";
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.BackColor = System.Drawing.Color.Transparent;
            this.rbcash.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcash.Location = new System.Drawing.Point(385, 176);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(92, 30);
            this.rbcash.TabIndex = 3;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "CASH";
            this.rbcash.UseVisualStyleBackColor = false;
            // 
            // rbcard
            // 
            this.rbcard.AutoSize = true;
            this.rbcard.BackColor = System.Drawing.Color.Transparent;
            this.rbcard.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcard.Location = new System.Drawing.Point(543, 176);
            this.rbcard.Name = "rbcard";
            this.rbcard.Size = new System.Drawing.Size(95, 30);
            this.rbcard.TabIndex = 4;
            this.rbcard.TabStop = true;
            this.rbcard.Text = "CARD";
            this.rbcard.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "ADDITIONAL ITEM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbadd
            // 
            this.cmbadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbadd.FormattingEnabled = true;
            this.cmbadd.Items.AddRange(new object[] {
            "POPCORNS",
            "SHORT - EATS",
            "SOFT DRINKS",
            "SNACKS"});
            this.cmbadd.Location = new System.Drawing.Point(389, 228);
            this.cmbadd.Name = "cmbadd";
            this.cmbadd.Size = new System.Drawing.Size(253, 37);
            this.cmbadd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "AMOUNT";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtamount.Location = new System.Drawing.Point(385, 303);
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(290, 34);
            this.txtamount.TabIndex = 8;
            // 
            // btnpay
            // 
            this.btnpay.BackColor = System.Drawing.Color.LightSalmon;
            this.btnpay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpay.Location = new System.Drawing.Point(532, 384);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(143, 43);
            this.btnpay.TabIndex = 9;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.LightSalmon;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(162, 384);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(143, 43);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtname.Location = new System.Drawing.Point(385, 122);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(290, 34);
            this.txtname.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "NAME";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::EventManagement.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbcard);
            this.Controls.Add(this.rbcash);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbcash;
        private System.Windows.Forms.RadioButton rbcard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
    }
}