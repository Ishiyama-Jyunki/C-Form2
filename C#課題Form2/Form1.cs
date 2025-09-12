using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_課題Form2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                label1.Text = "からっぽ";
                label1.ForeColor = Color.Yellow;
            }
            else
            {
                CheckInput(inputText);
            }
        }

        private void CheckInput(string input)
        {
            bool hasYama = input.Contains("山");
            bool hasUmi = input.Contains("海");

            if (hasYama && hasUmi)
            {
                label1.Text = "どちらも含まれている。";
                label1.ForeColor = Color.Red;
            }
            else if (hasYama)
            {
                label1.Text = "山が含まれている。";
                label1.ForeColor = Color.Green;
            }
            else if (hasUmi)
            {
                label1.Text = "海が含まれている。";
                label1.ForeColor = Color.Blue;
            }
            else
            {
                label1.Text = "どちらも含まれていない。";
                label1.ForeColor = Color.Black;
            }
        }
    }
}
