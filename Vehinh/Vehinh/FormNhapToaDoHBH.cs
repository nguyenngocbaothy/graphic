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
    public partial class FormNhapToaDoHBH : Form
    {
        public FormNhapToaDoHBH()
        {
            InitializeComponent();
        }
        public bool check = false;

        //int x1c, x2c, x3c, y1c, y2c, y3c;
        int x1c, x2c, x3c, y1c, y2c, y3c;
        int x1, x2, y1, y2, x3, y3;

        public int getX1()
        {
            return x1;
        }

        public int getY1()
        {
            return y1;
        }       

        public int getX2()
        {
            return x2;
        }

        public int getY2()
        {
            return y2;
        }

        public int getX3()
        {
            return x3;
        }

        public int getY3()
        {
            return y3;
        }
        //------------------------------------------------------------
        public int getX1C()
        {
            return x1c;
        }

        public int getY1C()
        {
            return y1c;
        }

        
        public int getX2C()
        {
            return x2c;
        }

        public int getY2C()
        {
            return y2c;
        }

        public int getX3C()
        {
            return x3c;
        }

        public int getY3C()
        {
            return y3c;
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            // tinh tien
            if (rbTinhTien.Checked)
            {
                // chua xoa dc hinh cu
                if (dx1.Text == "" && dx2.Text == "" && dx3.Text == "" && dy1.Text == "" &&
                    dy2.Text == "" && dy3.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");

                }
                else
                {
                    try
                    {
                        check = true;
                        x1c = Int32.Parse(dx1.Text);
                        y1c = Int32.Parse(dy1.Text);
                        x2c = Int32.Parse(dx2.Text);
                        y2c = Int32.Parse(dy2.Text);
                        x3c = Int32.Parse(dx3.Text);
                        y3c = Int32.Parse(dy3.Text);

                        x1 = Int32.Parse(dx1.Text);
                        y1 = Int32.Parse(dy1.Text);
                        x2 = Int32.Parse(dx2.Text);
                        y2 = Int32.Parse(dy2.Text);
                        x3 = Int32.Parse(dx3.Text);                        
                        y3 = Int32.Parse(dy3.Text);
                        int xz = Int32.Parse(tbxTT.Text);
                        int yz = Int32.Parse(tbyTT.Text);
                        int dodaiX = xz - x1;
                        int dodaiY = yz - y1;
                        x1 = xz;
                        y1 = yz;
                        x2 += dodaiX;
                        y2 += dodaiY;
                        x3 = x1;
                        y3 = x2;
                    }
                    catch
                    {
                        MessageBox.Show("nhap toa do khong hop le. Vui long nhap lai");
                    }
                    MessageBox.Show("hinh da duoc tinh tien (x1 = " + x1 + ", y1 =  " + y1 + "); (x2 = "
                        + x2 + ", y2 = " + y2 + "); (x3 = " + x3 + ", y3 = " + y3 + ")");
                }
            }
            else if (rbTiLe.Checked) // phep ti le (phong to)
            {
                if (dx1.Text == "" && dx2.Text == "" && dx3.Text == "" && dy1.Text == "" &&
                    dy2.Text == "" && dy3.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    try
                    {
                        check = true;
                        x1c = Int32.Parse(dx1.Text);
                        y1c = Int32.Parse(dy1.Text);
                        x2c = Int32.Parse(dx2.Text);
                        y2c = Int32.Parse(dy2.Text);
                        x3c = Int32.Parse(dx3.Text);
                        y3c = Int32.Parse(dy3.Text);

                        x1 = Convert.ToInt32(dx1.Text);
                        x2 = Convert.ToInt32(dx2.Text);
                        x3 = Convert.ToInt32(dx3.Text);
                        y1 = Convert.ToInt32(dy1.Text);
                        y2 = Convert.ToInt32(dy2.Text);
                        y3 = Convert.ToInt32(dy3.Text);
                        int dodaiY = Math.Abs(y1 - y2) * Convert.ToInt32(tbTiLe.Text);
                        int dodaiX = Math.Abs(x1 - x2) * Convert.ToInt32(tbTiLe.Text);
                        int dodaiZ = Math.Abs(x3 - y3) * Convert.ToInt32(tbTiLe.Text);
                        if (x1 <= x2 || y1 <= y2)
                        {
                            x2 = x1 + dodaiX;
                            y2 = y1 + dodaiY;
                            y3 = x3 + dodaiZ;
                        }
                        else
                        {
                            x2 = x1 - dodaiX;
                            y2 = y1 - dodaiY;
                            y3 = x3 - dodaiZ;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("nhap toa do khong hop le. Vui long nhap lai");
                    }
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
                if (dx1.Text == "" && dx2.Text == "" && dx3.Text == "" && dy1.Text == "" &&
                    dy2.Text == "" && dy3.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    try
                    {
                        check = true;
                        x1c = Int32.Parse(dx1.Text);
                        y1c = Int32.Parse(dy1.Text);
                        x2c = Int32.Parse(dx2.Text);
                        y2c = Int32.Parse(dy2.Text);
                        x3c = Int32.Parse(dx3.Text);
                        y3c = Int32.Parse(dy3.Text);

                        x1 = Convert.ToInt32(dx1.Text);
                        x2 = Convert.ToInt32(dx2.Text);
                        x3 = Convert.ToInt32(dx3.Text);
                        y1 = Convert.ToInt32(dy1.Text);
                        y2 = Convert.ToInt32(dy2.Text);
                        y3 = Convert.ToInt32(dy3.Text);
                        int dodaiY = Math.Abs(y1 - y2) / Convert.ToInt32(tbThu.Text);
                        int dodaiX = Math.Abs(x1 - x2) / Convert.ToInt32(tbThu.Text);
                        int dodaiZ = Math.Abs(x3 - y3) / Convert.ToInt32(tbThu.Text);
                        if (x1 <= x2 || y1 <= y2)
                        {
                            x2 = x1 + dodaiX;
                            y2 = y1 + dodaiY;
                            y3 = x3 + dodaiZ;
                        }
                        else
                        {
                            x2 = x1 - dodaiX;
                            y2 = y1 - dodaiY;
                            y3 = x3 - dodaiZ;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("nhap toa do khong hop le. Vui long nhap lai");
                    }
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
                if (dx1.Text == "" && dx2.Text == "" && dx3.Text == "" && dy1.Text == "" &&
                    dy2.Text == "" && dy3.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    try
                    {
                        check = true;
                        x1c = Int32.Parse(dx1.Text);
                        y1c = Int32.Parse(dy1.Text);
                        x2c = Int32.Parse(dx2.Text);
                        y2c = Int32.Parse(dy2.Text);
                        x3c = Int32.Parse(dx3.Text);
                        y3c = Int32.Parse(dy3.Text);

                        int luachon = Convert.ToInt32(tbDoiXung.Text);
                        switch (luachon)
                        {
                            case 1:
                                x1 = Int32.Parse(dx1.Text) * -1;
                                x2 = Int32.Parse(dx2.Text) * -1;
                                x3 = Int32.Parse(dx3.Text) * -1;
                                y1 = Int32.Parse(dy1.Text);
                                y2 = Int32.Parse(dy2.Text);
                                y3 = Int32.Parse(dy3.Text);
                                break;
                            case 2:
                                x1 = Int32.Parse(dx1.Text);
                                x2 = Int32.Parse(dx2.Text);
                                x3 = Int32.Parse(dx3.Text);
                                y1 = Int32.Parse(dy1.Text) * -1;
                                y2 = Int32.Parse(dy2.Text) * -1;
                                y3 = Int32.Parse(dy3.Text) * -1;
                                break;
                            case 3:
                                x1 = Int32.Parse(dx1.Text) * -1;
                                x2 = Int32.Parse(dx2.Text) * -1;
                                x3 = Int32.Parse(dx3.Text) * -1;
                                y1 = Int32.Parse(dy1.Text) * -1;
                                y2 = Int32.Parse(dy2.Text) * -1;
                                y3 = Int32.Parse(dy3.Text) * -1;
                                break;
                            default:
                                MessageBox.Show("Vui long nhap so hop le");
                                break;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("nhap toa do khong hop le. Vui long nhap lai");
                    }
                }
            }
            else if (rbQuay.Checked) // phep quay
            {
                if (dx1.Text == "" && dx2.Text == "" && dx3.Text == "" && dy1.Text == "" &&
                    dy2.Text == "" && dy3.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do x, y, ban kinh cho hinh");
                }
                else
                {
                    try
                    {
                        check = true;
                        x1c = Int32.Parse(dx1.Text);
                        y1c = Int32.Parse(dy1.Text);
                        x2c = Int32.Parse(dx2.Text);
                        y2c = Int32.Parse(dy2.Text);
                        x3c = Int32.Parse(dx3.Text);
                        y3c = Int32.Parse(dy3.Text);

                        double rad = Int32.Parse(tbQuay.Text) * Math.PI / 180;
                        double cosa = Math.Cos(rad);
                        double sina = Math.Sin(rad);
                        /*x = Int32.Parse(tbTronX.Text) * (int)Math.Round(cosa) - Int32.Parse(tbTronY.Text) * (int)Math.Round(sina);
                          y = Int32.Parse(tbTronX.Text) * (int)Math.Round(sina) + Int32.Parse(tbTronY.Text) * (int)Math.Round(cosa);
                        bk = Convert.ToInt32(tbTronBK.Text);*/
                        x1 = Int32.Parse(dx1.Text) * (int)Math.Round(cosa) - Int32.Parse(dy1.Text) * (int)Math.Round(sina);
                        x2 = Int32.Parse(dx2.Text) * (int)Math.Round(cosa) - Int32.Parse(dy2.Text) * (int)Math.Round(sina);
                        x3 = Int32.Parse(dx3.Text) * (int)Math.Round(cosa) - Int32.Parse(dy3.Text) * (int)Math.Round(sina);
                        y1 = Int32.Parse(dx1.Text) * (int)Math.Round(sina) + Int32.Parse(dy1.Text) * (int)Math.Round(cosa);
                        y2 = Int32.Parse(dx2.Text) * (int)Math.Round(sina) + Int32.Parse(dy2.Text) * (int)Math.Round(cosa);
                        y3 = Int32.Parse(dx3.Text) * (int)Math.Round(sina) + Int32.Parse(dy3.Text) * (int)Math.Round(cosa);

                        // MessageBox.Show("da lay bien x " + x + " " + y);

                    }
                    catch
                    {
                        MessageBox.Show("nhap toa do khong hop le. Vui long nhap lai");
                    }
                }
            }
            else
            {
                x1 = Int32.Parse(dx1.Text);
                x2 = Int32.Parse(dx2.Text);
                x3 = Int32.Parse(dx3.Text);
                y1 = Int32.Parse(dy1.Text);
                y2 = Int32.Parse(dy2.Text);
                y3 = Int32.Parse(dy3.Text);
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

        private void rbDoiXung_CheckedChanged(object sender, EventArgs e)
        {
            tbDoiXung.Visible = true;
        }

        private void rbQuay_CheckedChanged(object sender, EventArgs e)
        {
            tbQuay.Visible = true;
        }

        public void xoa()
        {
            x1 = Int32.Parse(dx1.Text);
            x2 = Int32.Parse(dx2.Text);
            x3 = Int32.Parse(dx3.Text);
            y1 = Int32.Parse(dy1.Text);
            y2 = Int32.Parse(dy2.Text);
            y3 = Int32.Parse(dy3.Text);
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
            /*x1 = Int32.Parse(dx1.Text);
            x2 = Int32.Parse(dx2.Text);
            x3 = Int32.Parse(dx3.Text);
            y1 = Int32.Parse(dy1.Text);
            y2 = Int32.Parse(dy2.Text);
            y3 = Int32.Parse(dy3.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();*/
        
    

