﻿using System;
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
            Pen Blackpen = new Pen(Color.Black, 3);

            Point point1 = new Point(100, 100);
            Point point2 = new Point(200, 200);

            e.Graphics.DrawLine(Blackpen, point1, point2);
            Blackpen.Dispose(); 



        }
    }

    internal class Hatchstyle
    {
        public static HatchStyle DrakVertical { get; internal set; }
    }
}
