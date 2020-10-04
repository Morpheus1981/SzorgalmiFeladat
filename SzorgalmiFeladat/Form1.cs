using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzorgalmiFeladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {


            double num1, res;
            num1 = Convert.ToDouble(textBox1.Text);
            res = 4 * num1;
            textBox4.Text = Convert.ToString(res);
            MessageBox.Show("A négyzet kerülete: (4 * a) = " + res.ToString());

            textBox3.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double num1, num2, res;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            res = 2 * (num1 + num2);
            textBox4.Text = Convert.ToString(res);
            MessageBox.Show("A téglalap kerülete: 2*(a + b) = " + res.ToString());



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num3, res;
            num3 = Convert.ToDouble(textBox3.Text);

            res = 2 * num3 * Math.PI;
            textBox4.Text = Convert.ToString(res);
            MessageBox.Show("A kör kerülete: (2 * r * pi ) = " + res.ToString());

        }

        private void r(object sender, MouseEventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Enabled = true;

            textBox2.Clear();
            textBox3.Clear();
        }

        private void t(object sender, MouseEventArgs e)
        {
            textBox3.Enabled = false;
            textBox2.Enabled = true;
            textBox1.Enabled = true;

            textBox3.Clear();
        }

        private void z(object sender, MouseEventArgs e)
        {
        
            textBox3.Enabled = true;
            textBox2.Enabled = false;
            textBox1.Enabled = false;

            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


                
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double num1, res;

            num1 = Convert.ToDouble(textBox1.Text);

            res = num1 * num1;
            textBox4.Text = Convert.ToString(res);
            MessageBox.Show("A négyzet területe: (a * a) = " + res.ToString());



            textBox2.Enabled = true;
            textBox3.Enabled = true;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num1, num2, res;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            

            res = num1 * num2;
            textBox4.Text = Convert.ToString(res);
            MessageBox.Show("A téglalap területe: (a * b) = " + res.ToString());


        }

        private void e(object sender, MouseEventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Enabled = true;

            textBox2.Clear();
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num3, res;
            num3 = Convert.ToDouble(textBox3.Text);

            res = (num3 * num3) * Math.PI;
            textBox4.Text = Convert.ToString(res);
            MessageBox.Show("A kör területe: ((r * r) * pi ) = " + res.ToString());

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double res;

        }
    }
}
