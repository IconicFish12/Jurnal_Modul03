using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurnal_Modul03
{
    public partial class Form1 : Form
    {
        int num;
        int total;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            num = num * 10 + 1;
            textBox1.Text = num.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            num = num * 10 + 2;
            textBox1.Text = num.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            num = num * 10 + 3;
            textBox1.Text = num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            num = num * 10 + 4;
            textBox1.Text = num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            num = num * 10 + 5;
            textBox1.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            num = num * 10 + 6;
            textBox1.Text = num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            num = num * 10 + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            num = num * 10 + 8;
            textBox1.Text = num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox1.Text = num.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            num = num * 10 ;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            total = num;
            textBox1.Text = "";
            num = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            total = total + num;
            num = 0;
            textBox1.Text = total.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num = 0;
            total = 0;
        }

    }
}
