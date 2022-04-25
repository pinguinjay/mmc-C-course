using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardWeightSwitch110910020
{
    public partial class Form1 : Form
    {
        double standardweight, standardweightrangeMax, standardweightrangeMin, overweight;
        public Form1()
        {
            InitializeComponent();
        }

        private void heightBox_Enter(object sender, EventArgs e)
        {
            if (heightBox.Text == "請輸入您的身高")
            {
                heightBox.Text = "";
                heightBox.ForeColor = Color.Black;
            }
        }

        private void heightBox_Leave(object sender, EventArgs e)
        {
            if (heightBox.Text == "")
            {
                heightBox.Text = "請輸入您的身高";
                heightBox.ForeColor = Color.Silver;
            }
        }

        private void weightBox_Enter(object sender, EventArgs e)
        {
            if (weightBox.Text == "請輸入您的體重")
            {
                weightBox.Text = "";
                weightBox.ForeColor = Color.Black;
            }
        }

        private void weightBox_Leave(object sender, EventArgs e)
        {
            if (weightBox.Text == "")
            {
                weightBox.Text = "請輸入您的體重";
                weightBox.ForeColor = Color.Silver;
            }
        }

        private void button_diagnose_Click(object sender, EventArgs e)
        {
            if(comboBox_gender.SelectedIndex == 0)
            {               
                standardweight = (double.Parse(heightBox.Text) - 70) * 60 / 100;
                idealW.Text = standardweight.ToString();
                standardweightrangeMax = standardweight * 1.1;
                standardweightrangeMin = standardweight * 0.9;
                idealWRange.Text = standardweightrangeMin.ToString() + "~" + standardweightrangeMax.ToString();
            }
            else
            {
                standardweight = (double.Parse(heightBox.Text) - 80) * 70 / 100;
                idealW.Text = standardweight.ToString();
                standardweightrangeMax = standardweight * 1.1;
                standardweightrangeMin = standardweight * 0.9;
                idealWRange.Text=standardweightrangeMin.ToString()+"~"+standardweightrangeMax.ToString();
            }
            overweight = (double.Parse(weightBox.Text) - standardweight) / standardweight;
            switch ((int)(overweight * 10))
            {
                case 2:
                    MessageBox.Show("您的體重肥胖", "您的體重與理想體重差距：" + (overweight * 100).ToString("F2") + "%");
                    break;
                case 1:
                    MessageBox.Show("您的體重過重", "您的體重與理想體重差距：" + (overweight * 100).ToString("F2") + "%");
                    break;
                case 0:
                    MessageBox.Show("您的體重正常", "您的體重與理想體重差距：" + (overweight * 100).ToString("F2") + "%");
                    break;
                case -1:
                    MessageBox.Show("您的體重過輕", "您的體重與理想體重差距：" + (overweight * 100).ToString("F2") + "%");
                    break;
                case -2:
                    MessageBox.Show("您的體重瘦弱", "您的體重與理想體重差距：" + (overweight * 100).ToString("F2") + "%");
                    break;
                default:
                    MessageBox.Show("您的體重太誇張了", "您的體重與理想體重差距：" + (overweight * 100).ToString("F2") + "%");
                    break ;

            }
        }
    }
}
