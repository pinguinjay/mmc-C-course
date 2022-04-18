using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systolic_110910020
{
    public partial class Form1 : Form
    {
        int systolic;
        public Form1()
        {
            InitializeComponent();
        }

        private void sys_require_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(systolic_enter.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入整數");
                return;
            }            
            systolic = int.Parse(systolic_enter.Text);
            if (systolic <120 )
            {
                MessageBox.Show("您的血壓很理想，請繼續保持","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (systolic < 130)
            {
                MessageBox.Show("您的血壓是正常的", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (systolic < 140)
            {
                MessageBox.Show("您的血壓正常但偏高，要注意健康少攝取納", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (systolic < 160)
            {
                MessageBox.Show("您為高血壓第一期 \n 建議您就醫檢查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (systolic < 180)
            {
                MessageBox.Show("您為高血壓第二期 \n 建議您就醫檢查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else 
            { 
                MessageBox.Show("您為高血壓第三期 \n 建議您就醫檢查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
    }
}
