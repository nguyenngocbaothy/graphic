namespace Vehinh
{
    partial class FormToaDoHinhHop
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
            this.label4 = new System.Windows.Forms.Label();
            this.tv = new System.Windows.Forms.Label();
            this.sdas = new System.Windows.Forms.Label();
            this.dx = new System.Windows.Forms.TextBox();
            this.dy = new System.Windows.Forms.TextBox();
            this.dz = new System.Windows.Forms.TextBox();
            this.dc = new System.Windows.Forms.TextBox();
            this.dd = new System.Windows.Forms.TextBox();
            this.dr = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cao";
            // 
            // tv
            // 
            this.tv.AutoSize = true;
            this.tv.Location = new System.Drawing.Point(263, 86);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(23, 13);
            this.tv.TabIndex = 4;
            this.tv.Text = "Dài";
            // 
            // sdas
            // 
            this.sdas.AutoSize = true;
            this.sdas.Location = new System.Drawing.Point(263, 154);
            this.sdas.Name = "sdas";
            this.sdas.Size = new System.Drawing.Size(33, 13);
            this.sdas.TabIndex = 5;
            this.sdas.Text = "Rộng";
            // 
            // dx
            // 
            this.dx.Location = new System.Drawing.Point(82, 20);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(100, 20);
            this.dx.TabIndex = 6;
            // 
            // dy
            // 
            this.dy.Location = new System.Drawing.Point(82, 83);
            this.dy.Name = "dy";
            this.dy.Size = new System.Drawing.Size(100, 20);
            this.dy.TabIndex = 7;
            // 
            // dz
            // 
            this.dz.Location = new System.Drawing.Point(82, 151);
            this.dz.Name = "dz";
            this.dz.Size = new System.Drawing.Size(100, 20);
            this.dz.TabIndex = 8;
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(350, 20);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(100, 20);
            this.dc.TabIndex = 9;
            // 
            // dd
            // 
            this.dd.Location = new System.Drawing.Point(350, 83);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(100, 20);
            this.dd.TabIndex = 10;
            // 
            // dr
            // 
            this.dr.Location = new System.Drawing.Point(350, 151);
            this.dr.Name = "dr";
            this.dr.Size = new System.Drawing.Size(100, 20);
            this.dr.TabIndex = 11;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(152, 226);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 12;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(306, 226);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FormToaDoHinhHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 261);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dr);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.dz);
            this.Controls.Add(this.dy);
            this.Controls.Add(this.dx);
            this.Controls.Add(this.sdas);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormToaDoHinhHop";
            this.Text = "FormToaDoHinhHop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tv;
        private System.Windows.Forms.Label sdas;
        private System.Windows.Forms.TextBox dx;
        private System.Windows.Forms.TextBox dy;
        private System.Windows.Forms.TextBox dz;
        private System.Windows.Forms.TextBox dc;
        private System.Windows.Forms.TextBox dd;
        private System.Windows.Forms.TextBox dr;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}