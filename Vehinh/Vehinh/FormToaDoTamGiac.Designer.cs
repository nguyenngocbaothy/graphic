namespace Vehinh
{
    partial class FormToaDoTamGiac
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
            this.label3 = new System.Windows.Forms.Label();
            this.dx = new System.Windows.Forms.TextBox();
            this.dy = new System.Windows.Forms.TextBox();
            this.dc = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rbTinhTien = new System.Windows.Forms.RadioButton();
            this.rbTiLe = new System.Windows.Forms.RadioButton();
            this.rbThu = new System.Windows.Forms.RadioButton();
            this.rbQuay = new System.Windows.Forms.RadioButton();
            this.rbDoiXung = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTT = new System.Windows.Forms.TextBox();
            this.tbyTT = new System.Windows.Forms.TextBox();
            this.tbTiLe = new System.Windows.Forms.TextBox();
            this.tbThu = new System.Windows.Forms.TextBox();
            this.tbQuay = new System.Windows.Forms.TextBox();
            this.tbDoiXung = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cạnh";
            // 
            // dx
            // 
            this.dx.Location = new System.Drawing.Point(53, 17);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(100, 20);
            this.dx.TabIndex = 3;
            // 
            // dy
            // 
            this.dy.Location = new System.Drawing.Point(53, 86);
            this.dy.Name = "dy";
            this.dy.Size = new System.Drawing.Size(100, 20);
            this.dy.TabIndex = 4;
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(53, 159);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(100, 20);
            this.dc.TabIndex = 5;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(126, 288);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(317, 289);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // rbTinhTien
            // 
            this.rbTinhTien.AutoSize = true;
            this.rbTinhTien.Location = new System.Drawing.Point(227, 18);
            this.rbTinhTien.Name = "rbTinhTien";
            this.rbTinhTien.Size = new System.Drawing.Size(70, 17);
            this.rbTinhTien.TabIndex = 8;
            this.rbTinhTien.TabStop = true;
            this.rbTinhTien.Text = "Tịnh Tiến";
            this.rbTinhTien.UseVisualStyleBackColor = true;
            // 
            // rbTiLe
            // 
            this.rbTiLe.AutoSize = true;
            this.rbTiLe.Location = new System.Drawing.Point(227, 63);
            this.rbTiLe.Name = "rbTiLe";
            this.rbTiLe.Size = new System.Drawing.Size(72, 17);
            this.rbTiLe.TabIndex = 9;
            this.rbTiLe.TabStop = true;
            this.rbTiLe.Text = "Phóng To";
            this.rbTiLe.UseVisualStyleBackColor = true;
            // 
            // rbThu
            // 
            this.rbThu.AutoSize = true;
            this.rbThu.Location = new System.Drawing.Point(227, 111);
            this.rbThu.Name = "rbThu";
            this.rbThu.Size = new System.Drawing.Size(67, 17);
            this.rbThu.TabIndex = 10;
            this.rbThu.TabStop = true;
            this.rbThu.Text = "Thu Nhỏ";
            this.rbThu.UseVisualStyleBackColor = true;
            // 
            // rbQuay
            // 
            this.rbQuay.AutoSize = true;
            this.rbQuay.Location = new System.Drawing.Point(227, 158);
            this.rbQuay.Name = "rbQuay";
            this.rbQuay.Size = new System.Drawing.Size(77, 17);
            this.rbQuay.TabIndex = 11;
            this.rbQuay.TabStop = true;
            this.rbQuay.Text = "Phép Xoay";
            this.rbQuay.UseVisualStyleBackColor = true;
            // 
            // rbDoiXung
            // 
            this.rbDoiXung.AutoSize = true;
            this.rbDoiXung.Location = new System.Drawing.Point(227, 206);
            this.rbDoiXung.Name = "rbDoiXung";
            this.rbDoiXung.Size = new System.Drawing.Size(313, 17);
            this.rbDoiXung.TabIndex = 12;
            this.rbDoiXung.TabStop = true;
            this.rbDoiXung.Text = "Đối Xứng (1: qua trục tung; 2: qua trục hoành; 3: trục tọa độ)";
            this.rbDoiXung.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(227, 253);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(66, 17);
            this.radioButton6.TabIndex = 13;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Bỏ Chọn";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Góc Quay(độ)";
            // 
            // tbxTT
            // 
            this.tbxTT.Location = new System.Drawing.Point(377, 17);
            this.tbxTT.Name = "tbxTT";
            this.tbxTT.Size = new System.Drawing.Size(100, 20);
            this.tbxTT.TabIndex = 17;
            // 
            // tbyTT
            // 
            this.tbyTT.Location = new System.Drawing.Point(565, 17);
            this.tbyTT.Name = "tbyTT";
            this.tbyTT.Size = new System.Drawing.Size(100, 20);
            this.tbyTT.TabIndex = 18;
            // 
            // tbTiLe
            // 
            this.tbTiLe.Location = new System.Drawing.Point(377, 62);
            this.tbTiLe.Name = "tbTiLe";
            this.tbTiLe.Size = new System.Drawing.Size(100, 20);
            this.tbTiLe.TabIndex = 19;
            // 
            // tbThu
            // 
            this.tbThu.Location = new System.Drawing.Point(377, 110);
            this.tbThu.Name = "tbThu";
            this.tbThu.Size = new System.Drawing.Size(100, 20);
            this.tbThu.TabIndex = 20;
            // 
            // tbQuay
            // 
            this.tbQuay.Location = new System.Drawing.Point(423, 156);
            this.tbQuay.Name = "tbQuay";
            this.tbQuay.Size = new System.Drawing.Size(100, 20);
            this.tbQuay.TabIndex = 21;
            // 
            // tbDoiXung
            // 
            this.tbDoiXung.Location = new System.Drawing.Point(565, 205);
            this.tbDoiXung.Name = "tbDoiXung";
            this.tbDoiXung.Size = new System.Drawing.Size(100, 20);
            this.tbDoiXung.TabIndex = 22;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(493, 288);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "+ xoay trái; - xoay phải";
            // 
            // FormToaDoTamGiac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 324);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.tbDoiXung);
            this.Controls.Add(this.tbQuay);
            this.Controls.Add(this.tbThu);
            this.Controls.Add(this.tbTiLe);
            this.Controls.Add(this.tbyTT);
            this.Controls.Add(this.tbxTT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.rbDoiXung);
            this.Controls.Add(this.rbQuay);
            this.Controls.Add(this.rbThu);
            this.Controls.Add(this.rbTiLe);
            this.Controls.Add(this.rbTinhTien);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.dy);
            this.Controls.Add(this.dx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormToaDoTamGiac";
            this.Text = "FormToaDoTamGiac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dx;
        private System.Windows.Forms.TextBox dy;
        private System.Windows.Forms.TextBox dc;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.RadioButton rbTinhTien;
        private System.Windows.Forms.RadioButton rbTiLe;
        private System.Windows.Forms.RadioButton rbThu;
        private System.Windows.Forms.RadioButton rbQuay;
        private System.Windows.Forms.RadioButton rbDoiXung;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTT;
        private System.Windows.Forms.TextBox tbyTT;
        private System.Windows.Forms.TextBox tbTiLe;
        private System.Windows.Forms.TextBox tbThu;
        private System.Windows.Forms.TextBox tbQuay;
        private System.Windows.Forms.TextBox tbDoiXung;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label7;
    }
}