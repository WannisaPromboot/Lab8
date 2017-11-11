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
            Image image = Image.FromFile("E:\\wannamiu.jpg");
            TextureBrush brush = new TextureBrush(image);
            Rectangle rect = new Rectangle(10, 10, 1000, 1000);
            g.FillEllipse(brush, rect);
            g.Dispose();




        }
    }

    
}
