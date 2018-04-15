using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Game
{
    public partial class Form1 : Form
    {
        Brush pobr  = Brushes.White;
        Pen pobrpen = new Pen(Color.White, 4);
        Pen p = new Pen(Color.White, 5);
        Point[] arr = {
              new Point(-100, -75),
            new Point(-80, -80),
             new Point(-75, -100),
            new Point(-70, -80),
             new Point(-50, -75),
             new Point(-70,-70 ),
            new Point(-75, -50),
                new Point(-80, -70)
            };
        Point[] arr1 = {
        new Point ( 200, 225),
        new Point ( 220, 220),
        new Point( 225, 200),
        new Point ( 230, 220),
        new Point( 250, 225),
        new Point ( 230, 230),
        new Point( 225, 250),
        new Point ( 220, 230)};

        Graphics[] poly = new Graphics[10];
        PictureBox pb, pbflame;
        PictureBox[] asteroid = new PictureBox[10];
        Bitmap btm1 = new Bitmap("spaceship.png");
        Bitmap[] btmasteroid = new Bitmap[10];
 
     
        Random rnd = new Random();
        Label[] labelArray = new Label[10];
        int[] dx = new int[] { 2, 3, 3, 2, 2 ,3,2,1,2,3}, dy = new int[] { 2, 3, 2, 3, 3 ,3,2,2,2,2};
        Rectangle image1;
        Rectangle image2;
       
        Pen pen = new Pen(Color.White, 7);
        double dyy = 8, dxx = 8;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            poly[0] = CreateGraphics();
            poly[0].ScaleTransform( .2F, .2F);
            poly[0].DrawPolygon(pobrpen, arr1);
            poly[0].FillPolygon(pobr, arr1);
        
        }

        public Form1()
             
             
        {
            InitializeComponent();
            
             for (int i = 0; i < 10; i++)
            {
                
                if (i < 5)
                    btmasteroid[i] = new Bitmap("asteroid1.png");
             else if ( i > 5 && i < 8)
                    btmasteroid[i] = new Bitmap("asteroid3.png");
            else btmasteroid[i] = new Bitmap("asteroid2.png");

            }

          
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            BackColor = Color.Black;
            Height = 500;
            Width = 500;
            int horizontal = 0;
            int vertical = 0;
            pb = new PictureBox();
            pb.Width = 70;
            pb.Height = 60;
            pb.Location = new Point(200, 400);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = btm1;
            Controls.Add(pb);
            for( int i = 0; i < 10; i++)
            {
                asteroid[i]= new PictureBox();
                asteroid[i].Width = 48;
                asteroid[i].Height = 55;
                asteroid[i].Image = btmasteroid[i];
                Controls.Add(asteroid[i]);
            }
          

            for (int t = 0; t < 10 ;t++)
            {
                labelArray[t] = new Label();
                labelArray[t].Size = new Size(48,58);
                
                
                labelArray[t].ForeColor = Color.Gray;
                labelArray[t].Location = new Point(horizontal, vertical);
                horizontal += 50;
                
               Controls.Add(labelArray[t]);


            }
            timer1.Start();
           


        }

       
       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            label1.ForeColor = Color.Green;
            label1.Text = pb.Location.X + "; " + pb.Location.Y;
            if (e.KeyCode == Keys.Up)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - (int)dyy);
            }
            if (e.KeyCode == Keys.Down)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y + (int)dyy);
            }
            if (e.KeyCode == Keys.Left)
            {
                pb.Location = new Point(pb.Location.X - (int)dxx, pb.Location.Y);
            }
            if (e.KeyCode == Keys.Right)
            {
                pb.Location = new Point(pb.Location.X + (int)dxx, pb.Location.Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  if (pobr == Brushes.White && pobrpen == Pens.White)
            {
                pobr = Brushes.Black;
                pobrpen = Pens.Black;

            }
            else
            {
                pobr = Brushes.White;
                pobrpen = Pens.White;
            }
            Refresh();
                for ( int i = 0; i < 10;i++)
            {
               
                labelArray[i].Location = new Point(labelArray[i].Location.X + dx[i], labelArray[i].Location.Y + dy[i]);
                asteroid[i].Location = labelArray[i].Location;
                asteroid[i].SizeMode = PictureBoxSizeMode.StretchImage;
                if (labelArray[i].Location.X > Width + 4 || labelArray[i].Location.Y > Height + 4)
                {
                    labelArray[i].Location = new Point(rnd.Next(0, 500), -5);
                    dx[i] = rnd.Next(1, 5);
                    dy[i] = rnd.Next(1, 5);

                    asteroid[i].Location = labelArray[i].Location;
                    asteroid[i].SizeMode = PictureBoxSizeMode.StretchImage;

                }
                for( int j = 0;  j < 10; j++)
                {
                    image1 = new Rectangle(labelArray[i].Location.X, labelArray[i].Location.Y, 48, 55);
                    image2 = new Rectangle(labelArray[j].Location.X, labelArray[j].Location.Y, 48, 55);
                    if (image1.IntersectsWith(image2) && i != j )

                    {
                        dx[i] *= -1;
                        dx[j] *= -1;
                        asteroid[i].Location = labelArray[i].Location;
                        asteroid[i].SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                   
                }
            }



        }








    }
}
