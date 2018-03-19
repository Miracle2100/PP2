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
        public Form1()
        {
            InitializeComponent();
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
    }
}
