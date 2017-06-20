namespace Vehinh
{
    partial class FormToaDoHinhThap
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
            this.label4 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.TextBox();
            this.dr = new System.Windows.Forms.TextBox();
            this.dc = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dx = new System.Windows.Forms.TextBox();
            this.dy = new System.Windows.Forms.TextBox();
            this.dz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dài";
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Location = new System.Drawing.Point(318, 94);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(33, 13);
            this.tb.TabIndex = 4;
            this.tb.Text = "Rộng";
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.Location = new System.Drawing.Point(318, 152);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(26, 13);
            this.tc.TabIndex = 5;
            this.tc.Text = "Cao";
            // 
            // dd
            // 
            this.dd.Location = new System.Drawing.Point(386, 38);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(100, 20);
            this.dd.TabIndex = 9;
            // 
            // dr
            // 
            this.dr.Location = new System.Drawing.Point(386, 91);
            this.dr.Name = "dr";
            this.dr.Size = new System.Drawing.Size(100, 20);
            this.dr.TabIndex = 10;
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(386, 145);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(100, 20);
            this.dc.TabIndex = 11;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(104, 226);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 12;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(321, 226);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Z";
            // 
            // dx
            // 
            this.dx.Location = new System.Drawing.Point(79, 42);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(100, 20);
            this.dx.TabIndex = 1;
            // 
            // dy
            // 
            this.dy.Location = new System.Drawing.Point(79, 91);
            this.dy.Name = "dy";
            this.dy.Size = new System.Drawing.Size(100, 20);
            this.dy.TabIndex = 2;
            // 
            // dz
            // 
            this.dz.Location = new System.Drawing.Point(79, 149);
            this.dz.Name = "dz";
            this.dz.Size = new System.Drawing.Size(100, 20);
            this.dz.TabIndex = 3;
            // 
            // FormToaDoHinhThap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.dz);
            this.Controls.Add(this.dy);
            this.Controls.Add(this.dx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.dr);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label4);
            this.Name = "FormToaDoHinhThap";
            this.Text = "FormToaDoHinhThap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.TextBox dd;
        private System.Windows.Forms.TextBox dr;
        private System.Windows.Forms.TextBox dc;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dx;
        private System.Windows.Forms.TextBox dy;
        private System.Windows.Forms.TextBox dz;
    }
}