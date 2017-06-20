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
    public partial class FormNhapToaDoEllip : Form
    {
        public FormNhapToaDoEllip()
        {
            InitializeComponent();
        }
        int x, y, w, h;
        int xc, yc, wc, hc;
        public bool check = false;



        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public int getW()
        {
            return w;
        }

        public int getH()
        {
            return h;
        }

        //----------------------------------------------------------------------    

        public int getXC()
        {
            return xc;
        }

        public int getYC()
        {
            return yc;
        }

        public int getWC()
        {
            return wc;
        }

        public int getHC()
        {
            return hc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tinh tien
            if (rbTinhTien.Checked)
            {
                // chua xoa dc hinh cu
                if (dx.Text == "" && dy.Text == "" && dw.Text == "" && dh.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");

                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(dx.Text);
                    yc = Convert.ToInt32(dy.Text);
                    hc = Convert.ToInt32(dh.Text);
                    wc = Convert.ToInt32(dw.Text);


                    x = Int32.Parse(tbxTT.Text);
                    y = Int32.Parse(tbyTT.Text);
                    w = Int32.Parse(dw.Text);
                    h = Int32.Parse(dh.Text);


                    MessageBox.Show("hinh da duoc tinh tien ");
                }
            }
            else if (rbTiLe.Checked) // phep ti le (phong to)
            {
                if (dx.Text == "" && dy.Text == "" && dw.Text == "" && dh.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    /*x = Int32.Parse(tbTronX.Text);
                    y = Int32.Parse(tbTronY.Text);
                    bk = Convert.ToInt32(tbTronBK.Text) * Convert.ToInt32(tbTiLe.Text);*/
                    check = true;
                    xc = Convert.ToInt32(dx.Text);
                    yc = Convert.ToInt32(dy.Text);
                    hc = Convert.ToInt32(dh.Text);
                    wc = Convert.ToInt32(dw.Text);

                    x = Int32.Parse(dx.Text);
                    y = Int32.Parse(dy.Text);
                    w = Convert.ToInt32(dw.Text) * Convert.ToInt32(tbTiLe.Text);
                    h = Convert.ToInt32(dh.Text) * Convert.ToInt32(tbTiLe.Text);


                    if (Int32.Parse(tbTiLe.Text) > 1)
                    {
                        MessageBox.Show("hinh da duoc phong to ");
                    }
                    if (Int32.Parse(tbTiLe.Text) == 1)
                    {
                        MessageBox.Show("hinh dong dang voi hinh cu ");
                    }

                }
            }
            else if (rbThu.Checked) // thu
            {
                if (dx.Text == "" && dy.Text == "" && dw.Text == "" && dh.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(dx.Text);
                    yc = Convert.ToInt32(dy.Text);
                    hc = Convert.ToInt32(dh.Text);
                    wc = Convert.ToInt32(dw.Text);

                    x = Int32.Parse(dx.Text);
                    y = Int32.Parse(dy.Text);
                    w = Convert.ToInt32(dw.Text) / Convert.ToInt32(tbThu.Text);
                    h = Convert.ToInt32(dh.Text) / Convert.ToInt32(tbThu.Text);


                    if (Int32.Parse(tbThu.Text) > 1)
                    {
                        MessageBox.Show("hinh da duoc thu nho ");
                    }
                    if (Int32.Parse(tbThu.Text) == 1)
                    {
                        MessageBox.Show("hinh dong dang voi hinh cu ");
                    }

                }
            }
            else if (rbDoiXung.Checked) // phep doi xung
            {
                if (dx.Text == "" && dy.Text == "" && dw.Text == "" && dh.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(dx.Text);
                    yc = Convert.ToInt32(dy.Text);
                    hc = Convert.ToInt32(dh.Text);
                    wc = Convert.ToInt32(dw.Text);

                    int luachon = Convert.ToInt32(tbDoiXung.Text);
                    switch (luachon)
                    {
                        case 1:
                            x = Int32.Parse(dx.Text) * -1;
                            y = Int32.Parse(dy.Text);
                            w = Int32.Parse(dw.Text);
                            h = Int32.Parse(dh.Text);
                            break;
                        case 2:
                            x = Int32.Parse(dx.Text);
                            y = Int32.Parse(dy.Text) * -1;
                            w = Int32.Parse(dw.Text);
                            h = Int32.Parse(dh.Text);
                            break;
                        case 3:
                            x = Int32.Parse(dx.Text) * -1;
                            y = Int32.Parse(dy.Text) * -1;
                            w = Int32.Parse(dw.Text);
                            h = Int32.Parse(dh.Text);
                            break;
                        default:
                            MessageBox.Show("Vui long nhap so hop le");
                            break;
                    }
                }
            }
            else if (rbQuay.Checked) // phep quay
            {
                if (dx.Text == "" && dy.Text == "" && dw.Text == "" && dh.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do x, y, ban kinh cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(dx.Text);
                    yc = Convert.ToInt32(dy.Text);
                    hc = Convert.ToInt32(dh.Text);
                    wc = Convert.ToInt32(dw.Text);

                    double rad = Int32.Parse(tbQuay.Text) * Math.PI / 180;
                    double cosa = Math.Cos(rad);
                    double sina = Math.Sin(rad);
                    /*x = Int32.Parse(tbTronX.Text) * (int)Math.Round(cosa) - Int32.Parse(tbTronY.Text) * (int)Math.Round(sina);
                      y = Int32.Parse(tbTronX.Text) * (int)Math.Round(sina) + Int32.Parse(tbTronY.Text) * (int)Math.Round(cosa);
                    bk = Convert.ToInt32(tbTronBK.Text);*/
                    // k ra
                    w = Int32.Parse(dw.Text) * (int)Math.Round(cosa) - Int32.Parse(dh.Text) * (int)Math.Round(sina);
                    h = Int32.Parse(dw.Text) * (int)Math.Round(sina) + Int32.Parse(dh.Text) * (int)Math.Round(cosa);
                    x = Convert.ToInt32(dx.Text);
                    y = Convert.ToInt32(dy.Text);
                    // MessageBox.Show("da lay bien x " + x + " " + y);


                }
            }
            else
            {
                x = Int32.Parse(dx.Text);
                y = Int32.Parse(dy.Text);
                w = Int32.Parse(dw.Text);
                h = Int32.Parse(dh.Text);
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void rbTinhTien_CheckedChanged(object sender, EventArgs e)
        {
            
            tbxTT.Visible = true;
            tbyTT.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
        private void rbTinhTien_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void rbTinhTien_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rbTiLe_CheckedChanged(object sender, EventArgs e)
        {
            tbTiLe.Visible = true;
        }

        private void rbDoiXung_CheckedChanged(object sender, EventArgs e)
        {
            tbDoiXung.Visible = true;
        }

        private void rbQuay_CheckedChanged(object sender, EventArgs e)
        {
            tbQuay.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void xoa()
        {
            x = Int32.Parse(dx.Text);
            y = Int32.Parse(dy.Text);
            w = Int32.Parse(dw.Text);
            h = Int32.Parse(dh.Text);
            this.DialogResult = DialogResult.Yes;
            this.Close();
            MessageBox.Show("Hình đã được xóa");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

    }
}
