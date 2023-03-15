using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            int antal = textBox3.TextLength+1;
            label4.Text = antal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox5.Text);
            int num2 = int.Parse(textBox6.Text);
            int res = num1 + num2;
            textBox7.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox5.Text);
            int num2 = int.Parse(textBox6.Text);
            int res = num1 - num2;
            textBox7.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox5.Text);
            int num2 = int.Parse(textBox6.Text);
            int res = num1 * num2;
            textBox7.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox5.Text);
            int num2 = int.Parse(textBox6.Text);
            int res = num1 / num2;
            textBox7.Text = res.ToString();
        }
    }
}
