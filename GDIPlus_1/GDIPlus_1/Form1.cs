
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
               Rectangle destrect = new Rectangle(10, 10, bmp.Width / 2, bmp.Height / 2);
               Rectangle srcrect = new Rectangle(10, 10, bmp.Width, bmp.Height);


                this.SetClientSizeCore(bmp.Width + 20, bmp.Height + 20);
                g.DrawImage(bmp, 10, 10);
                g.Dispose();

            }


        }


    }

