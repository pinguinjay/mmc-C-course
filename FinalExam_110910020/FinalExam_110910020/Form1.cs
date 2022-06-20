using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam_110910020
{
    public partial class Form1 : Form
    {
        string[] OuterEar = {"耳輪","對耳輪","耳膜","外耳道","耳珠" };
        string[] OuterEarDescription = {
            "外耳頂部周圍的彎曲邊緣",
            "與耳輪相對，上部有分叉的隆起部分",
            "耳膜也稱鼓膜，為一彈性灰白色半透明薄膜，將外耳道與中耳隔開",
            "外耳道是自耳甲腔深處的外耳門向內側延伸到鼓膜的彎曲管道，可把耳郭收集的聲波傳導至鼓膜，有阻止異物進入外耳道侵害鼓膜的作用",
            "耳珠為耳朵最下面的部分，沒特別作用，傳統上認為越大越有福氣"
        };
        string[] MiddleEar = { "鼓張肌", "錘骨", "砧骨", "鐙骨", "耳道","鼓膜", "鐙骨肌" ,"鼓室","耳咽管","內耳迷路"};
        string[] MiddleEarDescription = {
            "鼓張肌是中耳內的一塊肌肉，位於聽管骨部分上方的骨管中，並連接到錘骨",
            "是人耳中錘狀的小骨，是三塊聽小骨（ossicles）中的一個，連接耳膜和砧骨",
            "砧骨（耳內三小骨之一，將聲音從耳膜傳至內耳）",
            "人類和其他動物的中耳骨骼，參與將聲音振動傳導至內耳",
            "耳道可把耳郭收集的聲波傳導至鼓膜，有阻止異物進入外耳道侵害鼓膜的作用",
            "又稱耳膜（eardrum），是分割外耳和中耳的薄膜，將耳道和鼓室隔開[1][2][3]。鼓膜是耳的重要組成部分，它獲取空氣中的聲音，並將之傳遞給中耳中的聽小骨",
            "維持卵圓窗張力限制卵圓窗過度震動",
            "是位於中耳內的一個空心小腔室，由骨質結構包圍。鼓室位於鼓膜後，內部有三塊聽小骨",
            "耳咽管或稱聽管、咽鼓管、歐氏管（英語：Eustachian tube、E－tube或 auditory tube），是連接咽喉和中耳的管道",
            "分為骨迷路和膜迷路。骨迷路內含有液體，外淋巴存在於骨迷路和膜迷路之間、起保護作用，而內淋巴存在於膜迷路內"
        };
        string[] innerEar = { "上半規管", "後半規管", "側半規管", "前庭", "耳蝸","橢圓囊","球狀囊" };
        string[] innerEarDescription = {
            "上半規管或前半規管是前庭系統的一部分，可檢測頭部圍繞側軸的旋轉，即在矢狀面上的旋轉。 例如，在點頭時會發生這種情況。",
            "後半規管是前庭系統的一部分，它檢測頭部圍繞前後（矢狀）軸的旋轉，或者換句話說，在冠狀平面上的旋轉。 例如，當一個人移動頭部以接觸肩膀時，或者在做側手翻時，就會發生這種情況。",
            "側半規管是三個管中最短的。 該管內的流體運動對應於頭部圍繞垂直軸的旋轉",
            "是內耳骨迷路的一部分，位於半規管和耳蝸之間，與半規管共同構成前庭系統。前庭內含有球囊（saccule）、橢圓囊（utricle），屬於平衡覺感受器，能感知直線加速運動",
            "耳蝸的核心部分為柯蒂氏器，是聽覺傳導器官，負責將來自中耳的聲音信號轉換為相應的神經電信號，交送腦的中樞聽覺系統接受進一步處理，最終實現聽覺",
            "橢圓囊包含稱為毛細胞的機械感受器，可以區分頭部傾斜的程度，這要歸功於它們的頂端靜纖毛設置。 這些被耳石覆蓋，由於重力，耳石會拉動靜纖毛並使其傾斜。",
            "球囊是內耳中的感覺細胞床。 它將頭部運動轉化為神經衝動，供大腦解釋。",
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_outerEar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Image = imageList1.Images[0];
            for (int i = 0; i <= OuterEar.GetUpperBound(0); i++)
            {
                listBox1.Items.Add(OuterEar[i]);
            }
        }

        private void radioButton_middleear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Image = imageList1.Images[1];
            for (int i = 0; i <= MiddleEar.GetUpperBound(0); i++)
            {
                listBox1.Items.Add(MiddleEar[i]);
            }
        }

        private void radioButton_innerEar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Image = imageList1.Images[2];
            for (int i = 0; i <= innerEar.GetUpperBound(0); i++)
            {
                listBox1.Items.Add(innerEar[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton_outerEar.Checked == true)
            {
                textBox1.Text = OuterEarDescription[listBox1.SelectedIndex];
            }
            else if(radioButton_middleear.Checked == true)
            {
                textBox1.Text = MiddleEarDescription[listBox1.SelectedIndex];
            }
            else
            {
                textBox1.Text = innerEarDescription[listBox1.SelectedIndex];
            }
        }
    }
}
