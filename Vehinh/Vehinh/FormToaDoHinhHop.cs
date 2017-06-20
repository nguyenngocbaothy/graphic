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
    public partial class FormToaDoHinhHop : Form
    {
        public FormToaDoHinhHop()
        {
            InitializeComponent();
        }
        int x, y, z, d, r, c;
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
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(dx.Text);
            y = Int32.Parse(dy.Text);
            z = Int32.Parse(dz.Text);
            d = Int32.Parse(dd.Text);
            r = Int32.Parse(dr.Text);
            c = Int32.Parse(dc.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
