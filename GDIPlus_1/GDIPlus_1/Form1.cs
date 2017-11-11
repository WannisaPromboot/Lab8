using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //draw
            Rectangle rect = new Rectangle(10, 10, 100, 100);
            g.DrawEllipse (Pens.Purple, rect);
            //fill
            Rectangle rect1 = new Rectangle(10, 120, 100, 100);
            g.DrawEllipse(Brushes.DeepPink ,rect);
            //draw
            Rectangle rect2 = new Rectangle(150, 10, 120, 100);
            g.DrawEllipse(Pens.DarkSlateBlue , rect2);
            //fill
            Rectangle rect3 = new Rectangle(150, 120, 120, 100);
            g.DrawEllipse(Brushes.Firebrick , rect3);

            g.Dispose();




        }
    }

    internal class Hatchstyle
    {
        public static HatchStyle DrakVertical { get; internal set; }
    }
}
