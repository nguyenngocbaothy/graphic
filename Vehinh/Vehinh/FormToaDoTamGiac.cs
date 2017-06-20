using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehinh
{
    public partial class FormToaDoTamGiac : Form
    {
        public FormToaDoTamGiac()
        {
            InitializeComponent();
        }
        int x, y, c;
        int xc, yc, cc;
        public bool check = false;
        public int chedotamgiac = 0;

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }


        public int getC()
        {
            return c;
        }


        //-----------------------------------------------------------------------
        public int getXC()
        {
            return xc;
        }

        
        public int getYC()
        {
            return yc;
        }

        public int getCC()
        {
            return cc;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            // tinh tien
            if (rbTinhTien.Checked)
            {
                // chua xoa dc hinh cu
                if (dx.Text == "" && dy.Text == "" && dc.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");

                }
                else
                {
                    try
                    {
                        check = true;
                        xc = Convert.ToInt32(dx.Text);
                        yc = Convert.ToInt32(dy.Text);
                        cc = Convert.ToInt32(dc.Text);

                        x = Convert.ToInt32(tbxTT.Text);
                        y = Convert.ToInt32(tbyTT.Text);
                        c = Convert.ToInt32(dc.Text);
                    }
                    catch
                    {
                        MessageBox.Show("nhap toa do khong hop le. Vui long nhap lai");
                    }
                    MessageBox.Show("hinh da duoc tinh tien x = " + x + " ,y =  " + y);
                }
            }
            else if (rbTiLe.Checked) // phep ti le (phong to)
            {
                if (dx.Text == "" && dy.Text == "" && dc.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do x, y, ban kinh cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(dx.Text);
                    yc = Convert.ToInt32(dy.Text);
                    cc = Convert.ToInt32(dc.Text);

                    x = Int32.Parse(dx.Text);
                    y = Int32.Parse(dy.Text);
                    c = Convert.ToInt32(dc.Text) * Convert.ToInt32(tbTiLe.Text);

                    if (Int32.Parse(tbTiLe.Text) > 1)
                    {
                        MessageBox.Show("hinh da duoc phong to");
                    }
                    if (Int32.Parse(tbTiLe.Text) == 1)
                    {
                        MessageBox.Show("hinh dong dang voi hinh cu");
                    }

                }
            }
            else if (rbThu.Checked) // thu
            {
                if (dx.Text == "" && dy.Text == "" && dc.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do x, y, ban kinh cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(dx.Text);
                    yc = Convert.ToInt32(dy.Text);
                    cc = Convert.ToInt32(dc.Text);

                    x = Int32.Parse(dx.Text);
                    y = Int32.Parse(dy.Text);
                    c = Convert.ToInt32(dc.Text) / Convert.ToInt32(tbThu.Text);

                    if (Int32.Parse(tbThu.Text) > 1)
                    {
                        MessageBox.Show("hinh da duoc thu nho");
                    }
                    if (Int32.Parse(tbThu.Text) == 1)
                    {
                        MessageBox.Show("hinh dong dang voi hinh cu");
                    }

                }
            }
            else if (rbDoiXung.Checked) // phep doi xung
            {
                if (dx.Text == "" && dy.Text == "" && dc.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(dx.Text);
                    yc = Convert.ToInt32(dy.Text);
                    cc = Convert.ToInt32(dc.Text);                  

                    int luachon = Convert.ToInt32(tbDoiXung.Text);
                    switch (luachon)
                    {
                        case 1:
                            x = Int32.Parse(dx.Text) * -1;
                            y = Int32.Parse(dy.Text);
                            c = Convert.ToInt32(dc.Text);
                            chedotamgiac = 1;
                            break;
                        case 2:
                            x = Int32.Parse(dx.Text);
                            y = Int32.Parse(dy.Text) * -1;
                            c = Convert.ToInt32(dc.Text);
                            chedotamgiac = 2;
                            break;
                        case 3:
                            x = Int32.Parse(dx.Text) * -1;
                            y = Int32.Parse(dy.Text) * -1;
                            c = Convert.ToInt32(dc.Text);
                            chedotamgiac = 3;
                            break;
                        default:
                            MessageBox.Show("Vui long nhap so hop le");
                            break;
                    }
                }
            }
            else if (rbQuay.Checked) // phep quay
            {
                if (dx.Text == "" && dy.Text == "" && dc.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(dx.Text);
                    yc = Convert.ToInt32(dy.Text);
                    cc = Convert.ToInt32(dc.Text);

                    int k = Convert.ToInt32(tbQuay.Text);
                    if (k>0)
                    {
                        if (k < 90) chedotamgiac = 0;
                        else if (k < 180) chedotamgiac = 1;
                        else if (k < 270) chedotamgiac = 3;
                        else if(k < 360) chedotamgiac = 2;
                    }
                    else
                    {
                        if (k > -90) chedotamgiac = 0;
                        else if (k > -180) chedotamgiac = 2;
                        else if (k > -270) chedotamgiac = 3;
                        else if (k > -360) chedotamgiac = 1;

                    }
                    double rad = k * Math.PI / 180;                    
                    double cosa = Math.Cos(rad);
                    double sina = Math.Sin(rad);
                    x = Int32.Parse(dx.Text) * (int)Math.Round(cosa) - Int32.Parse(dy.Text) * (int)Math.Round(sina);
                    y = Int32.Parse(dx.Text) * (int)Math.Round(sina) + Int32.Parse(dy.Text) * (int)Math.Round(cosa);
                    c = Convert.ToInt32(dc.Text);
                    

                }
            }
            else
            {
                x = Int32.Parse(dx.Text);
                y = Int32.Parse(dy.Text);
                c = Int32.Parse(dc.Text);
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void xoa()
        {
            x = Int32.Parse(dx.Text);
            y = Int32.Parse(dy.Text);
            c = Int32.Parse(dc.Text);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

    }

}
