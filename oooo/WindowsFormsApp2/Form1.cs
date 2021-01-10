using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string c;
        double x;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + b.Text;

               
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

         
        private void button17_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "" + c;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch  (c)
            { 
                case "+":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x + y).ToString();
                        label1.Text = "";

                    }
                    break;
                case "-":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x - y).ToString();
                        label1.Text = "";

                    }
                    break;
                case "*":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x * y).ToString();
                        label1.Text = "";

                    }
                    break;

                case "/":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x / y).ToString();
                        label1.Text = "";

                    }
                    break;
            }
        }
    }
}
