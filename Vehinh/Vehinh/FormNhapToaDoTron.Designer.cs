namespace Vehinh
{
    partial class FormNhapToaDoTron
    {
        public string textValue = "";
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
            this.tbTronX = new System.Windows.Forms.TextBox();
            this.tbTronBK = new System.Windows.Forms.TextBox();
            this.tbTronY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbTinhTien = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbyTT = new System.Windows.Forms.TextBox();
            this.rbTiLe = new System.Windows.Forms.RadioButton();
            this.tbTiLe = new System.Windows.Forms.TextBox();
            this.rbQuay = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuay = new System.Windows.Forms.TextBox();
            this.rbDoiXung = new System.Windows.Forms.RadioButton();
            this.tbDoiXung = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbThu = new System.Windows.Forms.RadioButton();
            this.tbThu = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap toa do x: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bán Kính: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhap toa do y: ";
            // 
            // tbTronX
            // 
            this.tbTronX.Location = new System.Drawing.Point(110, 15);
            this.tbTronX.Name = "tbTronX";
            this.tbTronX.Size = new System.Drawing.Size(100, 20);
            this.tbTronX.TabIndex = 3;
            // 
            // tbTronBK
            // 
            this.tbTronBK.Location = new System.Drawing.Point(110, 146);
            this.tbTronBK.Name = "tbTronBK";
            this.tbTronBK.Size = new System.Drawing.Size(100, 20);
            this.tbTronBK.TabIndex = 5;
            // 
            // tbTronY
            // 
            this.tbTronY.Location = new System.Drawing.Point(110, 82);
            this.tbTronY.Name = "tbTronY";
            this.tbTronY.Size = new System.Drawing.Size(100, 20);
            this.tbTronY.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(157, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rbTinhTien
            // 
            this.rbTinhTien.AutoSize = true;
            this.rbTinhTien.Location = new System.Drawing.Point(268, 21);
            this.rbTinhTien.Name = "rbTinhTien";
            this.rbTinhTien.Size = new System.Drawing.Size(70, 17);
            this.rbTinhTien.TabIndex = 20;
            this.rbTinhTien.TabStop = true;
            this.rbTinhTien.Text = "Tịnh Tiến";
            this.rbTinhTien.UseVisualStyleBackColor = true;
            this.rbTinhTien.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "x";
            // 
            // tbxTT
            // 
            this.tbxTT.Location = new System.Drawing.Point(446, 20);
            this.tbxTT.Name = "tbxTT";
            this.tbxTT.Size = new System.Drawing.Size(100, 20);
            this.tbxTT.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "y";
            // 
            // tbyTT
            // 
            this.tbyTT.Location = new System.Drawing.Point(646, 20);
            this.tbyTT.Name = "tbyTT";
            this.tbyTT.Size = new System.Drawing.Size(100, 20);
            this.tbyTT.TabIndex = 24;
            // 
            // rbTiLe
            // 
            this.rbTiLe.AutoSize = true;
            this.rbTiLe.Location = new System.Drawing.Point(268, 70);
            this.rbTiLe.Name = "rbTiLe";
            this.rbTiLe.Size = new System.Drawing.Size(72, 17);
            this.rbTiLe.TabIndex = 25;
            this.rbTiLe.TabStop = true;
            this.rbTiLe.Text = "Phóng To";
            this.rbTiLe.UseVisualStyleBackColor = true;
            // 
            // tbTiLe
            // 
            this.tbTiLe.Location = new System.Drawing.Point(446, 69);
            this.tbTiLe.Name = "tbTiLe";
            this.tbTiLe.Size = new System.Drawing.Size(100, 20);
            this.tbTiLe.TabIndex = 27;
            // 
            // rbQuay
            // 
            this.rbQuay.AutoSize = true;
            this.rbQuay.Location = new System.Drawing.Point(268, 147);
            this.rbQuay.Name = "rbQuay";
            this.rbQuay.Size = new System.Drawing.Size(78, 17);
            this.rbQuay.TabIndex = 28;
            this.rbQuay.TabStop = true;
            this.rbQuay.Text = "Phép Quay";
            this.rbQuay.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Góc Quay (độ)";
            // 
            // tbQuay
            // 
            this.tbQuay.Location = new System.Drawing.Point(468, 146);
            this.tbQuay.Name = "tbQuay";
            this.tbQuay.Size = new System.Drawing.Size(100, 20);
            this.tbQuay.TabIndex = 30;
            // 
            // rbDoiXung
            // 
            this.rbDoiXung.AutoSize = true;
            this.rbDoiXung.Location = new System.Drawing.Point(268, 192);
            this.rbDoiXung.Name = "rbDoiXung";
            this.rbDoiXung.Size = new System.Drawing.Size(313, 17);
            this.rbDoiXung.TabIndex = 31;
            this.rbDoiXung.TabStop = true;
            this.rbDoiXung.Text = "Đối Xứng (1: qua trục hoành; 2: qua trục tung; 3: trục tọa độ)";
            this.rbDoiXung.UseVisualStyleBackColor = true;
            // 
            // tbDoiXung
            // 
            this.tbDoiXung.Location = new System.Drawing.Point(646, 191);
            this.tbDoiXung.Name = "tbDoiXung";
            this.tbDoiXung.Size = new System.Drawing.Size(100, 20);
            this.tbDoiXung.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(358, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(268, 234);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bỏ Chọn";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbThu
            // 
            this.rbThu.AutoSize = true;
            this.rbThu.Location = new System.Drawing.Point(268, 108);
            this.rbThu.Name = "rbThu";
            this.rbThu.Size = new System.Drawing.Size(67, 17);
            this.rbThu.TabIndex = 35;
            this.rbThu.TabStop = true;
            this.rbThu.Text = "Thu Nhỏ";
            this.rbThu.UseVisualStyleBackColor = true;
            // 
            // tbThu
            // 
            this.tbThu.Location = new System.Drawing.Point(446, 107);
            this.tbThu.Name = "tbThu";
            this.tbThu.Size = new System.Drawing.Size(100, 20);
            this.tbThu.TabIndex = 36;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(559, 326);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 37;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "+ xoay trái; - xoay phải";
            // 
            // FormNhapToaDoTron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 377);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.tbThu);
            this.Controls.Add(this.rbThu);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbDoiXung);
            this.Controls.Add(this.rbDoiXung);
            this.Controls.Add(this.tbQuay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbQuay);
            this.Controls.Add(this.tbTiLe);
            this.Controls.Add(this.rbTiLe);
            this.Controls.Add(this.tbyTT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxTT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbTinhTien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTronY);
            this.Controls.Add(this.tbTronBK);
            this.Controls.Add(this.tbTronX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhapToaDoTron";
            this.Text = "FormNhapToaDoTron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTronX;
        private System.Windows.Forms.TextBox tbTronBK;
        private System.Windows.Forms.TextBox tbTronY;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbTinhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbyTT;
        private System.Windows.Forms.RadioButton rbTiLe;
        private System.Windows.Forms.TextBox tbTiLe;
        private System.Windows.Forms.RadioButton rbQuay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQuay;
        private System.Windows.Forms.RadioButton rbDoiXung;
        private System.Windows.Forms.TextBox tbDoiXung;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbThu;
        private System.Windows.Forms.TextBox tbThu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label6;
    }
}