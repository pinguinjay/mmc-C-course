using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_110910020
{
    public partial class Form1 : Form
    {
        double bmi;
        string WarnMessage;

        private void heightBox_Enter(object sender, EventArgs e)
        {
            if(heightBox.Text == "請輸入您的身高")
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

        private void cleanup_botton_Click(object sender, EventArgs e)
        {
            heightBox.Text = "請輸入您的身高";
            heightBox.ForeColor = Color.Silver;
            weightBox.Text = "請輸入您的體重";
            weightBox.ForeColor = Color.Silver;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmi = (double.Parse(weightBox.Text))/ (Math.Pow((double.Parse(heightBox.Text)/100), 2));
            if(bmi < 18.5) { WarnMessage = "「體重過輕」，需多運動、均衡飲食增加體能"; }
            else if(18.5 <= bmi && bmi < 24) { WarnMessage = "恭喜！「健康體重」，請繼續保持"; }
            else if (24 <= bmi && bmi < 27) { WarnMessage = "「體重過重」囉，要小心開始管理體重了"; }
            else if (27 <= bmi && bmi < 30) { WarnMessage = "「輕度肥胖」！要開始運動了"; }
            else if (30 <= bmi && bmi < 35) { WarnMessage = "「中度肥胖」再不減重會有健康上的危險"; }
            else { WarnMessage = "「重度肥胖」，請競速就醫或者努力運動"; }
            MessageBox.Show("您的BMI值為"+ bmi.ToString()+"\n且"+WarnMessage,"BMI計算結果", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
