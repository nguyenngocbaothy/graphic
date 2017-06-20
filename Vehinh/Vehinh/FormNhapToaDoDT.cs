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
    public partial class FormNhapToaDoDT : Form
    {
        
        //int []x = new int[2];
        //int []y = new int[2];

        Form2 f2 = new Form2();
        
        public FormNhapToaDoDT()
        {
            InitializeComponent();
        }

        int x1, x2, y1, y2;
        int x1c, x2c, y1c, y2c;
        public bool check = false;

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

        //---------------------------------------------------------
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


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_OK(object sender, EventArgs e)
        {
            // tinh tien
            if (rbTinhTien.Checked)
            {
                // chua xoa dc hinh cu
                if (dx1.Text == "" && dx2.Text == "" && dy1.Text == "" && dy2.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");

                }
                else
                {
                    try
                    {
                        check = true;
                        x1c = Int32.Parse(dx1.Text);
                        x2c = Int32.Parse(dx2.Text);
                        y1c = Int32.Parse(dy1.Text);
                        y2c = Int32.Parse(dy2.Text);

                        x1 = Int32.Parse(dx1.Text);
                        y1 = Int32.Parse(dy1.Text);
                        x2 = Int32.Parse(dx2.Text);
                        y2 = Int32.Parse(dy2.Text);
                        int xz = Int32.Parse(tbxTT.Text);
                        int yz = Int32.Parse(tbyTT.Text);
                        int dodaiX = xz - x1;
                        int dodaiY = yz - y1;
                        x1 = xz;
                        y1 = yz;
                        x2 += dodaiX;
                        y2 += dodaiY;
                    }
                    catch
                    {
                        MessageBox.Show("nhap toa do khong hop le. Vui long nhap lai");
                    }

                    MessageBox.Show("hinh da duoc tinh tien (x1 = " + x1 + ", y1 =  " + y1 + "); (x2 = "
                        + x2 + ", y2 = " + y2 + ")");

                }
            }
            else if (rbTiLe.Checked) // phep ti le (phong to)
            {
                if (dx1.Text == "" && dx2.Text == "" && dy1.Text == "" && dy2.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    try
                    {
                        x1 = Convert.ToInt32(dx1.Text);
                        y1 = Convert.ToInt32(dy1.Text);
                        x2 = Convert.ToInt32(dx2.Text);
                        y2 = Convert.ToInt32(dy2.Text);
                    }
                    catch
                    {
                        MessageBox.Show("nhap toa do khong hop le. Vui long nhap lai");
                    }
                    check = true;
                    x1c = Int32.Parse(dx1.Text);
                    x2c = Int32.Parse(dx2.Text);
                    y1c = Int32.Parse(dy1.Text);
                    y2c = Int32.Parse(dy2.Text);

                    x1 = Convert.ToInt32(dx1.Text);
                    x2 = Convert.ToInt32(dx2.Text);
                    y1 = Convert.ToInt32(dy1.Text);
                    y2 = Convert.ToInt32(dy2.Text);
                    int dodaiY = Math.Abs(y1 - y2) * Convert.ToInt32(tbTiLe.Text);
                    int dodaiX = Math.Abs(x1 - x2) * Convert.ToInt32(tbTiLe.Text);

                    if (y1 < y2)
                    {
                        y2 = y1 + dodaiY;
                    }
                    else
                    {
                        y2 = y1 - dodaiY;
                    }
                    if (x1 < x2)
                    {
                        x2 = x1 + dodaiX;
                    }
                    else
                    {
                        x2 = x1 - dodaiX;
                    }

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
            else if (rbThu.Checked) // thu nhỏ
            {
                if (dx1.Text == "" && dx2.Text == "" && dy1.Text == "" && dy2.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do cho hinh");
                }
                else
                {
                    //x1 = Convert.ToInt32(dx1.Text) / Convert.ToInt32(tbThu.Text);
                    //     x2 = Convert.ToInt32(dx2.Text) / Convert.ToInt32(tbThu.Text);
                    try
                    {
                        x1 = Convert.ToInt32(dx1.Text);
                        y1 = Convert.ToInt32(dy1.Text);
                        x2 = Convert.ToInt32(dx2.Text);
                        y2 = Convert.ToInt32(dy2.Text);
                    }
                    catch
                    {
                        MessageBox.Show("nhap toa do khong hop le. Vui long nhap lai");
                    }
                    check = true;
                        x1c = Int32.Parse(dx1.Text);
                        x2c = Int32.Parse(dx2.Text);
                        y1c = Int32.Parse(dy1.Text);
                        y2c = Int32.Parse(dy2.Text);

                        x1 = Convert.ToInt32(dx1.Text);
                        x2 = Convert.ToInt32(dx2.Text);
                        y1 = Convert.ToInt32(dy1.Text);
                        y2 = Convert.ToInt32(dy2.Text);
                        int dodaiY = Math.Abs(y1 - y2) / Convert.ToInt32(tbThu.Text);
                        int dodaiX = Math.Abs(x1 - x2) / Convert.ToInt32(tbThu.Text);

                        if (y1 < y2)
                        {
                            y2 = y1 + dodaiY;
                        }
                        else
                        {
                            y2 = y1 - dodaiY;
                        }
                        if (x1 < x2)
                        {
                            x2 = x1 + dodaiX;
                        }
                        else
                        {
                            x2 = x1 - dodaiX;
                        }


                    }
                    

                    if (Int32.Parse(tbThu.Text) > 1)
                    {
                        MessageBox.Show("hinh da duoc thu nho");
                    }
                    if (Int32.Parse(tbThu.Text) == 1)
                    {
                        MessageBox.Show("hinh dong dang voi hinh cu");
                    }

                
            }
            else if (rbDoiXung.Checked) // phep doi xung
            {
                if (dx1.Text == "" && dx2.Text == "" && dy1.Text == "" && dy2.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do x, y, ban kinh cho hinh");
                }
                else
                {
                    int luachon = Convert.ToInt32(tbDoiXung.Text);
                    check = true;
                    x1c = Int32.Parse(dx1.Text);
                    x2c = Int32.Parse(dx2.Text);
                    y1c = Int32.Parse(dy1.Text);
                    y2c = Int32.Parse(dy2.Text);
                    switch (luachon)
                    {
                        case 1:
                            x1 = Int32.Parse(dx1.Text) * -1;
                            x2 = Int32.Parse(dx2.Text) * -1;

                            y1 = Int32.Parse(dy1.Text);
                            y2 = Int32.Parse(dy2.Text);

                            break;
                        case 2:
                            x1 = Int32.Parse(dx1.Text);
                            x2 = Int32.Parse(dx2.Text);

                            y1 = Int32.Parse(dy1.Text) * -1;
                            y2 = Int32.Parse(dy2.Text) * -1;

                            break;
                        case 3:
                            x1 = Int32.Parse(dx1.Text) * -1;
                            x2 = Int32.Parse(dx2.Text) * -1;

                            y1 = Int32.Parse(dy1.Text) * -1;
                            y2 = Int32.Parse(dy2.Text) * -1;

                            break;
                        default:
                            MessageBox.Show("Vui long nhap so hop le");
                            break;
                    }
                }
            }
            else if (rbQuay.Checked) // phep quay
            {
                if (dx1.Text == "" && dx2.Text == "" && dy1.Text == "" && dy2.Text == "")
                {
                    MessageBox.Show("Moi nhap toa do x, y, ban kinh cho hinh");
                }
                else
                {
                    check = true;
                    x1c = Int32.Parse(dx1.Text);
                    x2c = Int32.Parse(dx2.Text);
                    y1c = Int32.Parse(dy1.Text);
                    y2c = Int32.Parse(dy2.Text);

                    int quay = Int32.Parse(tbQuay.Text);
                    if (quay == 120) quay += 1;
                    double rad = quay * Math.PI / 180;
                    double cosa = Math.Cos(rad);
                    double sina = Math.Sin(rad);
                    /*x = Int32.Parse(tbTronX.Text) * (int)Math.Round(cosa) - Int32.Parse(tbTronY.Text) * (int)Math.Round(sina);
                      y = Int32.Parse(tbTronX.Text) * (int)Math.Round(sina) + Int32.Parse(tbTronY.Text) * (int)Math.Round(cosa);
                    bk = Convert.ToInt32(tbTronBK.Text);*/

                    x1 = Int32.Parse(dx1.Text) * (int)Math.Round(cosa) - Int32.Parse(dy1.Text) * (int)Math.Round(sina);
                    y1 = Int32.Parse(dx1.Text) * (int)Math.Round(sina) + Int32.Parse(dy1.Text) * (int)Math.Round(cosa);

                    x2 = Int32.Parse(dx2.Text) * (int)Math.Round(cosa) - Int32.Parse(dy2.Text) * (int)Math.Round(sina);
                    y2 = Int32.Parse(dx2.Text) * (int)Math.Round(sina) + Int32.Parse(dy2.Text) * (int)Math.Round(cosa);


                }
            }
            else
            {
                try
                {
                    x1 = Int32.Parse(dx1.Text);
                    x2 = Int32.Parse(dx2.Text);

                    y1 = Int32.Parse(dy1.Text);
                    y2 = Int32.Parse(dy2.Text);
                }
                catch
                {
                    MessageBox.Show("nhap toa do khong hop le. Vui long nhap lai");
                }
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void rbTinhTien_CheckedChanged(object sender, EventArgs e)
        {
            tbxTT.Visible = true;
            //tbyTT.Visible = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            xoa();
        }

        public void xoa()
        {
            //Form2 f = new Form2();
            //f.Xoa_DT(Convert.ToInt32(dx1.Text), Convert.ToInt32(dy1.Text), Convert.ToInt32(dx2.Text), Convert.ToInt32(dy2.Text));
            
            
            x1 = Convert.ToInt32(dx1.Text);
            y1 = Convert.ToInt32(dy1.Text); 
            x2 = Convert.ToInt32(dx2.Text); 
            y2 = Convert.ToInt32(dy2.Text);

            this.DialogResult = DialogResult.Yes;
            this.Close();
   
            MessageBox.Show("gui du lieu xoa");
        }


           /*x1 = Int32.Parse(dx1.Text);
            x2 = Int32.Parse(dx2.Text);
            y1 = Int32.Parse(dy1.Text);
            y2 = Int32.Parse(dy2.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();*/
        }
       
    }

