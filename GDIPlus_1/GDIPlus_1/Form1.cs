
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
                Rectangle destrect = new Rectangle(0, 0, bmp.Width, bmp.Height) ;
                Brush myBrush = new SolidBrush(Color.Coral);
            g.DrawImage(bmp, destrect);
            g.DrawString("Hello World",
                new Font("Verdana", 30, FontStyle.Bold),//Font,size,style
                myBrush,
                0, // x position to display font
                0); // y position to display font
            

            g.Dispose();
            
            }


        }


    }

