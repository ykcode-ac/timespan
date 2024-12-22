namespace timespan
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSinavTarihi = new System.Windows.Forms.Label();
            this.lblKalanGun = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(379, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tıkla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSinavTarihi
            // 
            this.lblSinavTarihi.AutoSize = true;
            this.lblSinavTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavTarihi.Location = new System.Drawing.Point(30, 47);
            this.lblSinavTarihi.Name = "lblSinavTarihi";
            this.lblSinavTarihi.Size = new System.Drawing.Size(108, 24);
            this.lblSinavTarihi.TabIndex = 1;
            this.lblSinavTarihi.Text = "Sınav Tarihi";
            // 
            // lblKalanGun
            // 
            this.lblKalanGun.AutoSize = true;
            this.lblKalanGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanGun.Location = new System.Drawing.Point(140, 249);
            this.lblKalanGun.Name = "lblKalanGun";
            this.lblKalanGun.Size = new System.Drawing.Size(98, 24);
            this.lblKalanGun.TabIndex = 2;
            this.lblKalanGun.Text = "Kalan Gün";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 365);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblKalanGun);
            this.Controls.Add(this.lblSinavTarihi);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSinavTarihi;
        private System.Windows.Forms.Label lblKalanGun;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

