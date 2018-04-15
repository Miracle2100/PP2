using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double a, b,c,g,e;
        double s;
        int method;
        bool znak;
        bool case1 = true, case2 = true, case3 = true, case4 = true, case5 = true, case6 = true, case7 = true, t = true;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }
        private double factorial(double n)
        {

            if (n == 0)
                return 1;
            else return n * factorial(n - 1);
        }
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {


            if (double.Parse(textBox1.Text) != 0 && t)
            {


                case1 = true;
                a = double.Parse(textBox1.Text);
                g = a;
                textBox1.Clear();
                method = 2;
                label1.Text = a.ToString() + "-";
                znak = true;
                textBox1.Text = "0";
                t = false;

            }
            else if (double.Parse(textBox1.Text) != 0 && !t)
            {
                a -= double.Parse(textBox1.Text);
                label1.Text = a.ToString() + "-";
                textBox1.Text = "0";

            }

            else if (textBox1.Text == "0")
            {

                method = 1;
                label1.Text = a.ToString() + "-";
                znak = true;
                t = true;


            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) > 0)
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                method = 3;
                label1.Text = a.ToString() + "/";
                znak = true;
                textBox1.Text = "0";
            }
            else
            {
                method = 3;
                label1.Text = a.ToString() + "/";
                znak = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) > 0)
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                method = 4;
                label1.Text = a.ToString() + "*";
                znak = true;
                textBox1.Text = "0";
            }
            else
            {
                method = 4;
                label1.Text = a.ToString() + "*";
                znak = true;

            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {


                if (double.Parse(textBox1.Text) != 0)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    method = 1;
                    label1.Text = a.ToString() + "+";
                    znak = true;
                    textBox1.Text = "0";
                }
                else
                {
                    method = 5;
                    label1.Text = a.ToString() + "+";
                    znak = true;
                }


            
        }

            private void button16_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            textBox1.Text = "0";
            label1.Text = "";
            case1 = true;
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) != 0)
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                method = 2;
                label1.Text = a.ToString() + "-";
                znak = true;
                textBox1.Text = "0";
            }
            else
            {
                method = 5;
                label1.Text = a.ToString() + "-";
                znak = true;
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {  if ( !textBox1.Text.Contains(','))
              textBox1.Text +=  "," ;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = factorial(double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text) * double.Parse(textBox1.Text);

            textBox1.Text = a.ToString();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text)!= 0)
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                method = 5;
                label1.Text = a.ToString() + "^y";
                znak = true;
                textBox1.Text = "0";
            }
            else
            {
                method = 5;
                label1.Text = a.ToString() + "^y";
                znak = true;
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {

            if (double.Parse(textBox1.Text)!= 0)
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                method = 6;
                label1.Text = a.ToString() + "^(1/y)";
                znak = true;
                textBox1.Text = "0";
            }
            else
            {
                method = 6;
                label1.Text = a.ToString() + "^(1/y)";
                znak = true;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = Math.Log10(double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            a = Math.Log(double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            a = Math.Pow(10,double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            a = Math.Sqrt(double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            a = Math.Exp(double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
           
            s += double.Parse(textBox1.Text);

        }

        private void button31_Click(object sender, EventArgs e)
        {
           
            s -= double.Parse(textBox1.Text);

        }

        private void button32_Click(object sender, EventArgs e)
        {
           textBox1.Text = s.ToString();

        }

        private void numbers(object sender, EventArgs e)
        {    Button btn = sender as Button;
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += double.Parse(btn.Text);
            znak = true;

        }

        private void button33_Click(object sender, EventArgs e)
        {
            s = 0;
            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            s = double.Parse(textBox1.Text);

        }

        private void button35_Click(object sender, EventArgs e)
        {   if (radioButton1.Checked)
            {
                a = Math.Sin(Math.PI * double.Parse(textBox1.Text) / 180);
                textBox1.Text = a.ToString();
            }
            else if (radioButton2.Checked)
            {
                a = Math.Sin(double.Parse(textBox1.Text));
                textBox1.Text = a.ToString();
            }
            else textBox1.Text = "";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a = Math.Cos(Math.PI * double.Parse(textBox1.Text) / 180);
                textBox1.Text = a.ToString();
            }
            else if (radioButton2.Checked)
            {
                a = Math.Cos(double.Parse(textBox1.Text));
                textBox1.Text = a.ToString();
            }
            
            else textBox1.Text = "";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a = Math.Tan(Math.PI * double.Parse(textBox1.Text)/ 180);
                textBox1.Text = a.ToString();
            }
            else if( radioButton2.Checked)
            {
                a = Math.Tan(double.Parse(textBox1.Text));
                textBox1.Text = a.ToString();
            }
            else textBox1.Text = "";
        }

        private void button34_Click(object sender, EventArgs e)
        {if (double.Parse(textBox1.Text) > 0)
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                method = 7;
                label1.Text = a.ToString() + "%";
                znak = true;
            }
        else
            {
                method = 7;
                label1.Text = a.ToString() + "%";
                znak = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculate()
        {

            switch(method)
            {


                case 1:
                    if (case1)
                    {
                        
                        g =  a + double.Parse(textBox1.Text);
                        c = double.Parse(textBox1.Text);
                        textBox1.Text = g.ToString();
                        case1 = false;
                    }


                    else if (!case1)
                    {
                        b = double.Parse(textBox1.Text) + c;
                        textBox1.Text = b.ToString();
                    }
                    case3 = true;
                    case1 = false;
                    case2 = true;
                    case4 = true;
                    case5 = true;
                    case6 = true;
                    case7 = true;

                    break;
                case 2:
                    if (case2)
                    {

                        g = a - double.Parse(textBox1.Text);
                        c = double.Parse(textBox1.Text);
                        textBox1.Text = g.ToString();
                        case1 = false;
                    }


                    else if (!case2)
                    {
                        b = double.Parse(textBox1.Text) - c;
                        textBox1.Text = b.ToString();
                    }
                    case3 = true;
                    case1 = true;
                    case2 = false;
                    case4 = true;
                    case5 = true;
                    case6 = true;
                    case7 = true;
                    break;
                case 3:
                    if (case3)
                    {
                        b = a / double.Parse(textBox1.Text);
                        c = double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();

                    }
                     else if (!case3)
                    {
                        b = double.Parse(textBox1.Text) / c;
                        textBox1.Text = b.ToString();
                    }
                    case3 = false;
                    case1 = true;
                    case2 = true;
                    case4 = true;
                    case5 = true;
                    case6 = true;
                    case7 = true;
                    break;
                case 4:
                    if (case4)
                    {
                        b = a * double.Parse(textBox1.Text);
                        c = double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();

                    }
                        else if (!case4)
                    {
                        b = double.Parse(textBox1.Text) * c;
                        textBox1.Text = b.ToString();
                    }
                    case4 = false;
                    case3 = true;
                    case1 = true;
                    case2 = true;
                    case5 = true;
                    case6 = true;
                    case7 = true;
                    break;
                case 5:
                   
                    if (case5)
                    {
                        b = Math.Pow(a, double.Parse(textBox1.Text));
                        c = double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();

                    }

                    else if (!case5)
                    {
                        b = Math.Pow(double.Parse(textBox1.Text), c);
                        textBox1.Text = b.ToString();
                    }
                    case5 = false;
                    case4 = true;
                    case3 = true;
                    case1 = true;
                    case2 = true;
                    case6 = true;
                    case7 = true;

                    break;
                case 6:
                   
                    if (case6)
                    {
                        b = Math.Pow(a, 1 / double.Parse(textBox1.Text));
                        c = double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();

                    }

                    else if (!case6)
                    {
                        b = Math.Pow(double.Parse(textBox1.Text), 1 / c);
                       
                        textBox1.Text = b.ToString();
                    }
                    case6 = false;
                    case5 = true;
                    case4 = true;
                    case3 = true;
                    case1 = true;
                    case2 = true;
                    case7 = true;

                    break;
                case 7:
                    b = a % double.Parse(textBox1.Text);
                    c = double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    if (case7)
                    {
                        b = a % double.Parse(textBox1.Text);
                        c = double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();

                    }

                    else if (!case7)
                    {
                        b = double.Parse(textBox1.Text) % c;
                        textBox1.Text = b.ToString();
                    }
                    case7 = false;
                    case6 = true;
                    case5 = true;
                    case4 = true;
                    case3 = true;
                    case1 = true;
                    case2 = true;
                    break;
                default:
                break;
        }

         }

          

        
        
    }
}
