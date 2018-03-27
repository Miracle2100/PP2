using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        Graphics g;


        public Form1()
        {
            InitializeComponent();
            Height = 500;
            Width = 500;
            g = CreateGraphics();

        }

        private void but(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    button1.Location = new Point(button1.Location.X - 15, button1.Location.Y);
                    break;
                case Keys.W:
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - 15);
                    break;
                case Keys.D:
                    button1.Location = new Point(button1.Location.X + 15, button1.Location.Y);
                    break;
                case Keys.S:
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + 15);
                    break;



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Yellow, 5);
            Rectangle r = new Rectangle(150, 150, 100, 100);
            g.DrawRectangle(p, r);
            p = new Pen(Color.Violet, 7);
            g.DrawEllipse(p, r);
            Point[] arr =
           {
                new Point( 10,10),
            new Point(300, 50),
            new Point(150, 200),
            new Point(30, 200)
            };
            p = new Pen(Color.Pink, 5);
            g.DrawPolygon(p, arr);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Red, 200, 10, 200, 200);
            Point p1 = new Point(10, 10);
            Point p2 = new Point(100, 100);
            e.Graphics.DrawLine(Pens.Blue, p1, p2);
            Bitmap btmp1 = new Bitmap(@"C:\Program Files\1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = btm1;

            Bitmap btm2 = new Bitmap(btm1.Width, btm1.Height);
            Bitmap btm3 = new Bitmap(btm1.Width, btm1.Height);
            Bitmap btm4 = new Bitmap(btm1.Width, btm1.Height);
            Bitmap btm5 = new Bitmap(btm1.Width, btm1.Height);

            for (int i = 0; i < btm1.Width; i++)
            {
                for (int j = 0; j < btm1.Height; j++)
                {
                    Color pix = btm1.GetPixel(i, j);
                    Color newGreen = Color.FromArgb(0, pix.G, 0);
                    Color newRed = Color.FromArgb(pix.R, 0, 0);
                    Color newBlue = Color.FromArgb(0, 0, pix.B);

                    int avg = (pix.R + pix.G + pix.B) / 3;
                    Color grey = Color.FromArgb(avg, avg, avg);

                    btm2.SetPixel(i, j, newGreen);
                    btm3.SetPixel(i, j, newRed);
                    btm4.SetPixel(i, j, newBlue);

                    btm5.SetPixel(i, j, grey);
                }
            }

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = btm2;

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = btm3;

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = btm4;

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = btm5;
        }
    }
}
