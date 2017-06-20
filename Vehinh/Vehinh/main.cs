using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Vehinh
{
    public partial class Form2 : Form
    {
        //public delegate void Truyen(TextBox text);
        bool daVe = false;
        BufferedGraphicsContext context;
        public BufferedGraphics mybuffer;
        Graphics g;
        Bitmap bm; // chua xong
        bool chedo2d = false;
        public bool daxoa = false;
        string str;

        ArrayList dsHien = new ArrayList();

        //---------------------- dthang---------------------------
        ArrayList dsDT = new ArrayList(); // luu thong tin dthang

        //-----------------------htron------------------------------
        ArrayList dsHTron = new ArrayList();

        //------------------------ellip--------------------------
        ArrayList dsEll = new ArrayList();

        //------------------------hcn--------------------------
        ArrayList dsHCN = new ArrayList();

        //------------------------hthoi--------------------------
        ArrayList dsHThoi = new ArrayList();

        //------------------------hbh--------------------------
        ArrayList dsHBH = new ArrayList();

        //------------------------tamgiac--------------------------
        ArrayList dsTGiac = new ArrayList();

        //-----------------------hinhhop---------------------------
        ArrayList dsHHop = new ArrayList();

        //-----------------------hinhthap----------------------
        ArrayList dsHThap = new ArrayList();

        public enum ButtonColor
        {
            LEFT,
            RIGHT
        }
        ButtonColor currButtonColor;
        Color currColor;

        public Form2()
        {
            InitializeComponent();
            bm = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bm); // khoi tao doi tuong bitmap de luu anh cu

            currButtonColor = ButtonColor.LEFT;
            currColor = Color.Black;

            context = BufferedGraphicsManager.Current;
            mybuffer = context.Allocate(panel1.CreateGraphics(), panel1.DisplayRectangle);
            VeHeToaDo();
        }


        // ve khung luoi pixel
        public void VeHeToaDo()
        {
            mybuffer.Graphics.Clear(panel1.BackColor);
            if (daVe == false)
            {
                for (int i = 0; i <= 40; i++) // so o ngang, doc, moi o 1a 10
                {
                    mybuffer.Graphics.DrawLine(new Pen(Color.Green), i * 10, 0, i * 10, 400); // do dai cua tong so o
                    mybuffer.Graphics.DrawLine(new Pen(Color.Green), 0, i * 10, 400, i * 10);
                }
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 200, 0, 200, 400); // duong thang o giua
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 0, 200, 400, 200);
                /*for (int i = 0; i < 420; i += 20) // chia diem hang ngang
                    mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), i - 3, 200 - 3, 6, 6);

                for (int i = 0; i < 420; i += 20)  // chia diem hang doc
                    mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 200 - 3, i - 3, 6, 6);*/

                daVe = true;
                chedo2d = true;
            }
            else
            {
                //g.Clear(Color.White);
                panel1.Invalidate();
                panel1.Refresh();
                for (int i = 0; i <= 40; i++)
                {
                    mybuffer.Graphics.DrawLine(new Pen(Color.Green), i * 10, 0, i * 10, 400);
                    mybuffer.Graphics.DrawLine(new Pen(Color.Green), 0, i * 10, 400, i * 10);
                }
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 200, 0, 200, 400);
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 0, 200, 400, 200);
                /*for (int i = 0; i < 420; i += 20)
                    mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), i - 3, 200 - 3, 6, 6);

                for (int i = 0; i < 420; i += 20)
                    mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 200 - 3, i - 3, 6, 6);*/

                daVe = true;
                chedo2d = true;

            }
            mybuffer.Render();
        }

        public void Ve3D()
        {
            //3d
            if (daVe == true)
            {
                //g.Clear(Color.White);
                panel1.Invalidate();
                panel1.Refresh();
                //g = panel1.CreateGraphics();
                mybuffer.Graphics.Clear(panel1.BackColor);
                for (int i = 0; i <= 40; i++)
                {
                    mybuffer.Graphics.DrawLine(new Pen(Color.Green), i * 10, 0, i * 10, 400);
                    mybuffer.Graphics.DrawLine(new Pen(Color.Green), 0, i * 10, 400, i * 10);
                }
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 200, 0, 200, 200); // duong thang dung
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 200, 200, 400, 200); // duong ngang
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 200, 200, 0, 400); // duong cheo

                /* for (int i = 200; i < 420; i += 20)
                     mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), i - 3, 200 - 3, 6, 6);

                 for (int i = 0; i < 220; i += 20)
                     mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 200 - 3, i - 3, 6, 6);

                 //for (int i = 200; i >= 0; i -= 20) 
                 //    for (int j = 0; j >= 400; j+=40 )
                         mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 200 - 3, 200 - 3, 6, 6);
                         mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 180 - 3, 180+40 - 3, 6, 6);
                         mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 160 - 3, 160+80 - 3, 6, 6);
                         mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 140 - 3, 140+120 - 3, 6, 6); 
                 mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 120 - 3, 120+160 - 3, 6, 6);
                 mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 100 - 3, 100+200 - 3, 6, 6);
                 mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 80 - 3, 80+240 - 3, 6, 6);
                 mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 60 - 3, 60+280 - 3, 6, 6);
                 mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 40 - 3, 40+320 - 3, 6, 6);
                 mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 20 - 3, 20+360 - 3, 6, 6);
                 mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 0 - 3, 0+400 - 3, 6, 6);*/

                daVe = true;
                chedo2d = false;

                mybuffer.Render();
            }
            else
            {
                //g = panel1.CreateGraphics();
                mybuffer.Graphics.Clear(panel1.BackColor);
                for (int i = 0; i <= 40; i++)
                {
                    mybuffer.Graphics.DrawLine(new Pen(Color.Green), i * 10, 0, i * 10, 400);
                    mybuffer.Graphics.DrawLine(new Pen(Color.Green), 0, i * 10, 400, i * 10);
                }
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 200, 0, 200, 200); // duong thang dung
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 200, 200, 400, 200); // duong ngang
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 200, 200, 0, 400); // duong cheo

                for (int i = 200; i < 420; i += 20)
                    mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), i - 3, 200 - 3, 6, 6);

                for (int i = 0; i < 220; i += 20)
                    mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 200 - 3, i - 3, 6, 6);

                //for (int i = 200; i >= 0; i -= 20)  
                // cuc nho chia duong cheo
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 200 - 3, 200 - 3, 6, 6);
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 180 - 3, 180 + 40 - 3, 6, 6);
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 160 - 3, 160 + 80 - 3, 6, 6);
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 140 - 3, 140 + 120 - 3, 6, 6);
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 120 - 3, 120 + 160 - 3, 6, 6);
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 100 - 3, 100 + 200 - 3, 6, 6);
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 80 - 3, 80 + 240 - 3, 6, 6);
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 60 - 3, 60 + 280 - 3, 6, 6);
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 40 - 3, 40 + 320 - 3, 6, 6);
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 20 - 3, 20 + 360 - 3, 6, 6);
                mybuffer.Graphics.FillRectangle(new SolidBrush(Color.Orange), 0 - 3, 0 + 400 - 3, 6, 6);
            }

            daVe = true;
            chedo2d = false;
            mybuffer.Render();
        }
        private void btn3D_Click(object sender, EventArgs e)
        {
            Ve3D();
            dx.Text = "z";
            dy.Text = "x";
            dz.Text = "y";
            lbToaDo.Text = "";
            richTextBox1.Text = "";
            dsDT.Clear();
            dsDT.Clear();
            dsEll.Clear();
            dsHBH.Clear();
            dsHCN.Clear();
            dsHien.Clear();
            dsHThoi.Clear();
            dsHTron.Clear();
            dsTGiac.Clear();
            //dsHHop.Clear();
           // dsHThap.Clear();
        }
        //-----------------------------------------------------------------------------------
        // putpixel duong thang
        public void Put_Pixel(int x, int y, int xc, int yc)
        {
            float tdX = x * 10 + 200 - 3 + xc * 10;
            float tdY = 200 - y * 10 - 3 + yc * 10;
            //g = panel1.CreateGraphics();

            SolidBrush brush = new SolidBrush(currColor);
            Pen p = new Pen(currColor);
            //g.FillRectangle(brush, x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 + yc * 10, 6, 6);
            mybuffer.Graphics.FillRectangle(brush, x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 + yc * 10, 6, 6);
            //g.Dispose();
            mybuffer.Render();
        }

        //-----------------------------------------------------------------------------------
        // de ve 4 cham o 4 vung tren he toa do
        public void Put_8_Pixel(int x, int y, int xc, int yc)
        {
            Put_Pixel(x, y, xc, yc);
            Put_Pixel(y, x, xc, yc);
            Put_Pixel(y, -x, xc, yc);
            Put_Pixel(x, -y, xc, yc);
            Put_Pixel(-x, -y, xc, yc);
            Put_Pixel(-y, -x, xc, yc);
            Put_Pixel(-y, x, xc, yc);
            Put_Pixel(-x, y, xc, yc);
        }

        //-----------------------------------------------------------------------------------
        // ve duong thang dda
        public void Ve_DT(int x1, int y1, int x2, int y2)
        {
            int Dx, Dy, count;
            float x, y, delta_X, delta_Y;
            Dx = x2 - x1;
            Dy = y2 - y1;
            //Lay so buoc ve
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = x1;
                y = y1;
                do
                {

                    Put_Pixel((int)x, (int)y, 0, 0);
                    //Put_8_Pixel((int)x, (int)y, 0, 0, 0);
                    x += delta_X;
                    y += delta_Y;
                    --count;

                } while (count != -1);
            }

        }

        public void Delete_Pixelbd(int x, int y, int xc, int yc, int color)
        {
            //Graphics g = this.panel1.CreateGraphics();
            SolidBrush brush = new SolidBrush(this.panel1.BackColor);
            mybuffer.Graphics.FillRectangle(brush, x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 + yc * 10, 6, 6);
            mybuffer.Graphics.DrawLine(new Pen(Color.Green), x * 10 + 200 + xc * 10, 200 - y * 10 - 3 + yc * 10, x * 10 + 200 + xc * 10, 200 - y * 10 + 3 + yc * 10);//Ve doc
            mybuffer.Graphics.DrawLine(new Pen(Color.Green), x * 10 + 200 - 3 + xc * 10, 200 - y * 10 + yc * 10, 200 + x * 10 + 3 + xc * 10, 200 - y * 10 + yc * 10);//Ve ngang
            if (x + xc == 0)
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), x * 10 + 200 + xc * 10, 200 - y * 10 - 3 + yc * 10, x * 10 + 200 + xc * 10, 200 - y * 10 + 3 + yc * 10);
            if (y - yc == 0)
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), x * 10 + 200 - 3 + xc * 10, 200 - y * 10 + yc * 10, 200 + x * 10 + 3 + xc * 10, 200 - y * 10 + yc * 10);
            //g.Dispose();
            mybuffer.Render();
        }

        public void Xoa_DTbd(int x1, int y1, int x2, int y2)
        {
            int Dx, Dy, count;
            float x, y, delta_X, delta_Y;
            Dx = x2 - x1;
            Dy = y2 - y1;
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = x1;
                y = y1;
                do
                {

                    Delete_Pixelbd((int)x, (int)y, 0, 0, 1);
                    x += delta_X;
                    y += delta_Y;
                    --count;

                } while (count != -1);
            }

            //MessageBox.Show("da xoa hinh co toa do:" + x1 + " " + y1 + " " + x2 + " " + y2);
            //this.DialogResult = DialogResult.OK;
        }
        public void Delete_Pixel(int x, int y, int xc, int yc, int color)
        {
            Graphics g = this.panel1.CreateGraphics();
            SolidBrush brush = new SolidBrush(this.panel1.BackColor);
            g.FillRectangle(brush, x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 + yc * 10, 6, 6);
            g.DrawLine(new Pen(Color.Green), x * 10 + 200 + xc * 10, 200 - y * 10 - 3 + yc * 10, x * 10 + 200 + xc * 10, 200 - y * 10 + 3 + yc * 10);//Ve doc
            g.DrawLine(new Pen(Color.Green), x * 10 + 200 - 3 + xc * 10, 200 - y * 10 + yc * 10, 200 + x * 10 + 3 + xc * 10, 200 - y * 10 + yc * 10);//Ve ngang
            if (x + xc == 0)
                g.DrawLine(new Pen(Color.Red), x * 10 + 200 + xc * 10, 200 - y * 10 - 3 + yc * 10, x * 10 + 200 + xc * 10, 200 - y * 10 + 3 + yc * 10);
            if (y - yc == 0)
                g.DrawLine(new Pen(Color.Red), x * 10 + 200 - 3 + xc * 10, 200 - y * 10 + yc * 10, 200 + x * 10 + 3 + xc * 10, 200 - y * 10 + yc * 10);
            //g.Dispose();

        }

        public void Xoa_DT(int x1, int y1, int x2, int y2)
        {
            int Dx, Dy, count;
            float x, y, delta_X, delta_Y;
            Dx = x2 - x1;
            Dy = y2 - y1;
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = x1;
                y = y1;
                do
                {

                    Delete_Pixel((int)x, (int)y, 0, 0, 1);
                    x += delta_X;
                    y += delta_Y;
                    --count;

                } while (count != -1);
            }
        }
        //-----------------------------------------------------------------------------------
        // ham ve hinh tron bang tt Bresenham, 8 diem doi xung
        // ve 1/8 duong tron, midpoint
        public void Put_8_Pixel(int x, int y, int xc, int yc, int color)
        {
            Put_Pixel(x, y, xc, yc);
            Put_Pixel(y, x, xc, yc);
            Put_Pixel(y, -x, xc, yc);
            Put_Pixel(x, -y, xc, yc);
            Put_Pixel(-x, -y, xc, yc);
            Put_Pixel(-y, -x, xc, yc);
            Put_Pixel(-y, x, xc, yc);
            Put_Pixel(-x, y, xc, yc);
        }
        public void Ve_HTron(int xc, int yc, int R)
        {
            int x, y, p;
            x = 0;
            y = R;
            Put_8_Pixel(x, y, xc, -yc, 1);
            p = 1 - R;
            while (x < y)
            {
                if (p < 0)
                    p += 2 * x + 3;
                else
                {
                    p += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                Put_8_Pixel(x, y, xc, -yc, 1);
            }
        }
        public void Delete_Put8bd(int x, int y, int xc, int yc)
        {
            Delete_Pixelbd(x, y, xc, yc, 1);
            Delete_Pixelbd(y, x, xc, yc, 1);
            Delete_Pixelbd(y, -x, xc, yc, 1);
            Delete_Pixelbd(x, -y, xc, yc, 1);
            Delete_Pixelbd(-x, -y, xc, yc, 1);
            Delete_Pixelbd(-y, -x, xc, yc, 1);
            Delete_Pixelbd(-y, x, xc, yc, 1);
            Delete_Pixelbd(-x, y, xc, yc, 1);
        }
        public void Xoa_HTronbd(int xc, int yc, int R)
        {
            int x, y, p;
            x = 0;
            y = R;
            Delete_Put8bd(x, y, xc, -yc);
            p = 1 - R;
            while (x < y)
            {
                if (p < 0)
                    p += 2 * x + 3;
                else
                {
                    p += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                Delete_Put8bd(x, y, xc, -yc);
            }
        }
        public void Delete_Put8(int x, int y, int xc, int yc)
        {
            Delete_Pixel(x, y, xc, yc, 1);
            Delete_Pixel(y, x, xc, yc, 1);
            Delete_Pixel(y, -x, xc, yc, 1);
            Delete_Pixel(x, -y, xc, yc, 1);
            Delete_Pixel(-x, -y, xc, yc, 1);
            Delete_Pixel(-y, -x, xc, yc, 1);
            Delete_Pixel(-y, x, xc, yc, 1);
            Delete_Pixel(-x, y, xc, yc, 1);
        }
        public void Xoa_HTron(int xc, int yc, int R)
        {
            int x, y, p;
            x = 0;
            y = R;
            Delete_Put8(x, y, xc, -yc);
            p = 1 - R;
            while (x < y)
            {
                if (p < 0)
                    p += 2 * x + 3;
                else
                {
                    p += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                Delete_Put8(x, y, xc, -yc);
            }
        }
        //-----------------------------------------------------------------------------------
        // ve eclip x, y la toa do tam; xRadius la be ngang eclip, yRadius la be doc eclip
        // putpixel cho hinh tron
        public void Put_PixelTron(int x, int y, int xc, int yc, int color)
        {
            float ellX = x * 10 + 200 - 3 + xc * 10;
            float ellY = 200 - y * 10 - 3 - yc * 10;
            // Graphics g = panel1.CreateGraphics();
            SolidBrush brush = new SolidBrush(currColor);

            mybuffer.Graphics.FillRectangle(brush, x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 - yc * 10, 6, 6);
            mybuffer.Render();
        }
        public void Put_4_Pixel_1(int x, int y, int xc, int yc) // 4 diem doi xung
        {
            Put_PixelTron(x, y, xc, yc, 0);
            Put_PixelTron(-x, y, xc, yc, 0);
            Put_PixelTron(x, -y, xc, yc, 0);
            Put_PixelTron(-x, -y, xc, yc, 0);
        }
        public void Ve_Elip(int xc, int yc, int a, int b)
        {
            double Dx, Dy, p, Const1, Const2;
            Point x = Point.Empty, y = Point.Empty;
            x.X = 0;
            y.Y = b;
            Const1 = a * a;
            Const2 = b * b;
            Dx = 0;
            Dy = 2 * Const1 * y.Y;
            Put_4_Pixel_1(x.X, y.Y, xc, yc);
            p = Math.Round(Const2 - (Const1 * b) + (0.25f * Const1));
            while (Dx < Dy)
            {
                x.X++;
                Dx += 2 * Const2;
                if (p < 0)
                    p += Const2 + Dx;
                else
                {
                    y.Y--;
                    Dy -= 2 * Const1;
                    p += Const2 + Dx - Dy;
                }
                Put_4_Pixel_1(x.X, y.Y, xc, yc);
            }
            p = Math.Round(Const2 * (x.X + 0.5f) * (x.X + 0.5f) + Const1 * (y.Y - 1) * (y.Y - 1) - Const1 * Const2);
            while (y.Y > 0)
            {
                y.Y--;
                Dy -= Const1 * 2;
                if (p > 0)
                    p += Const1 - Dy;
                else
                {
                    x.X++;
                    Dx += Const2 * 2;
                    p += Const1 - Dy + Dx;
                }
                Put_4_Pixel_1(x.X, y.Y, xc, yc);
            }
        }
        public void Delete_PixelTronbd(int x, int y, int xc, int yc, int color)
        {
            SolidBrush brush = new SolidBrush(this.panel1.BackColor);
            //                               brush, x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 - yc * 10
            mybuffer.Graphics.FillRectangle(brush, x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 - yc * 10, 6, 6);
            mybuffer.Graphics.DrawLine(new Pen(Color.Green), x * 10 + 200 + xc * 10, 200 - y * 10 - 3 - yc * 10, x * 10 + 200 + xc * 10, 200 - y * 10 + 3 - yc * 10);//Ve doc
            mybuffer.Graphics.DrawLine(new Pen(Color.Green), x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - yc * 10, 200 + x * 10 + 3 + xc * 10, 200 - y * 10 - yc * 10);//Ve ngang
            if (x + xc == 0)
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), x * 10 + 200 + xc * 10, 200 - y * 10 - 3 - yc * 10, x * 10 + 200 + xc * 10, 200 - y * 10 + 3 - yc * 10);
            if (y - yc == 0)
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - yc * 10, 200 + x * 10 + 3 + xc * 10, 200 - y * 10 - yc * 10);
            mybuffer.Render();
        }
        public void Delete_Put4bd(int x, int y, int xc, int yc)
        {
            Delete_PixelTronbd(x, y, xc, yc, 1);
            Delete_PixelTronbd(-x, y, xc, yc, 1);
            Delete_PixelTronbd(x, -y, xc, yc, 1);
            Delete_PixelTronbd(-x, -y, xc, yc, 1);
        }
        public void Xoa_Elipbd(int xc, int yc, int xRadius, int yRadius)
        {
            double Dx, Dy, p, Const1, Const2;
            Point x = Point.Empty, y = Point.Empty;
            x.X = 0;
            y.Y = yRadius;
            Const1 = xRadius * xRadius;
            Const2 = yRadius * yRadius;
            Dx = 0;
            Dy = 2 * Const1 * y.Y;
            Delete_Put4bd(x.X, y.Y, xc, yc);
            p = Math.Round(Const2 - (Const1 * yRadius) + (0.25f * Const1));
            while (Dx < Dy)
            {
                x.X++;
                Dx += 2 * Const2;
                if (p < 0)
                    p += Const2 + Dx;
                else
                {
                    y.Y--;
                    Dy -= 2 * Const1;
                    p += Const2 + Dx - Dy;
                }
                Delete_Put4bd(x.X, y.Y, xc, yc);
            }
            p = Math.Round(Const2 * (x.X + 0.5f) * (x.X + 0.5f) + Const1 * (y.Y - 1) * (y.Y - 1) - Const1 * Const2);
            while (y.Y > 0)
            {
                y.Y--;
                Dy -= Const1 * 2;
                if (p > 0)
                    p += Const1 - Dy;
                else
                {
                    x.X++;
                    Dx += Const2 * 2;
                    p += Const1 - Dy + Dx;
                }
                Delete_Put4bd(x.X, y.Y, xc, yc);
            }

        }
        public void Delete_PixelTron(int x, int y, int xc, int yc, int color)
        {
            Graphics g = this.panel1.CreateGraphics();
            SolidBrush brush = new SolidBrush(this.panel1.BackColor);
            //                               brush, x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 - yc * 10
            g.FillRectangle(brush, x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 - yc * 10, 6, 6);
            g.DrawLine(new Pen(Color.Green), x * 10 + 200 + xc * 10, 200 - y * 10 - 3 - yc * 10, x * 10 + 200 + xc * 10, 200 - y * 10 + 3 - yc * 10);//Ve doc
            g.DrawLine(new Pen(Color.Green), x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - yc * 10, 200 + x * 10 + 3 + xc * 10, 200 - y * 10 - yc * 10);//Ve ngang
            if (x + xc == 0)
                g.DrawLine(new Pen(Color.Red), x * 10 + 200 + xc * 10, 200 - y * 10 - 3 - yc * 10, x * 10 + 200 + xc * 10, 200 - y * 10 + 3 - yc * 10);
            if (y - yc == 0)
                g.DrawLine(new Pen(Color.Red), x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - yc * 10, 200 + x * 10 + 3 + xc * 10, 200 - y * 10 - yc * 10);
        }
        public void Delete_Put4(int x, int y, int xc, int yc)
        {
            Delete_PixelTron(x, y, xc, yc, 1);
            Delete_PixelTron(-x, y, xc, yc, 1);
            Delete_PixelTron(x, -y, xc, yc, 1);
            Delete_PixelTron(-x, -y, xc, yc, 1);
        }
        public void Xoa_Elip(int xc, int yc, int xRadius, int yRadius)
        {
            double Dx, Dy, p, Const1, Const2;
            Point x = Point.Empty, y = Point.Empty;
            x.X = 0;
            y.Y = yRadius;
            Const1 = xRadius * xRadius;
            Const2 = yRadius * yRadius;
            Dx = 0;
            Dy = 2 * Const1 * y.Y;
            Delete_Put4(x.X, y.Y, xc, yc);
            p = Math.Round(Const2 - (Const1 * yRadius) + (0.25f * Const1));
            while (Dx < Dy)
            {
                x.X++;
                Dx += 2 * Const2;
                if (p < 0)
                    p += Const2 + Dx;
                else
                {
                    y.Y--;
                    Dy -= 2 * Const1;
                    p += Const2 + Dx - Dy;
                }
                Delete_Put4(x.X, y.Y, xc, yc);
            }
            p = Math.Round(Const2 * (x.X + 0.5f) * (x.X + 0.5f) + Const1 * (y.Y - 1) * (y.Y - 1) - Const1 * Const2);
            while (y.Y > 0)
            {
                y.Y--;
                Dy -= Const1 * 2;
                if (p > 0)
                    p += Const1 - Dy;
                else
                {
                    x.X++;
                    Dx += Const2 * 2;
                    p += Const1 - Dy + Dx;
                }
                Delete_Put4(x.X, y.Y, xc, yc);
            }
        }
        //-----------------------------------------------------------------------------------
        // ve HCN x1,y1: dinh bat dau; x2,y2: dinh ket thuc
        public void Put_PixelDiem(int x, int y, int xc, int yc, int color)
        {
            float tdX = x * 10 + 200 - 3 + xc * 10;
            float tdY = 200 - y * 10 - 3 + yc * 10;
            g = panel1.CreateGraphics();
            SolidBrush brush = new SolidBrush(currColor);
            //{                                    x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 + yc * 10, 6, 6
            mybuffer.Graphics.FillRectangle(brush, x * 10 + 200 - 3 + xc * 10, 200 - y * 10 - 3 + yc * 10, 6, 6);
            mybuffer.Render();
        }

        public void Ve_DTDiem(int x1, int y1, int x2, int y2, int c)
        {
            int Dx, Dy, count;
            float x, y, delta_X, delta_Y;
            Dx = x2 - x1;
            Dy = y2 - y1;
            //Lay so buoc ve
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = x1;
                y = y1;
                do
                {
                    Put_PixelDiem((int)x, (int)y, 0, 0, 0);
                    //Put_8_Pixel((int)x, (int)y, 0, 0, 0);
                    x += delta_X;
                    y += delta_Y;
                    --count;

                } while (count != -1);
            }

        }

        public void Ve_HCN(int x1, int y1, int x3, int y3, int color)
        {
            Ve_DTDiem(x1, y1, x1, y3, color);
            Ve_DTDiem(x1, y1, x3, y1, color);
            Ve_DTDiem(x3, y3, x1, y3, color);
            Ve_DTDiem(x3, y3, x3, y1, color);

        }
        public void Xoa_HCN(int x1, int y1, int x3, int y3, int color)
        {
            Xoa_DT(x1, y1, x1, y3);
            Xoa_DT(x1, y1, x3, y1);
            Xoa_DT(x3, y3, x1, y3);
            Xoa_DT(x3, y3, x3, y1);
        }
        public void Xoa_HCNbd(int x1, int y1, int x3, int y3, int color)
        {
            Xoa_DTbd(x1, y1, x1, y3);
            Xoa_DTbd(x1, y1, x3, y1);
            Xoa_DTbd(x3, y3, x1, y3);
            Xoa_DTbd(x3, y3, x3, y1);
        }
        //-----------------------------------------------------------------------------------
        // hinh binh hanh
        public void Ve_HBH(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Ve_DTDiem(x1, y1, x2, y2, 1);
            Ve_DTDiem(x2, y2, x3, y3, 1);
            int x4 = x1 + (x3 - x2);
            int y4 = y1 + (y3 - y2);
            Ve_DTDiem(x3, y3, x4, y4, 1);
            Ve_DTDiem(x4, y4, x1, y1, 1);
        }

        public void Xoa_HBHbd(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Xoa_DTbd(x1, y1, x2, y2);
            Xoa_DTbd(x2, y2, x3, y3);
            int x4 = x1 + (x3 - x2);
            int y4 = y1 + (y3 - y2);
            Xoa_DTbd(x3, y3, x4, y4);
            Xoa_DTbd(x4, y4, x1, y1);
        }
        public void Xoa_HBH(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Xoa_DT(x1, y1, x2, y2);
            Xoa_DT(x2, y2, x3, y3);
            int x4 = x1 + (x3 - x2);
            int y4 = y1 + (y3 - y2);
            Xoa_DT(x3, y3, x4, y4);
            Xoa_DT(x4, y4, x1, y1);
        }
        //-----------------------------------------------------------------------------------
        // hinh thoi
        public void Ve_HThoi(int x1, int y1, int x2, int y2)
        {
            int x3 = x2 + (x2 - x1);
            int y3 = y1;
            int x4 = x2;
            int y4 = y1 + (y1 - y2);
            Ve_DTDiem(x1, y1, x2, y2, 1);
            Ve_DTDiem(x2, y2, x3, y3, 1);
            Ve_DTDiem(x3, y3, x4, y4, 1);
            Ve_DTDiem(x4, y4, x1, y1, 1);
        }

        public void Xoa_HThoibd(int x1, int y1, int x2, int y2)
        {
            int x3 = x2 + (x2 - x1);
            int y3 = y1;
            int x4 = x2;
            int y4 = y1 + (y1 - y2);
            Xoa_DTbd(x1, y1, x2, y2);
            Xoa_DTbd(x2, y2, x3, y3);
            Xoa_DTbd(x3, y3, x4, y4);
            Xoa_DTbd(x4, y4, x1, y1);
        }
        public void Xoa_HThoi(int x1, int y1, int x2, int y2)
        {
            int x3 = x2 + (x2 - x1);
            int y3 = y1;
            int x4 = x2;
            int y4 = y1 + (y1 - y2);
            Xoa_DT(x1, y1, x2, y2);
            Xoa_DT(x2, y2, x3, y3);
            Xoa_DT(x3, y3, x4, y4);
            Xoa_DT(x4, y4, x1, y1);
        }
        //-----------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            VeHeToaDo();
            dx.Text = "x";
            dy.Text = "y";
            dz.Text = "";
            lbToaDo.Text = "";
            richTextBox1.Text = "";
            dsHHop.Clear();
            dsHThap.Clear();
            // Put_8_Pixel(10, 10, 0, 0, 1);
        }

        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            FormNhapToaDoDT DT = new FormNhapToaDoDT();
            var result = DT.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (DT.check == true)
                {
                    Xoa_DTbd(DT.getX1C(), DT.getY1C(), DT.getX2C(), DT.getY2C());
                    lbToaDo.Text = "";
                    Ve_DT(DT.getX1(), DT.getY1(), DT.getX2(), DT.getY2());
                    lbToaDo.Text = "Toạ độ đường thẳng là: " + "x1(" + DT.getX1() + "," + DT.getY1() + ")" + ", x2(" + DT.getX2() + "," + DT.getY2() + ")";

                    string chuoi = "Toạ độ đường thẳng là: " + "x1(" + DT.getX1C() + "," + DT.getY1C() + ")" + ", x2(" + DT.getX2C() + "," + DT.getY2C() + ")";
                    for (int i = 0; i < dsDT.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                    {
                        int ss = chuoi.CompareTo(dsDT[i]);
                        if (ss == 0)
                        {
                            dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                            dsDT.RemoveAt(i);
                            MessageBox.Show("da xoa ptu khoi danh sach");
                            
                        }

                    }
                    dsDT.Add("Toạ độ đường thẳng là: " + "x1(" + DT.getX1() + "," + DT.getY1() + ")" + ", x2(" + DT.getX2() + "," + DT.getY2() + ")");

                    richTextBox1.Text = "";
                    foreach (string ch in dsDT)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        //richTextBox1.Text += ch + "\n";
                    }
                    foreach(string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }
                }
                else // ve binh thuong
                {

                    Ve_DT(DT.getX1(), DT.getY1(), DT.getX2(), DT.getY2());
                    // luu danh sach thong tin duong thang tren richtextbox    
                    dsDT.Add("Toạ độ đường thẳng là: " + "x1(" + DT.getX1() + "," + DT.getY1() + ")" + ", x2(" + DT.getX2() + "," + DT.getY2() + ")");
                    richTextBox1.Text = "";
                    
                    foreach (string ch in dsDT)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }
                    
                   
                    
                    lbToaDo.Text = "";
                    lbToaDo.Text = "Toạ độ đường thẳng là: " + "x1(" + DT.getX1() + "," + DT.getY1() + ")" + ", x2(" + DT.getX2() + "," + DT.getY2() + ")";
                }
            }
            if (result == DialogResult.Yes)// nút xóa
            {

                Xoa_DTbd(DT.getX1(), DT.getY1(), DT.getX2(), DT.getY2());
                lbToaDo.Text = "";

                // remove khoi danh sach thong tin
                string chuoi = "Toạ độ đường thẳng là: " + "x1(" + DT.getX1() + "," + DT.getY1() + ")" + ", x2(" + DT.getX2() + "," + DT.getY2() + ")";
                for (int i = 0; i < dsDT.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                {
                    int ss = chuoi.CompareTo(dsDT[i]);
                    if (ss == 0)
                    {
                        dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                        dsDT.RemoveAt(i);
                        MessageBox.Show("da xoa ptu khoi danh sach");
                    }
                }
                richTextBox1.Text = "";
                foreach (string ch in dsDT)
                {
                    richTextBox1.Text += ch + "\n";
                }
            }
        }




        private void btnHinhTron_Click(object sender, EventArgs e)
        {
            FormNhapToaDoTron TDTron = new FormNhapToaDoTron();
            var result = TDTron.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (TDTron.check == true)
                {
                    Xoa_HTronbd(TDTron.getXC(), TDTron.getYC(), TDTron.getBKC());
                    lbToaDo.Text = "";
                    Ve_HTron(TDTron.getX(), TDTron.getY(), TDTron.getBK());
                    lbToaDo.Text = "Toạ độ hình tròn là: " + "(" + TDTron.getX() + "," + TDTron.getY() + ")" + ", Bán kính(" + TDTron.getBK() + ")";

                    string chuoi = "Toạ độ hình tròn là: " + "x1(" + TDTron.getX() + "," + TDTron.getY() + ")" + ", Bán kính(" + TDTron.getBK() + ")";
                    for (int i = 0; i < dsHTron.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                    {
                        int ss = chuoi.CompareTo(dsHTron[i]);
                        if (ss == 0)
                        {
                            dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                            dsHTron.RemoveAt(i);
                            MessageBox.Show("da xoa ptu khoi danh sach");
                        }

                    }
                    dsHTron.Add("Toạ độ hình tròn là: " + "(" + TDTron.getX() + "," + TDTron.getY() + ")" + ", Bán kính(" + TDTron.getBK() + ")");

                    richTextBox1.Text = "";
                    foreach (string ch in dsHTron)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        //richTextBox1.Text += ch + "\n";
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }
                }
                
                else // ve binh thuong
                {

                    Ve_HTron(TDTron.getX(), TDTron.getY(), TDTron.getBK());
                    // luu danh sach thong tin duong thang tren richtextbox    
                    dsHTron.Add("Toạ độ hình tròn là: " + "x1(" + TDTron.getX() + "," + TDTron.getY() + ")" + ", Bán kính(" + TDTron.getBK() + ")");
                    richTextBox1.Text = "";
                    foreach (string ch in dsHTron)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        //richTextBox1.Text += ch + "\n";
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }

                    lbToaDo.Text = "";
                    lbToaDo.Text = "Toạ độ hình tròn là: " + "x1(" + TDTron.getX() + "," + TDTron.getY() + ")" + ", Bán kính(" + TDTron.getBK() + ")";
                }
            }
            if (result == DialogResult.Yes) // nút xóa
            {
                Xoa_HTron(TDTron.getX(), TDTron.getY(), TDTron.getBK());
                lbToaDo.Text = "";
                string chuoi = "Toạ độ hình tròn là: " + "x1(" + TDTron.getX() + "," + TDTron.getY() + ")" + ", Bán kính(" + TDTron.getBK() + ")";
                for (int i = 0; i < dsHTron.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                {
                    int ss = chuoi.CompareTo(dsHTron[i]);
                    if (ss == 0)
                    {
                        dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                        dsHTron.RemoveAt(i);
                        MessageBox.Show("da xoa ptu khoi danh sach");
                    }
                }
                richTextBox1.Text = "";
                foreach (string ch in dsHTron)
                {
                    richTextBox1.Text += ch + "\n";
                }
            }

        }



        private void btnHCN_Click(object sender, EventArgs e)
        {
            FormNhapToaDoHCN HCN = new FormNhapToaDoHCN();
            var result = HCN.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (HCN.check == true)
                {
                    Xoa_HCNbd(HCN.getX1C(), HCN.getY1C(), HCN.getX2C(), HCN.getY2C(), 0);
                    lbToaDo.Text = "";
                    Ve_HCN(HCN.getX1(), HCN.getY1(), HCN.getX2(), HCN.getY2(), 0);
                    lbToaDo.Text = "Toạ độ hình chữ nhật là: " + "Điểm 1(" + HCN.getX1() + "," + HCN.getY1() + ")" + ", Điểm 2(" + HCN.getX2() + "," + HCN.getY2() + ")";

                    string chuoi = "Toạ độ hình chữ nhật là: " + "Điểm 1(" + HCN.getX1() + "," + HCN.getY1() + ")" + ", Điểm 2(" + HCN.getX2() + "," + HCN.getY2() + ")";
                    for (int i = 0; i < dsDT.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                    {
                        int ss = chuoi.CompareTo(dsHCN[i]);
                        if (ss == 0)
                        {
                            dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                            dsHCN.RemoveAt(i);
                            MessageBox.Show("da xoa ptu khoi danh sach");

                        }

                    }
                    dsHCN.Add("Toạ độ hình chữ nhật là: " + "Điểm 1(" + HCN.getX1() + "," + HCN.getY1() + ")" + ", Điểm 2(" + HCN.getX2() + "," + HCN.getY2() + ")");

                    richTextBox1.Text = "";
                    foreach (string ch in dsHCN)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        //richTextBox1.Text += ch + "\n";
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }
                }
                else // ve binh thuong
                {

                    Ve_HCN(HCN.getX1(), HCN.getY1(), HCN.getX2(), HCN.getY2(), 0);
                    // luu danh sach thong tin duong thang tren richtextbox    
                    dsHCN.Add("Toạ độ hình chữ nhật là: " + "Điểm 1(" + HCN.getX1() + "," + HCN.getY1() + ")" + ", Điểm 2(" + HCN.getX2() + "," + HCN.getY2() + ")");
                    richTextBox1.Text = "";

                    foreach (string ch in dsHCN)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }

                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }



                    lbToaDo.Text = "";
                    lbToaDo.Text = "Toạ độ hình chữ nhật là: " + "Điểm 1(" + HCN.getX1() + "," + HCN.getY1() + ")" + ", Điểm 2(" + HCN.getX2() + "," + HCN.getY2() + ")";
                }
            }
            if (result == DialogResult.Yes)// nút xóa
            {

                Xoa_HCNbd(HCN.getX1(), HCN.getY1(), HCN.getX2(), HCN.getY2(), 0);
                lbToaDo.Text = "";

                // remove khoi danh sach thong tin
                string chuoi = "Toạ độ hình chữ nhật là: " + "Điểm 1(" + HCN.getX1() + "," + HCN.getY1() + ")" + ", Điểm 2(" + HCN.getX2() + "," + HCN.getY2() + ")";
                for (int i = 0; i < dsHCN.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                {
                    int ss = chuoi.CompareTo(dsHCN[i]);
                    if (ss == 0)
                    {
                        dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                        dsHCN.RemoveAt(i);
                        MessageBox.Show("da xoa ptu khoi danh sach");
                    }
                }
                richTextBox1.Text = "";
                foreach (string ch in dsHCN)
                {
                    richTextBox1.Text += ch + "\n";
                }
            }
        }

        private void btnVeEllip_Click(object sender, EventArgs e)
        {
            FormNhapToaDoEllip EL = new FormNhapToaDoEllip();
            var result = EL.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (EL.check == true)
                {
                    Xoa_Elipbd(EL.getXC(), EL.getYC(), EL.getWC(), EL.getHC());
                    lbToaDo.Text = "";
                    //g = panel1.CreateGraphics();
                    for (int i = 0; i <= 40; i++)
                    {
                        mybuffer.Graphics.DrawLine(new Pen(Color.Green), i * 10, 0, i * 10, 400);
                        mybuffer.Graphics.DrawLine(new Pen(Color.Green), 0, i * 10, 400, i * 10);
                    }
                    mybuffer.Graphics.DrawLine(new Pen(Color.Red), 200, 0, 200, 400);
                    mybuffer.Graphics.DrawLine(new Pen(Color.Red), 0, 200, 400, 200);
                    Ve_Elip(EL.getX(), EL.getY(), EL.getW(), EL.getH());
                    lbToaDo.Text = "Toạ độ Ellip là: " + "(" + EL.getX() + "," + EL.getY() + ")" + ", Chiều rộng(" + EL.getW() + ")" + ", Chiều cao(" + EL.getH() + ")";
                    mybuffer.Render();

                    string chuoi = "Toạ độ Ellip là: " + "(" + EL.getX() + "," + EL.getY() + ")" + ", Chiều rộng(" + EL.getW() + ")" + ", Chiều cao(" + EL.getH() + ")";
                    for (int i = 0; i < dsEll.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                    {
                        int ss = chuoi.CompareTo(dsEll[i]);
                        if (ss == 0)
                        {
                            dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                            dsEll.RemoveAt(i);
                            MessageBox.Show("da xoa ptu khoi danh sach");

                        }

                    }
                    dsEll.Add("Toạ độ Ellip là: " + "(" + EL.getX() + "," + EL.getY() + ")" + ", Chiều rộng(" + EL.getW() + ")" + ", Chiều cao(" + EL.getH() + ")");

                    richTextBox1.Text = "";
                    foreach (string ch in dsEll)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }
                
            }
                else // ve binh thuong
                {

                    Ve_Elip(EL.getX(), EL.getY(), EL.getW(), EL.getH());
                    // luu danh sach thong tin duong thang tren richtextbox    
                    dsEll.Add("Toạ độ Ellip là: " + "(" + EL.getX() + "," + EL.getY() + ")" + ", Chiều rộng(" + EL.getW() + ")" + ", Chiều cao(" + EL.getH() + ")");
                    richTextBox1.Text = "";

                    foreach (string ch in dsEll)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }

                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }



                    lbToaDo.Text = "";
                    lbToaDo.Text = "Toạ độ Ellip là: " + "(" + EL.getX() + "," + EL.getY() + ")" + ", Chiều rộng(" + EL.getW() + ")" + ", Chiều cao(" + EL.getH() + ")";
                }
            }
            if (result == DialogResult.Yes)
            {
                Xoa_Elipbd(EL.getX(), EL.getY(), EL.getW(), EL.getH());

                for (int i = 0; i <= 40; i++)
                {
                    g.DrawLine(new Pen(Color.Green), i * 10, 0, i * 10, 400);
                    g.DrawLine(new Pen(Color.Green), 0, i * 10, 400, i * 10);
                }
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 200, 0, 200, 400);
                mybuffer.Graphics.DrawLine(new Pen(Color.Red), 0, 200, 400, 200);
                //mybuffer.Render();

                string chuoi = "Toạ độ Ellip là: " + "(" + EL.getX() + "," + EL.getY() + ")" + ", Chiều rộng(" + EL.getW() + ")" + ", Chiều cao(" + EL.getH() + ")";
                for (int i = 0; i < dsEll.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                {
                    int ss = chuoi.CompareTo(dsEll[i]);
                    if (ss == 0)
                    {
                        dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                        dsEll.RemoveAt(i);
                        MessageBox.Show("da xoa ptu khoi danh sach");
                    }
                }
                richTextBox1.Text = "";
                foreach (string ch in dsEll)
                {
                    richTextBox1.Text += ch + "\n";
                }
            }
        }
        private void btn_HBH_Click(object sender, EventArgs e)
        {
            FormNhapToaDoHBH HBH = new FormNhapToaDoHBH();
            var result = HBH.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (HBH.check == true)
                {
                    Xoa_HBHbd(HBH.getX1C(), HBH.getY1C(), HBH.getX2C(), HBH.getY2C(), HBH.getX3C(), HBH.getY3C());
                    lbToaDo.Text = "";
                    Ve_HBH(HBH.getX1(), HBH.getY1(), HBH.getX2(), HBH.getY2(), HBH.getX3(), HBH.getY3());
                    lbToaDo.Text = "Toạ độ hình bình hành là: " + "Điểm 1(" + HBH.getX1() + "," + HBH.getY1() + ")" + ", Điểm 2(" + HBH.getX2() + "," + HBH.getY2() + ")" + ", Đỉnh(" + HBH.getX3() + "," + HBH.getY3() + ")";

                    string chuoi = "Toạ độ hình bình hành là: " + "Điểm 1(" + HBH.getX1() + "," + HBH.getY1() + ")" + ", Điểm 2(" + HBH.getX2() + "," + HBH.getY2() + ")" + ", Đỉnh(" + HBH.getX3() + "," + HBH.getY3() + ")";
                    for (int i = 0; i < dsHBH.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                    {
                        int ss = chuoi.CompareTo(dsHBH[i]);
                        if (ss == 0)
                        {
                            dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                            dsHBH.RemoveAt(i);
                            MessageBox.Show("da xoa ptu khoi danh sach");
                        }

                    }
                    dsHBH.Add("Toạ độ hình bình hành là: " + "Điểm 1(" + HBH.getX1() + "," + HBH.getY1() + ")" + ", Điểm 2(" + HBH.getX2() + "," + HBH.getY2() + ")" + ", Đỉnh(" + HBH.getX3() + "," + HBH.getY3() + ")");

                    richTextBox1.Text = "";
                    foreach (string ch in dsHBH)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        //richTextBox1.Text += ch + "\n";
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }
                }
                else // ve binh thuong
                {

                    Ve_HBH(HBH.getX1(), HBH.getY1(), HBH.getX2(), HBH.getY2(), HBH.getX3(), HBH.getY3());
                    // luu danh sach thong tin duong thang tren richtextbox    
                    dsHBH.Add("Toạ độ hình bình hành là: " + "Điểm 1(" + HBH.getX1() + "," + HBH.getY1() + ")" + ", Điểm 2(" + HBH.getX2() + "," + HBH.getY2() + ")" + ", Đỉnh(" + HBH.getX3() + "," + HBH.getY3() + ")");
                    richTextBox1.Text = "";
                    foreach (string ch in dsHBH)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        //richTextBox1.Text += ch + "\n";
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }


                    lbToaDo.Text = "";
                    lbToaDo.Text = "Toạ độ hình bình hành là: " + "Điểm 1(" + HBH.getX1() + "," + HBH.getY1() + ")" + ", Điểm 2(" + HBH.getX2() + "," + HBH.getY2() + ")" + ", Đỉnh(" + HBH.getX3() + "," + HBH.getY3() + ")";
                }
            }
            if (result == DialogResult.Yes) // nút xóa
            {
                Xoa_HBHbd(HBH.getX1(), HBH.getY1(), HBH.getX2(), HBH.getY2(), HBH.getX3(), HBH.getY3());
                lbToaDo.Text = "";
                string chuoi = "Toạ độ hình bình hành là: " + "Điểm 1(" + HBH.getX1() + "," + HBH.getY1() + ")" + ", Điểm 2(" + HBH.getX2() + "," + HBH.getY2() + ")" + ", Đỉnh(" + HBH.getX3() + "," + HBH.getY3() + ")";
                for (int i = 0; i < dsHBH.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                {
                    int ss = chuoi.CompareTo(dsHBH[i]);
                    if (ss == 0)
                    {
                        dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                        dsHBH.RemoveAt(i);
                        MessageBox.Show("da xoa ptu khoi danh sach");
                    }
                }
                richTextBox1.Text = "";
                foreach (string ch in dsHBH)
                {
                    richTextBox1.Text += ch + "\n";
                }
            }

        }
        private void btnHinhThoi_Click(object sender, EventArgs e)
        {
            FormNhapToaDoHT HT = new FormNhapToaDoHT();
            var result = HT.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (HT.check == true)
                {
                    Xoa_HThoibd(HT.getX1C(), HT.getY1C(), HT.getX2C(), HT.getY2C());
                    lbToaDo.Text = "";
                    Ve_HThoi(HT.getX1(), HT.getY1(), HT.getX2(), HT.getY2());
                    lbToaDo.Text = "Toạ độ hình thoi là: " + "Điểm 1(" + HT.getX1() + "," + HT.getY1() + ")" + ", Điểm 2(" + HT.getX2() + "," + HT.getY2() + ")";

                    string chuoi = "Toạ độ hình thoi là: " + "Điểm 1(" + HT.getX1() + "," + HT.getY1() + ")" + ", Điểm 2(" + HT.getX2() + "," + HT.getY2() + ")";
                    for (int i = 0; i < dsHThoi.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                    {
                        int ss = chuoi.CompareTo(dsHThoi[i]);
                        if (ss == 0)
                        {
                            dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                            dsHThoi.RemoveAt(i);
                            MessageBox.Show("da xoa ptu khoi danh sach");
                        }

                    }
                    dsHThoi.Add("Toạ độ hình thoi là: " + "Điểm 1(" + HT.getX1() + "," + HT.getY1() + ")" + ", Điểm 2(" + HT.getX2() + "," + HT.getY2() + ")");

                    richTextBox1.Text = "";
                    foreach (string ch in dsHThoi)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        //richTextBox1.Text += ch + "\n";
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }                

            }
            else //vẽ bình thường
                {
                    Ve_HThoi(HT.getX1(), HT.getY1(), HT.getX2(), HT.getY2());
                    dsHThoi.Add("Toạ độ hình thoi là: " + "Điểm 1(" + HT.getX1() + "," + HT.getY1() + ")" + ", Điểm 2(" + HT.getX2() + "," + HT.getY2() + ")");
                    richTextBox1.Text = "";
                    foreach (string ch in dsHThoi)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        //richTextBox1.Text += ch + "\n";
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }

                    lbToaDo.Text = "";
                    lbToaDo.Text = "Toạ độ hình thoi là: " + "Điểm 1(" + HT.getX1() + "," + HT.getY1() + ")" + ", Điểm 2(" + HT.getX2() + "," + HT.getY2() + ")";
                }
            }
            if (result == DialogResult.Yes) //nút xóa
            {
                Xoa_HThoibd(HT.getX1(), HT.getY1(), HT.getX2(), HT.getY2());          
                lbToaDo.Text = "";
                string chuoi = "Toạ độ hình thoi là: " + "Điểm 1(" + HT.getX1() + "," + HT.getY1() + ")" + ", Điểm 2(" + HT.getX2() + "," + HT.getY2() + ")";
                for (int i = 0; i < dsHThoi.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                {
                    int ss = chuoi.CompareTo(dsHThoi[i]);
                    if (ss == 0)
                    {
                        dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                        dsHThoi.RemoveAt(i);
                        MessageBox.Show("da xoa ptu khoi danh sach");
                        dsHThoi.Add("Toạ độ hình thoi là: " + "Điểm 1(" + HT.getX1() + "," + HT.getY1() + ")" + ", Điểm 2(" + HT.getX2() + "," + HT.getY2() + ")");
                    }
                    richTextBox1.Text = "";
                    foreach (string ch in dsHThoi)
                    {
                        richTextBox1.Text += ch + "\n";
                    }
                }

            }
        }
        //---------------------------------ve tam giac----------------------------------------
        public void Ve_TGiac(int x, int y, int c, int chedo)
        {
            switch (chedo)
            {
                case 1:
                    Ve_DT(x, y, x, y + c);
                    Ve_DT(x, y, x - c, y);
                    Ve_DT(x, y + c, x - c, y);
                    break;
                case 2:
                    Ve_DT(x, y, x + c, y);
                    Ve_DT(x, y, x, y - c);
                    Ve_DT(x + c, y, x, y - c);
                    break;
                case 3:
                    Ve_DT(x, y, x, y - c);
                    Ve_DT(x, y, x - c, y);
                    Ve_DT(x, y - c, x - c, y);
                    break;
                default:
                    Ve_DT(x, y, x, y + c);
                    Ve_DT(x, y, x + c, y);
                    Ve_DT(x, y + c, x + c, y);
                    break;
            }
        }
        public void Xoa_TGiacbd(int x, int y, int c)
        {
            Xoa_DTbd(x, y, x, y + c);
            Xoa_DTbd(x, y, x + c, y);
            Xoa_DTbd(x, y + c, x + c, y);
        }
        public void Xoa_TGiac(int x, int y, int c)
        {
            Xoa_DT(x, y, x, y + c);
            Xoa_DT(x, y, x + c, y);
            Xoa_DT(x, y + c, x + c, y);
        }
        private void btnTamGiac_Click(object sender, EventArgs e)
        {
            FormToaDoTamGiac TG = new FormToaDoTamGiac();
            var result = TG.ShowDialog();
            int chedotg = TG.chedotamgiac;
            if (result == DialogResult.OK)
            {
                if (TG.check == true)
                {
                    Xoa_TGiacbd(TG.getXC(), TG.getYC(), TG.getCC());
                    lbToaDo.Text = "";
                    Ve_TGiac(TG.getX(), TG.getY(), TG.getC(), chedotg);
                    lbToaDo.Text = "";
                    lbToaDo.Text = "Toạ độ hình tam giác là: " + "X = " + TG.getX() + ", Y = " + TG.getY() + ", Cạnh = " + TG.getC();

                    string chuoi = "Toạ độ hình tam giác là: " + "X = " + TG.getX() + ", Y = " + TG.getY() + ", Cạnh = " + TG.getC();
                    for (int i = 0; i < dsTGiac.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                    {
                        int ss = chuoi.CompareTo(dsTGiac[i]);
                        if (ss == 0)
                        {
                            dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                            dsTGiac.RemoveAt(i);
                            MessageBox.Show("da xoa ptu khoi danh sach");
                            dsTGiac.Add("Toạ độ hình tam giác là: " + "X = " + TG.getX() + ", Y = " + TG.getY() + ", Cạnh = " + TG.getC());
                        }
                    }
                    richTextBox1.Text = "";
                    foreach (string ch in dsTGiac)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        //richTextBox1.Text += ch + "\n";
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }

            }
            else // vẽ bình thường
                {
                    Ve_TGiac(TG.getX(), TG.getY(), TG.getC(), chedotg);
                    dsTGiac.Add("Toạ độ hình tam giác là: " + "X = " + TG.getX() + ", Y = " + TG.getY() + ", Cạnh = " + TG.getC());
                    richTextBox1.Text = "";
                    foreach (string ch in dsTGiac)
                    {
                        if (!dsHien.Contains(ch.Trim()))
                        {
                            dsHien.Add(ch);
                        }
                        //richTextBox1.Text += ch + "\n";
                    }
                    foreach (string c in dsHien)
                    {
                        richTextBox1.Text += c + "\n";
                    }

                    lbToaDo.Text = "";
                    lbToaDo.Text = "Toạ độ hình tam giác là: " + "X = " + TG.getX() + ", Y = " + TG.getY() + ", Cạnh = " + TG.getC();
                }
            }
            if (result == DialogResult.Yes) // nút xóa
            {
                Xoa_TGiacbd(TG.getX(), TG.getY(), TG.getC());                
                lbToaDo.Text = "";
                string chuoi = "Toạ độ hình tam giác là: " + "X = " + TG.getX() + ", Y = " + TG.getY() + ", Cạnh = " + TG.getC();
                for (int i = 0; i < dsTGiac.Count; i++) //=0 la bang nhau, 1 thi chuoi>ds[i], -1 nguoc lai
                {
                    int ss = chuoi.CompareTo(dsTGiac[i]);
                    if (ss == 0)
                    {
                        dsHien.RemoveAt(dsHien.IndexOf(chuoi.Trim()));
                        dsTGiac.RemoveAt(i);
                        MessageBox.Show("da xoa ptu khoi danh sach");
                        dsTGiac.Add("Toạ độ hình tam giác là: " + "X = " + TG.getX() + ", Y = " + TG.getY() + ", Cạnh = " + TG.getC());
                    }
                }
                richTextBox1.Text = "";
                foreach (string ch in dsTGiac)
                {
                    richTextBox1.Text += ch + "\n";
                }

            }
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (chedo2d == true)
            {
                lbToaDo.Text = "";
                richTextBox1.Text = "";
                dsDT.Clear();
                dsEll.Clear();
                dsHBH.Clear();
                dsHCN.Clear();
                dsHien.Clear();
                dsHThoi.Clear();
                dsHTron.Clear();
                dsTGiac.Clear();
                dsHHop.Clear();
                dsHThap.Clear();
                VeHeToaDo();
            }
            else
            {
                lbToaDo.Text = "";
                richTextBox1.Text = "";
                dsDT.Clear();
                dsDT.Clear();
                dsEll.Clear();
                dsHBH.Clear();
                dsHCN.Clear();
                dsHien.Clear();
                dsHThoi.Clear();
                dsHTron.Clear();
                dsTGiac.Clear();
                dsHHop.Clear();
                dsHThap.Clear();
                Ve3D();
            }
        }

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            //cld.ShowDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                if (currButtonColor == ButtonColor.LEFT)
                {
                    btnMauLeft.BackColor = cld.Color;
                }
                else
                {
                    btnMauRight.BackColor = cld.Color;
                }
                currColor = cld.Color;
            }
        }

        private void btnMauLeft_Click(object sender, EventArgs e)
        {
            currButtonColor = ButtonColor.LEFT;
            currColor = btnMauLeft.BackColor;
        }

        private void btnMauRight_Click(object sender, EventArgs e)
        {
            currButtonColor = ButtonColor.RIGHT;
            currColor = btnMauRight.BackColor;
        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Mon: Kỹ thuật đồ họa" + "\n" + "- Nguyễn Ngọc Bảo Thy N14DCCN145" + "\n" +
                "- Phương Tú Hiền N14DCCN125" + "\n" + " - Trần Nữ Tú Anh N14DCCN111");
        }

        

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Ban co chac thoat khong?", "Thong tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form2_MinimumSizeChanged(object sender, EventArgs e)
        {
            mybuffer.Render();
        }

        private void Form2_LocationChanged(object sender, EventArgs e)
        {
            mybuffer.Render();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            mybuffer.Render();
        }

        //--------------------------------------------------hinh 3d-------------------------------------
        /*public void PutPixels(int x, int y)
        {
            SolidBrush brush = new SolidBrush(currColor);
            Pen p = new Pen(currColor);
            mybuffer.Graphics.FillRectangle(brush, x, y, 2, 2);

        }
        public void Ve_DTs(int x1, int y1, int x2, int y2)
        {
            int Dx, Dy, count;
            float x, y, delta_X, delta_Y;
            Dx = x2 - x1;
            Dy = y2 - y1;
            //Lay so buoc ve
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = x1;
                y = y1;
                do
                {

                    PutPixels((int)x, (int)y);
                    //Put_8_Pixel((int)x, (int)y, 0, 0, 0);
                    x += delta_X;
                    y += delta_Y;
                    --count;

                } while (count != -1);
            }

        }*/
        private void btnHinhTru_Click(object sender, EventArgs e)
        {
            //int x = 0, y = 5, z = 1;
            //int tamdayX = (int)(x - y * Math.Sqrt(2) / 2);
            //int tamdayY = (int)(z - y * Math.Sqrt(2) / 2);

            // chu y: truc x nam ngang, truc y nam xeo, truc z nam thang dung

            int tamdayX = 4 - 2; // nhap; toa do x nhap vao - toa do y nhap vao = toa do x trong 3d
            int tamdayY = 2 * -1; // nhap; toa do y nhap vao *-1 = toa do y trong 3d
            int berongday = 5; // co dinh
            int becaoday = 3; // co dinh
            int chieucao = 15;// nhap

            //int BK3d = 5;
            //Ve_HTron(tamdayX,tamdayY, BK3d); // hinh tron day duoi
            //Ve_HTron(tamdayX, tamdayY+chieucao, BK3d); // hinh tron day tren
            //Ve_DT(tamdayX + BK3d, tamdayY + chieucao, tamdayX + BK3d, tamdayY); // dthang ben phai
            //Ve_DT(tamdayX - BK3d, tamdayY + chieucao, tamdayX - BK3d, tamdayY); // duong thang ben trai


            Ve_Elip(tamdayX, tamdayY, berongday, becaoday);
            Ve_Elip(tamdayX, tamdayY + chieucao, berongday, becaoday);
            //Ve_DT(tamdayX, tamdayY, tamdayX, tamdayY + chieucao); // dthag tam
            Ve_DT(tamdayX + berongday, tamdayY + chieucao, tamdayX + berongday, tamdayY); // dthag ben phai, di tu tren xuong 
            Ve_DT(tamdayX - berongday, tamdayY + chieucao, tamdayX - berongday, tamdayY); // dthang ben trai, di tu tren xuong

        }

        //*-------------------------------------------------------------------
        public void Ve_HHop(int x0, int y0, int z0, int d, int r, int c)
        {


            // diem p0
            int p0x = chuyentoadoX2d(x0, y0, z0);
            int p0y = chuyentoadoY2d(x0, y0, z0);
            int p0z = z0;
            Put_Pixel(p0x, p0y, 0, 0);

            // diem p3
            int p3x = p0x, p3y = p0y, p3z = c;
            Put_Pixel(p3x, p3z, 0, 0);

            // diem p5
            int p5x = d, p5y = r, p5z = p0z;
            Put_Pixel(p5x - p5y, -p5y, 0, 0);

            // diem p1
            int p1x = p5x, p1y = p0y, p1z = p0z;
            Put_Pixel(p1x, p1y, 0, 0);

            // diem p2
            int p2x = p5x, p2y = p3y, p2z = p3z;
            Put_Pixel(p2x, p2z, 0, 0);

            // diem p4
            int p4x = p0x, p4y = p5y, p4z = p0z;
            Put_Pixel(p4x - p4y, -p4y, 0, 0);

            // diem p6
            int p6x = p5x, p6y = p5y, p6z = p3z;
            Put_Pixel(p6x - p5y, -p6y + c, 0, 0);

            // diem p7
            int p7x = p0x, p7y = p5y, p7z = p3z;
            Put_Pixel(p4x - p4y, -p4y + c, 0, 0);

            // net dut
            Ve_DT(p0x, p0y, p3x, p3z); //p0-p3
            Ve_DT(p0x, p0y, p1x, p1y); //p0-p1
            Ve_DT(p0x, p0y, p4x - p4y, -p4y); //p0-p4

            //net lien
            Pen p = new Pen(currColor);

            int x3 = doihe3dX(p3x, 0, 0), y3 = doihe3dY(p3z, 0, 0);
            int x2 = doihe3dX(p2x, 0, 0), y2 = doihe3dY(p2z, 0, 0);
            int x1 = doihe3dX(p1x, 0, 0), y1 = doihe3dY(p1y, 0, 0);
            int x7 = doihe3dX(p4x - p4y, 0, 0), y7 = doihe3dY(-p4y + c, 0, 0);
            int x4 = doihe3dX(p4x - p4y, 0, 0), y4 = doihe3dY(-p4y, 0, 0);
            int x6 = doihe3dX(p6x - p5y, 0, 0), y6 = doihe3dY(-p6y + c, 0, 0);
            int x5 = doihe3dX(p5x - p5y, 0, 0), y5 = doihe3dY(-p5y, 0, 0);

            /*mybuffer.Graphics.DrawLine(p, x3, y3, x2, y2); // p3-p2
            mybuffer.Graphics.DrawLine(p, x2, y2, x1, y1); // p2-p1
            mybuffer.Graphics.DrawLine(p, x3, y3, x7, y7); // p3-p7
            mybuffer.Graphics.DrawLine(p, x7, y7, x4, y4); // p7-p4
            mybuffer.Graphics.DrawLine(p, x7, y7, x6, y6); // p7-p6
            mybuffer.Graphics.DrawLine(p, x4, y4, x5, y5); // p4-p5
            mybuffer.Graphics.DrawLine(p, x6, y6, x5, y5); // p6-p5
            mybuffer.Graphics.DrawLine(p, x6, y6, x2, y2); // p6-p2
            mybuffer.Graphics.DrawLine(p, x5, y5, x1, y1); // p5-p1
            */
            mybuffer.Graphics.DrawLine(p, x3, y3, x2, y2); // p3-p2
            mybuffer.Graphics.DrawLine(p, x2, y2, x1, y1); // p2-p1
            mybuffer.Graphics.DrawLine(p, x3, y3, x7, y7); // p3-p7
            mybuffer.Graphics.DrawLine(p, x7, y7, x4, y4); // p7-p4
            mybuffer.Graphics.DrawLine(p, x7, y7, x6, y6); // p7-p6
            mybuffer.Graphics.DrawLine(p, x4, y4, x5, y5); // p4-p5
            mybuffer.Graphics.DrawLine(p, x6, y6, x5, y5); // p6-p5
            mybuffer.Graphics.DrawLine(p, x6, y6, x2, y2); // p6-p2
            mybuffer.Graphics.DrawLine(p, x5, y5, x1, y1); // p5-p1
            mybuffer.Render();
        }

        private void btnHinhHop_Click(object sender, EventArgs e)
        {
            FormToaDoHinhHop HHop = new FormToaDoHinhHop();
            var result = HHop.ShowDialog();
            if (result == DialogResult.OK)
            {
                Ve_HHop(HHop.getX(), HHop.getY(), HHop.getZ(), HHop.getD(), HHop.getR(), HHop.getC());
                dsHHop.Add( "Toạ độ hình hình hộp là: " + "(" + HHop.getX() + ", " + HHop.getY() + ", " + HHop.getZ() + ") dài: " + HHop.getD() + ", rộng: " + HHop.getR() + " ,cao: " + HHop.getC());

                richTextBox1.Text = "";
                foreach (string ch in dsHHop)
                {
                    if (!dsHien.Contains(ch.Trim()))
                    {
                        dsHien.Add(ch);
                    }
                    //richTextBox1.Text += ch + "\n";
                }
                foreach (string c in dsHien)
                {
                    richTextBox1.Text += c + "\n";
                }


                lbToaDo.Text = "";
                lbToaDo.Text = "Toạ độ hình hình hộp là: " + "(" + HHop.getX() + ", " + HHop.getY() + ", " + HHop.getZ() + ") dài: " + HHop.getD() + ", rộng: " + HHop.getR() + " ,cao: " + HHop.getC();


            }
        }
        //*----------------------------------------------------------------
        public int chuyentoadoX2d(int x, int y, int z)
        {
            int x2d = x - (int)(y * Math.Sqrt(2) / 2);
            //MessageBox.Show("x1: " + x2d);
            return x2d;
        }

        public int chuyentoadoY2d(int x, int y, int z)
        {
            int y2d = z - (int)(y * Math.Sqrt(2) / 2);
            //MessageBox.Show("y1: " + y2d);
            return y2d;
        }

        public int doihe3dX(int x, int xc, int yc)
        {
            int tdX = (int)(x * 10 + 200 + xc * 10);
            return tdX;
        }

        public int doihe3dY(int y, int xc, int yc)
        {
            int tdY = (int)(200 - y * 10 + yc * 10);
            return tdY;
        }

        public void Ve_HThap(int d, int r, int c, int x0, int y0, int z0)
        {

            int dx = 0, dy = 0, dz = z0 + c;

            int dx0 = chuyentoadoX2d(dx, dy, dz);
            int dy0 = chuyentoadoY2d(dx, dy, dz);
            int dz0 = dz;
            Put_Pixel(dx0, dy0, 0, 0);

            // diem goc day p0
            int p0x = chuyentoadoX2d(x0, y0, z0);
            int p0y = chuyentoadoY2d(x0, y0, z0);
            int p0z = dz;
            Put_Pixel(p0x, p0y, 0, 0);

            // diem p5
            int p5x = d, p5y = r, p5z = p0z;
            Put_Pixel(p5x - p5y, -p5y, 0, 0);

            // diem p1
            int p1x = p5x, p1y = p0y, p1z = p0z;
            Put_Pixel(p1x, p1y, 0, 0);

            // diem p4
            int p4x = p0x, p4y = p5y, p4z = p0z;
            Put_Pixel(p4x - p4y, -p4y, 0, 0);

            // net dut
             Ve_DT(dx0, dy0, p0x, p0y);
            Ve_DT(p0x, p0y, p1x, p1y);
            Ve_DT(p0x, p0y, p4x - p4y, -p4y);

            // net lien
            Pen p = new Pen(currColor);
            int x1 = doihe3dX(p1x, 0, 0), y1 = doihe3dY(p1y, 0, 0);
            int x5 = doihe3dX(p5x - p5y, 0, 0), y5 = doihe3dY(-p5y, 0, 0);
            int x4 = doihe3dX(p4x - p4y, 0, 0), y4 = doihe3dY(-p4y, 0, 0);
            int dx00 = doihe3dX(dx0, 0, 0), dy00 = doihe3dY(dy0, 0, 0);
            int x00 = doihe3dX(p0x, 0, 0), y00 = doihe3dY(p0y, 0, 0);

            mybuffer.Graphics.DrawLine(p, x5, y5, x4, y4); // p4-p5
            mybuffer.Graphics.DrawLine(p, x1, y1, x5, y5); // p1-p5
            mybuffer.Graphics.DrawLine(p, dx00, dy00, x4, y4); // dinh-p4
            mybuffer.Graphics.DrawLine(p, dx00, dy00, x5, y5); // dinh-p5
            mybuffer.Graphics.DrawLine(p, dx00, dy00, x1, y1); // dinh-p4
            //mybuffer.Graphics.DrawLine(p, dx00, dy00, x00, y00); // dinh-p0

            mybuffer.Render();
        }

        private void btnHinhThap_Click(object sender, EventArgs e)
        {
            FormToaDoHinhThap HThap = new FormToaDoHinhThap();
            var result = HThap.ShowDialog();
            if (result == DialogResult.OK)
            {
                Ve_HThap(HThap.getD(), HThap.getR(), HThap.getC(), HThap.getX(), HThap.getY(), HThap.getZ());
                dsHThap.Add("Toạ độ hình hình tháp là: (" +HThap.getX() +", "+HThap.getY()+", "+HThap.getZ()+ "); dài: " + HThap.getD() + ", rộng: " + HThap.getR() + " ,cao: " + HThap.getC());
                richTextBox1.Text = "";
                foreach (string ch in dsHThap)
                {
                    if (!dsHien.Contains(ch.Trim()))
                    {
                        dsHien.Add(ch);
                    }
                    //richTextBox1.Text += ch + "\n";
                }
                foreach (string c in dsHien)
                {
                    richTextBox1.Text += c + "\n";
                }


                lbToaDo.Text = "";
                lbToaDo.Text = "Toạ độ hình hình tháp là: (" + HThap.getX() + ", " + HThap.getY() + ", " + HThap.getZ() + "); dài: " + HThap.getD() + ", rộng: " + HThap.getR() + " ,cao: " + HThap.getC();
            }
        }



        internal void Ve_DT(object p1, object p2, object p3, object p4)
        {
            throw new NotImplementedException();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}
