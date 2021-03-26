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
       
        public Form1()
        {
            InitializeComponent();
        }

        double a, b , resultPlusMin = 0, resultProDev = 1;
        double history = 0;
        double r = 1;
        char znak;
        double numLabel;
        private void Calculate()
        {
            switch(znak)
            {
                case '+':
      
                    b = Convert.ToDouble(textBox1.Text);

                    textBox1.Text = Convert.ToString(resultPlusMin + b);
                break;
                case '-':
                    b = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(resultPlusMin - b);
                break;
                case '*':
                    b = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(resultProDev * b);
                break;
                case '/':
                    b = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(resultProDev / b);
                break;
                case '^':
                    b = a * a;
                    textBox1.Text = b.ToString();
                break;
                case '@':
                    b = Math.Sqrt(a);
                    textBox1.Text = b.ToString();
                break;
                case '1':
                    b = 1 / a;
                    textBox1.Text = b.ToString();
                break;
                case '%':
                    textBox1.Text = b.ToString();
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
            a = Convert.ToDouble(textBox1.Text);
            resultPlusMin += a;
            label1.Text = Convert.ToString(resultPlusMin) + "+";
            numLabel = resultPlusMin;
            textBox1.Text = "";
            znak = '+';
        }

        private void minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            if (resultPlusMin == 0)
            {
                resultPlusMin = resultPlusMin + a;
            }
            else
            {
                resultPlusMin -= a;
            }
            label1.Text = Convert.ToString(resultPlusMin) + "-";
            numLabel = resultPlusMin;
            textBox1.Text = "";
            znak = '-';
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            resultProDev *= a;
            label1.Text = Convert.ToString(resultProDev) + "*";
            numLabel = resultProDev;
            textBox1.Text = "";
            znak = '*';
        }

        private void divide_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            if (r == 1)
            {
                resultProDev = a;
                r = 2;
            }

            else
            {
                if (a != 0)
                    resultProDev /= a;
            }
                
            numLabel = resultProDev;
            label1.Text = Convert.ToString(resultProDev) + "/";
            textBox1.Text = "";
            znak = '/';
        }

        private void equally_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = "";
            resultPlusMin = Convert.ToDouble(textBox1.Text);
            resultProDev = Convert.ToDouble(textBox1.Text);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
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
            a = Convert.ToDouble(textBox1.Text);
            a = -1 * a;
            textBox1.Text = Convert.ToString(a);
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            history = history + Convert.ToDouble(textBox1.Text);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(history);
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            history = history - Convert.ToDouble(textBox1.Text);
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            history = Convert.ToDouble(textBox1.Text);
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            history = 0;
        }

        private void oneDeVByX_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            label1.Text = $"1 / {a}";
            znak = '1';
        }

        private void buttonSqr_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            label1.Text = $"{a}^2";
            znak = '^';
        }

        private void percent_Click(object sender, EventArgs e)
        {
            
            if (label1.Text == "")
            {
                a = Convert.ToDouble(textBox1.Text);
                b = a / 100;
                znak = '%';
                textBox1.Text = Convert.ToString(a);
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                b = a * (numLabel / 100);
                
                textBox1.Text = Convert.ToString(a);
                
            }
            textBox1.Text = textBox1.Text;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            label1.Text = $"{a}^(1/2)";
            znak = '@';
        }

        private void point_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            r = 1;
            resultProDev = 1;
            resultPlusMin = 0;
        }
    }
}
