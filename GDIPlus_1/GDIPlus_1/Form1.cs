
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
                Bitmap bmp = new Bitmap("E:\\BGP.PNG");
                this.SetClientSizeCore(bmp.Width, bmp.Height);
                Rectangle topleft = new Rectangle(0, 0, bmp.Width /2, bmp.Height/2) ;
                Rectangle topRight = new Rectangle(bmp.Width/2, 0, bmp.Width/2, bmp.Height/2);
                Rectangle bottomleft = new Rectangle(0, bmp.Height / 2, bmp.Width, bmp.Height/2);
                Rectangle bottomRight = new Rectangle(bmp.Width/2, bmp.Height / 2, bmp.Width/2, bmp.Height/2);


                bmp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                e.Graphics.DrawImage(bmp, topleft);

            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            e.Graphics.DrawImage(bmp, topRight);

            bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            e.Graphics.DrawImage(bmp, bottomleft);

            bmp.RotateFlip(RotateFlipType.Rotate180FlipY);
            e.Graphics.DrawImage(bmp, bottomRight);

            g.Dispose();
            
            }


        }


    }

