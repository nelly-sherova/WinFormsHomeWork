using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float a;
        double b;
        double resoult = 0;
        int count;
        bool znak = true;
        float history = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    textBox1.Text = Convert.ToString(resoult);
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = 1 / a;
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = a * a;
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = Math.Sqrt(a);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            resoult += a;
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void equally_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void choiceOfSign_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            history += Convert.ToSingle(textBox1.Text);
            textBox1.Text = "";

        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(history);
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            history -= Convert.ToSingle(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(history);
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            history = 0;
            textBox1.Text = "";
        }

        private void oneDeVByX_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = $"1 / {a}";
            znak = true;
        }

        private void buttonSqr_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            label1.Text = $"{a}^2";
            znak = true;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 7;
            label1.Text = $"{a}^(1/2)";
            znak = true;
        }

        private void point_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
