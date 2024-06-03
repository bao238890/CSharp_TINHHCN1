namespace CSharp_TINHHCN1
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
            this.btnChuvi = new System.Windows.Forms.Button();
            this.lbla = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDientich = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbChuvi = new System.Windows.Forms.RadioButton();
            this.rdbDientich = new System.Windows.Forms.RadioButton();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChuvi
            // 
            this.btnChuvi.Location = new System.Drawing.Point(203, 214);
            this.btnChuvi.Name = "btnChuvi";
            this.btnChuvi.Size = new System.Drawing.Size(75, 23);
            this.btnChuvi.TabIndex = 0;
            this.btnChuvi.Text = "Chu vi";
            this.btnChuvi.UseVisualStyleBackColor = true;
            this.btnChuvi.Click += new System.EventHandler(this.btnChuvi_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(200, 102);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(42, 13);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "Nhập a";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(277, 102);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 2;
            this.txta.Text = "5";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(277, 132);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 4;
            this.txtb.Text = "66";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(200, 135);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(42, 13);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "Nhập b";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(277, 163);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 6;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(200, 170);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(44, 13);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TÍNH CHU VI VÀ DIỆN TÍCH HÌNH CHỮ NHẬT";
            // 
            // btnDientich
            // 
            this.btnDientich.Location = new System.Drawing.Point(331, 214);
            this.btnDientich.Name = "btnDientich";
            this.btnDientich.Size = new System.Drawing.Size(75, 23);
            this.btnDientich.TabIndex = 8;
            this.btnDientich.Text = "Diện tich";
            this.btnDientich.UseVisualStyleBackColor = true;
            this.btnDientich.Click += new System.EventHandler(this.btnDientich_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(331, 268);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDientich);
            this.groupBox1.Controls.Add(this.rdbChuvi);
            this.groupBox1.Location = new System.Drawing.Point(527, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 135);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbChuvi
            // 
            this.rdbChuvi.AutoSize = true;
            this.rdbChuvi.Location = new System.Drawing.Point(24, 32);
            this.rdbChuvi.Name = "rdbChuvi";
            this.rdbChuvi.Size = new System.Drawing.Size(55, 17);
            this.rdbChuvi.TabIndex = 0;
            this.rdbChuvi.TabStop = true;
            this.rdbChuvi.Text = "Chu vi";
            this.rdbChuvi.UseVisualStyleBackColor = true;
            this.rdbChuvi.CheckedChanged += new System.EventHandler(this.rdbChuvi_CheckedChanged);
            // 
            // rdbDientich
            // 
            this.rdbDientich.AutoSize = true;
            this.rdbDientich.Location = new System.Drawing.Point(24, 62);
            this.rdbDientich.Name = "rdbDientich";
            this.rdbDientich.Size = new System.Drawing.Size(69, 17);
            this.rdbDientich.TabIndex = 1;
            this.rdbDientich.TabStop = true;
            this.rdbDientich.Text = "Diện tích";
            this.rdbDientich.UseVisualStyleBackColor = true;
            this.rdbDientich.CheckedChanged += new System.EventHandler(this.rdbDientich_CheckedChanged);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(576, 259);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(94, 32);
            this.btnTinh.TabIndex = 11;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDientich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.btnChuvi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChuvi;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDientich;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDientich;
        private System.Windows.Forms.RadioButton rdbChuvi;
        private System.Windows.Forms.Button btnTinh;
    }
}

