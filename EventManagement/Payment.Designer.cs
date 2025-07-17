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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.rbcard = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbadd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnpay = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(90, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtname.Location = new System.Drawing.Point(385, 88);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(290, 34);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(90, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAYMENT METHOD";
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcash.Location = new System.Drawing.Point(408, 161);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(80, 24);
            this.rbcash.TabIndex = 3;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "CASH";
            this.rbcash.UseVisualStyleBackColor = true;
            // 
            // rbcard
            // 
            this.rbcard.AutoSize = true;
            this.rbcard.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcard.Location = new System.Drawing.Point(566, 161);
            this.rbcard.Name = "rbcard";
            this.rbcard.Size = new System.Drawing.Size(82, 24);
            this.rbcard.TabIndex = 4;
            this.rbcard.TabStop = true;
            this.rbcard.Text = "CARD";
            this.rbcard.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(90, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 29);
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
            this.cmbadd.Location = new System.Drawing.Point(385, 219);
            this.cmbadd.Name = "cmbadd";
            this.cmbadd.Size = new System.Drawing.Size(253, 37);
            this.cmbadd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(90, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "AMOUNT";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(385, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 34);
            this.textBox1.TabIndex = 8;
            // 
            // btnpay
            // 
            this.btnpay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnpay.Location = new System.Drawing.Point(155, 374);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(143, 55);
            this.btnpay.TabIndex = 9;
            this.btnpay.Text = "ADD PAYMENT";
            this.btnpay.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnback.Location = new System.Drawing.Point(440, 374);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(143, 55);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbcard);
            this.Controls.Add(this.rbcash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbcash;
        private System.Windows.Forms.RadioButton rbcard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Button btnback;
    }
}