using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_TPO_Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => a / b;

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                label2.Text = Add(a, b).ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                if (b != 0)
                {
                    label2.Text = Divide(a, b).ToString();
                }
                else
                {
                    MessageBox.Show("Деление на ноль невозможно.");
                }
            }
            else
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                label2.Text = Subtract(a, b).ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                label2.Text = Multiply(a, b).ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
