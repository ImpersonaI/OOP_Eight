using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Eight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int temp = 0, znak = 1;
        double z1 = 0, x = 0;
        double z2 = 0, R = 0;

        public static long Fact(long n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            R = Convert.ToDouble(textBox3.Text);
            temp = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= temp; i++)

                for (int j = 1; j <= R; j++)
                {

                    z2 += (i + 1) * (i + 1) / (Math.Pow(i, 3) + Math.Pow(j, 3));
                }
                
           
            
            label1.Text = z2.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            x = Convert.ToDouble(textBox2.Text);
            temp = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < temp; i++)
            {

                z1 += i * x / Fact(i+1)*znak;
                znak *= -1;
            }

            label1.Text = z1.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
