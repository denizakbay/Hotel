namespace Otel.UI
{
    partial class FrmOtelRapor
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
            this.cmbBul = new System.Windows.Forms.ComboBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.listViewRapor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı";
            // 
            // cmbBul
            // 
            this.cmbBul.FormattingEnabled = true;
            this.cmbBul.Location = new System.Drawing.Point(149, 22);
            this.cmbBul.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBul.Name = "cmbBul";
            this.cmbBul.Size = new System.Drawing.Size(140, 21);
            this.cmbBul.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(321, 22);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(88, 23);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(702, 22);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(88, 23);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri Adı";
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(520, 22);
            this.txtMusteriAra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(142, 20);
            this.txtMusteriAra.TabIndex = 6;
            // 
            // listViewRapor
            // 
            this.listViewRapor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewRapor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewRapor.HideSelection = false;
            this.listViewRapor.Location = new System.Drawing.Point(0, 232);
            this.listViewRapor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewRapor.Name = "listViewRapor";
            this.listViewRapor.Size = new System.Drawing.Size(925, 261);
            this.listViewRapor.TabIndex = 7;
            this.listViewRapor.UseCompatibleStateImageBehavior = false;
            this.listViewRapor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sıra";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı Soyadı";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kalacağı gün sayısı";
            this.columnHeader3.Width = 153;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kaldıgı Oda No";
            this.columnHeader4.Width = 141;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Oda Ücreti";
            this.columnHeader5.Width = 116;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Minibar Ücreti";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Toplam Tutar";
            this.columnHeader7.Width = 113;
            // 
            // FrmOtelRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 493);
            this.Controls.Add(this.listViewRapor);
            this.Controls.Add(this.txtMusteriAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.cmbBul);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmOtelRapor";
            this.Text = "FrmOtelRapor";
            this.Load += new System.EventHandler(this.FrmOtelRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.ListView listViewRapor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}