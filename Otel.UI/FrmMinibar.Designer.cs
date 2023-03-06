namespace Otel.UI
{
    partial class FrmMinibar
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAdSoyad = new System.Windows.Forms.ComboBox();
            this.radioButtonEvet = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.nmrCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnCikisaGec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minibar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Adı Soyadı";
            // 
            // cmbAdSoyad
            // 
            this.cmbAdSoyad.FormattingEnabled = true;
            this.cmbAdSoyad.Location = new System.Drawing.Point(159, 29);
            this.cmbAdSoyad.Name = "cmbAdSoyad";
            this.cmbAdSoyad.Size = new System.Drawing.Size(173, 21);
            this.cmbAdSoyad.TabIndex = 2;
            // 
            // radioButtonEvet
            // 
            this.radioButtonEvet.AutoSize = true;
            this.radioButtonEvet.Location = new System.Drawing.Point(98, 100);
            this.radioButtonEvet.Name = "radioButtonEvet";
            this.radioButtonEvet.Size = new System.Drawing.Size(47, 17);
            this.radioButtonEvet.TabIndex = 3;
            this.radioButtonEvet.TabStop = true;
            this.radioButtonEvet.Text = "Evet";
            this.radioButtonEvet.UseVisualStyleBackColor = true;
            this.radioButtonEvet.CheckedChanged += new System.EventHandler(this.radioButtonEvet_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nmrCount
            // 
            this.nmrCount.Location = new System.Drawing.Point(333, 195);
            this.nmrCount.Name = "nmrCount";
            this.nmrCount.Size = new System.Drawing.Size(80, 20);
            this.nmrCount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kaç Adet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(27, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 293);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 240);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Toplam Tutar:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(414, 286);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(13, 13);
            this.lblToplam.TabIndex = 11;
            this.lblToplam.Text = "0";
            // 
            // btnCikisaGec
            // 
            this.btnCikisaGec.Location = new System.Drawing.Point(501, 239);
            this.btnCikisaGec.Name = "btnCikisaGec";
            this.btnCikisaGec.Size = new System.Drawing.Size(142, 20);
            this.btnCikisaGec.TabIndex = 12;
            this.btnCikisaGec.Text = "Otel Çıkışı";
            this.btnCikisaGec.UseVisualStyleBackColor = true;
            this.btnCikisaGec.Click += new System.EventHandler(this.btnCikisaGec_Click);
            // 
            // FrmMinibar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 441);
            this.Controls.Add(this.btnCikisaGec);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonEvet);
            this.Controls.Add(this.cmbAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMinibar";
            this.Text = "FrmMinibar";
            this.Load += new System.EventHandler(this.FrmMinibar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonEvet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nmrCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnCikisaGec;
        public System.Windows.Forms.ComboBox cmbAdSoyad;
    }
}