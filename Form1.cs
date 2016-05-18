using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trapez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double answer;
        private void button1_Click(object sender, EventArgs e)
        {
            int oper = 0, num = 0, pow = 0, s = 0, m = 0;
            int n = Convert.ToInt32(textBox2.Text);
            int f1 = Convert.ToInt32(textBox3.Text);
            int f2 = Convert.ToInt32(textBox4.Text);
            double h = ((f2 - 1) / n);

            double answer1 = 0;
            double answer2 = 0;
            string equ = textBox1.Text;
            char[] chararray = equ.ToCharArray();
            string[] sign = new string[9];
            string[] numbers = new string[9];
            string[] powers = new string[9];
            for(int xx=0;xx<chararray.Length;xx++)
            {
                if(chararray[xx]=='+' || chararray[xx]=='-' || chararray[xx]=='/' || chararray[xx] == '*')
                {
                    sign[oper] = chararray[xx].ToString();
                    oper++;
                    try
                    {
                        numbers[num] = chararray[xx + 2].ToString();

                    }
                    catch (Exception ex)
                    {
                        numbers[num] = chararray[xx + 1].ToString();
                        powers[pow] = '0'.ToString();

                    }
                }
                if(chararray[xx]=='^')
                    {
                    powers[pow] = chararray[xx + 1].ToString();
                    pow++;
                }
                if(chararray[xx]=='x')
                {
                    numbers[num] = chararray[xx - 1].ToString();
                    num++;
                }
            }
            for(int x=0;x<numbers.Length;x++)
            {
                int m1 = Convert.ToInt32(numbers[x]);
                int m2 = Convert.ToInt32(powers[x]);
                answer1 = answer1 + (m1 * Math.Pow(f1, m2)) + (m1 * Math.Pow(f2, m2));

            }
            double b = (f2 - f1);
            double cc = b / n;
            double y = f1 + cc;
            while(y<(f2))
            {
                while(s<numbers.Length)
                {
                    int m11 = Convert.ToInt32(numbers[s]);
                    int m22 = Convert.ToInt32(powers[s]);
                    answer2 = answer2 + (m11 * Math.Pow(y, m22));
                    s++;
                }
                s = 0;
                y = y + cc;
                m++;
            }
            double c = b / (n * 2);
            answer = (c * (answer1 + (answer2 * 2)));

            textBox5.Text = (answer).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
