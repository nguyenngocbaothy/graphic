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
    public partial class FormToaDoHinhThap : Form
    {
        public FormToaDoHinhThap()
        {
            InitializeComponent();
        }
        int d, r, c, x, y, z;

        
        public int getD()
        {
            return d;
        }

        public int getR()
        {
            return r;
        }

        public int getC()
        {
            return c;
        }
        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public int getZ()
        {
            return z;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            d = Int32.Parse(dd.Text);
            r = Int32.Parse(dr.Text);
            c = Int32.Parse(dc.Text);
            x = Int32.Parse(dx.Text);
            y = Int32.Parse(dy.Text);
            z = Int32.Parse(dz.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
