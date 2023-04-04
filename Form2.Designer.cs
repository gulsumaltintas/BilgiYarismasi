namespace BilgiYarismasi
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnbasla = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.lblsoru = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblkalanzaman = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblbitti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 159);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(13, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(253, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(12, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(253, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnbasla
            // 
            this.btnbasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbasla.Location = new System.Drawing.Point(645, 12);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(203, 56);
            this.btnbasla.TabIndex = 5;
            this.btnbasla.Text = "Başla";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(650, 137);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 24);
            this.label.TabIndex = 6;
            this.label.Text = "Puan: ";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.ForeColor = System.Drawing.Color.White;
            this.lblpuan.Location = new System.Drawing.Point(745, 137);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(20, 24);
            this.lblpuan.TabIndex = 7;
            this.lblpuan.Text = "0";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogru.ForeColor = System.Drawing.Color.White;
            this.lbldogru.Location = new System.Drawing.Point(650, 277);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(60, 24);
            this.lbldogru.TabIndex = 8;
            this.lbldogru.Text = "Doğru";
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoru.ForeColor = System.Drawing.Color.White;
            this.lblsoru.Location = new System.Drawing.Point(745, 182);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(20, 24);
            this.lblsoru.TabIndex = 10;
            this.lblsoru.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(650, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soru:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblkalanzaman
            // 
            this.lblkalanzaman.AutoSize = true;
            this.lblkalanzaman.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkalanzaman.ForeColor = System.Drawing.Color.White;
            this.lblkalanzaman.Location = new System.Drawing.Point(745, 91);
            this.lblkalanzaman.Name = "lblkalanzaman";
            this.lblkalanzaman.Size = new System.Drawing.Size(20, 24);
            this.lblkalanzaman.TabIndex = 12;
            this.lblkalanzaman.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(650, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Süre:";
            // 
            // lblbitti
            // 
            this.lblbitti.AutoSize = true;
            this.lblbitti.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbitti.ForeColor = System.Drawing.Color.Red;
            this.lblbitti.Location = new System.Drawing.Point(148, 422);
            this.lblbitti.Name = "lblbitti";
            this.lblbitti.Size = new System.Drawing.Size(554, 146);
            this.lblbitti.TabIndex = 13;
            this.lblbitti.Text = "Süre Bitti!";
            this.lblbitti.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(860, 577);
            this.Controls.Add(this.lblbitti);
            this.Controls.Add(this.lblkalanzaman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Bilgi Yarışması";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Label lblsoru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblkalanzaman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblbitti;
    }
}