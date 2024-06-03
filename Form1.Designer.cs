namespace CSharp_tínhđiểmtb
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
            this.btntinhtrungbinh = new System.Windows.Forms.Button();
            this.lblten = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txttb = new System.Windows.Forms.TextBox();
            this.txttoan = new System.Windows.Forms.TextBox();
            this.txtvan = new System.Windows.Forms.TextBox();
            this.lblvan = new System.Windows.Forms.Label();
            this.lbltoan = new System.Windows.Forms.Label();
            this.lbltb = new System.Windows.Forms.Label();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.lblxeploai = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntinhtrungbinh
            // 
            this.btntinhtrungbinh.Location = new System.Drawing.Point(137, 362);
            this.btntinhtrungbinh.Name = "btntinhtrungbinh";
            this.btntinhtrungbinh.Size = new System.Drawing.Size(159, 23);
            this.btntinhtrungbinh.TabIndex = 0;
            this.btntinhtrungbinh.Text = "Tính Trung Bình";
            this.btntinhtrungbinh.UseVisualStyleBackColor = true;
            this.btntinhtrungbinh.Click += new System.EventHandler(this.btntinhtrungbinh_Click);
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(71, 46);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(22, 13);
            this.lblten.TabIndex = 1;
            this.lblten.Text = "tên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txttb
            // 
            this.txttb.Location = new System.Drawing.Point(277, 202);
            this.txttb.Name = "txttb";
            this.txttb.Size = new System.Drawing.Size(100, 20);
            this.txttb.TabIndex = 5;
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(277, 157);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(100, 20);
            this.txttoan.TabIndex = 6;
            // 
            // txtvan
            // 
            this.txtvan.Location = new System.Drawing.Point(277, 113);
            this.txtvan.Name = "txtvan";
            this.txtvan.Size = new System.Drawing.Size(100, 20);
            this.txtvan.TabIndex = 7;
            // 
            // lblvan
            // 
            this.lblvan.AutoSize = true;
            this.lblvan.Location = new System.Drawing.Point(70, 98);
            this.lblvan.Name = "lblvan";
            this.lblvan.Size = new System.Drawing.Size(26, 13);
            this.lblvan.TabIndex = 8;
            this.lblvan.Text = "Văn";
            // 
            // lbltoan
            // 
            this.lbltoan.AutoSize = true;
            this.lbltoan.Location = new System.Drawing.Point(71, 157);
            this.lbltoan.Name = "lbltoan";
            this.lbltoan.Size = new System.Drawing.Size(28, 13);
            this.lbltoan.TabIndex = 9;
            this.lbltoan.Text = "toán";
            // 
            // lbltb
            // 
            this.lbltb.AutoSize = true;
            this.lbltb.Location = new System.Drawing.Point(71, 209);
            this.lbltb.Name = "lbltb";
            this.lbltb.Size = new System.Drawing.Size(58, 13);
            this.lbltb.TabIndex = 10;
            this.lbltb.Text = "Trung bình";
            // 
            // txtxeploai
            // 
            this.txtxeploai.Location = new System.Drawing.Point(277, 249);
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(100, 20);
            this.txtxeploai.TabIndex = 3;
            // 
            // lblxeploai
            // 
            this.lblxeploai.AutoSize = true;
            this.lblxeploai.Location = new System.Drawing.Point(71, 256);
            this.lblxeploai.Name = "lblxeploai";
            this.lblxeploai.Size = new System.Drawing.Size(43, 13);
            this.lblxeploai.TabIndex = 11;
            this.lblxeploai.Text = "xếp loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "tính Trung bình";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(635, 377);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(122, 23);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblxeploai);
            this.Controls.Add(this.lbltb);
            this.Controls.Add(this.lbltoan);
            this.Controls.Add(this.lblvan);
            this.Controls.Add(this.txtvan);
            this.Controls.Add(this.txttoan);
            this.Controls.Add(this.txttb);
            this.Controls.Add(this.txtxeploai);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.btntinhtrungbinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinhtrungbinh;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txttb;
        private System.Windows.Forms.TextBox txttoan;
        private System.Windows.Forms.TextBox txtvan;
        private System.Windows.Forms.Label lblvan;
        private System.Windows.Forms.Label lbltoan;
        private System.Windows.Forms.Label lbltb;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.Label lblxeploai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthoat;
    }
}

