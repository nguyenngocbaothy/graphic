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
    public partial class FormNhapToaDoTron : Form
    {
        int x, y, bk;
        int xc, yc, bkc;
        public bool check = false;

        public FormNhapToaDoTron()
        {
            InitializeComponent();
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public int getBK()
        {
            return bk;
        }

        public int getXC()
        {
            return xc;
        }

        public int getYC()
        {
            return yc;
        }

        public int getBKC()
        {
            return bkc;
        }


        public void button1_Click_1(object sender, EventArgs e)
        {
            // tinh tien
            if (rbTinhTien.Checked)
            {
                // chua xoa dc hinh cu
                if (tbTronX.Text == "" && tbTronY.Text == "" && tbTronBK.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do x, y, ban kinh cho hinh");
                    // ShowDialog();
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(tbTronX.Text);
                    yc = Convert.ToInt32(tbTronY.Text);
                    bkc = Convert.ToInt32(tbTronBK.Text);

                    x = Convert.ToInt32(tbxTT.Text);
                    y = Convert.ToInt32(tbyTT.Text);
                    bk = Int32.Parse(tbTronBK.Text);

                    MessageBox.Show("hinh da duoc tinh tien x = " + x + " ,y =  " + y);
                }
            }
            else if (rbTiLe.Checked) // phep ti le (phong to)
            {
                if (tbTronX.Text == "" && tbTronY.Text == "" && tbTronBK.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do x, y, ban kinh cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(tbTronX.Text);
                    yc = Convert.ToInt32(tbTronY.Text);
                    bkc = Convert.ToInt32(tbTronBK.Text);

                    x = Int32.Parse(tbTronX.Text);
                    y = Int32.Parse(tbTronY.Text);
                    bk = Convert.ToInt32(tbTronBK.Text) * Convert.ToInt32(tbTiLe.Text);

                    if (Int32.Parse(tbTiLe.Text) > 1)
                    {
                        MessageBox.Show("hinh da duoc phong to");
                    }
                    if (Int32.Parse(tbTiLe.Text) == 1)
                    {
                        MessageBox.Show("hinh dong dang voi hinh cu r = " + bk);
                    }

                }
            }
            else if (rbThu.Checked) // thu
            {
                if (tbTronX.Text == "" && tbTronY.Text == "" && tbTronBK.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do x, y, ban kinh cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(tbTronX.Text);
                    yc = Convert.ToInt32(tbTronY.Text);
                    bkc = Convert.ToInt32(tbTronBK.Text);

                    x = Int32.Parse(tbTronX.Text);
                    y = Int32.Parse(tbTronY.Text);
                    bk = Convert.ToInt32(tbTronBK.Text) / Convert.ToInt32(tbThu.Text);

                    if (Int32.Parse(tbThu.Text) > 1)
                    {
                        MessageBox.Show("hinh da duoc thu nho ");
                    }
                    if (Int32.Parse(tbThu.Text) == 1)
                    {
                        MessageBox.Show("hinh dong dang voi hinh cu");
                    }

                }
            }
            else if (rbDoiXung.Checked) // phep doi xung
            {
                if (tbTronX.Text == "" && tbTronY.Text == "" && tbTronBK.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(tbTronX.Text);
                    yc = Convert.ToInt32(tbTronY.Text);
                    bkc = Convert.ToInt32(tbTronBK.Text);

                    int luachon = Convert.ToInt32(tbDoiXung.Text);
                    switch (luachon)
                    {
                        case 1:
                            x = Int32.Parse(tbTronX.Text) * -1;
                            y = Int32.Parse(tbTronY.Text);
                            bk = Convert.ToInt32(tbTronBK.Text);
                            break;
                        case 2:
                            x = Int32.Parse(tbTronX.Text);
                            y = Int32.Parse(tbTronY.Text) * -1;
                            bk = Convert.ToInt32(tbTronBK.Text);
                            break;
                        case 3:
                            x = Int32.Parse(tbTronX.Text) * -1;
                            y = Int32.Parse(tbTronY.Text) * -1;
                            bk = Convert.ToInt32(tbTronBK.Text);
                            break;
                        default:
                            MessageBox.Show("Vui long nhap so hop le");
                            break;
                    }
                }
            }
            else if (rbQuay.Checked) // phep quay
            {
                if (tbTronX.Text == "" && tbTronY.Text == "" && tbTronBK.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do x, y, ban kinh cho hinh");
                }
                else
                {
                    check = true;
                    xc = Convert.ToInt32(tbTronX.Text);
                    yc = Convert.ToInt32(tbTronY.Text);
                    bkc = Convert.ToInt32(tbTronBK.Text);

                    double rad = Int32.Parse(tbQuay.Text) * Math.PI / 180;
                    double cosa = Math.Cos(rad);
                    double sina = Math.Sin(rad);
                    x = Int32.Parse(tbTronX.Text) * (int)Math.Round(cosa) - Int32.Parse(tbTronY.Text) * (int)Math.Round(sina);
                    y = Int32.Parse(tbTronX.Text) * (int)Math.Round(sina) + Int32.Parse(tbTronY.Text) * (int)Math.Round(cosa);
                    bk = Convert.ToInt32(tbTronBK.Text);

                    MessageBox.Show("da lay bien x " + x + " " + y);


                }
            }
            else
            {
                x = Int32.Parse(tbTronX.Text);
                y = Int32.Parse(tbTronY.Text);
                bk = Int32.Parse(tbTronBK.Text);
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void rbTinhTien_CheckedChanged(object sender, EventArgs e)
        {
            tbxTT.Visible = true;
            tbyTT.Visible = true;
        }

        private void rbTiLe_CheckedChanged(object sender, EventArgs e)
        {
            tbTiLe.Visible = true;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }

        private void rbDoiXung_CheckedChanged(object sender, EventArgs e)
        {
            tbDoiXung.Visible = true;
        }

        private void rbQuay_CheckedChanged(object sender, EventArgs e)
        {
            tbQuay.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void xoa()
        {
            x = Int32.Parse(tbTronX.Text);
            y = Int32.Parse(tbTronY.Text);
            bk = Int32.Parse(tbTronBK.Text);
            this.DialogResult = DialogResult.Yes;
            this.Close();
            MessageBox.Show("gui du lieu xoa");
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            xoa();
        }


    }
}
