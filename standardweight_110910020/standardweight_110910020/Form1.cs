using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace standardweight_110910020
{
    public partial class Form1 : Form
    {
        int manheight, manweight;
        int womanheight, womanweight;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            womanheight = int.Parse(textBox4.Text);
            womanweight = (womanheight - 70) * 60 / 100;
            textBox3.Text = womanweight.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//男性標準體重按鈕
        {
            manheight =int.Parse(textBox1.Text);
            manweight = (manheight - 80) * 70 / 100;
            textBox2.Text = manweight.ToString();         
        }
    }
}
