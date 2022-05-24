﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkeletonMuscle110910020
{
    public partial class Form1 : Form
    {       
        string[] FrontMuscle = {"胸鎖乳突肌", "胸大肌", "肱二頭肌", "肱肌", "肱橈肌" ,"橈側屈腕肌", "尺側屈腕肌" , "闊筋膜張肌","縫匠肌", "股外側肌","股直肌", "股內側肌" ,
        "前鋸肌","腹直肌","腹外斜肌","恥骨肌","內收長肌","股薄肌","腓骨長肌","脛骨前肌","伸趾長肌"};

        string[] FrontMuscleDescription = {"兩塊位於頸部，使頭部前推或轉動的肌肉",//胸鎖乳突肌
            "將手臂拉向胸部的肌肉，通常稱為胸肌或胸脯",//胸大肌
            "使手臂彎曲的肌肉，連接肩胛骨和前臂的橈骨",//肱二頭肌
            "上臂的一條肌肉，屬於肘關節屈肌，位於肱二頭肌深層", //肱肌
            "人體手臂前端的外側皮下，形狀為長條又呈現扁狀，可以使前手臂彎曲並向上跟上臂靠攏",//肱橈肌
            "腕橫紋上5寸，掌長肌腱與橈側屈肌腱之間。",//橈側屈腕肌
            "尺側腕屈肌系前臂肌前群第一層，起自肱骨內上髁、前臂深筋膜，止於豌豆骨。其功能屈和內收腕；屈肘。受尺神經支配。",//尺側屈腕肌
            "闊筋膜外側特別厚，形成一條扁袋狀結構，叫骼脛束。其位於股部外側面，上端附於骼嵴前部，下端止於脛骨外側踝。而骼脛束上份又分為淺深兩層，之間包住一塊肌，就是闊筋膜張肌。",//闊筋膜張肌
            "縫匠肌是連接腰部前側的帶狀長形肌肉。由於以前的裁縫師父在工作的時候總是盤腿而坐，因此才將這個部位的肌肉命名為縫匠肌。負責將膝蓋舉起、放下與盤腿的動作。",//縫匠肌
            "股外側肌，也稱為股外肌，[需要引證]是股四頭肌最大和最有力的部分，股四頭肌是大腿的肌肉。 它與股四頭肌群的其他肌肉一起，用於伸展膝關節，使小腿向前移動。",//股外側肌
            "當膝蓋伸直時，股直肌是較弱的髖屈肌，因為它已經縮短了，因此患有主動功能不全;該動作將比股直肌吸收更多的骨，大腰大肌，筋膜張肌和其餘的髖屈肌",//股直肌
            "股內側肌，又稱內側廣肌，是大腿股四頭肌的一部分，是為大腿最內側的肌肉，屬於伸肌，位在大腿的內側，延伸到膝蓋部位。",//股內側肌
            "前鋸肌，是將肩胛骨內側向前拉的胸部肌肉。 前鋸肌可將肩胛骨內側向前拉而外翻，「鋸肌」一詞描述此肌成鋸齒形的，也就是參差不齊的。",//前鋸肌
            "當腹直肌收縮時，腹部被往內拉。在腹肌共同作用下，可使軀幹向前或向側面運動，甚至扭曲。",//腹直肌
            "腹外斜肌是使腹部緊束的斜肌，兩塊腹外斜肌從最低的肋骨延伸到身體前面的中線。在這裡，他們連接成薄而堅固的纖維層。",//腹外斜肌
            "恥骨肌為一髖屈肌、髖內轉肌、髖內收肌，由閉孔神經和股神經支配，意味著其能產生髖屈曲和髖內收的動作",//恥骨肌
            "內收長肌起端接近恥骨聯合，終止於股骨粗線（Linea Aspera）。有內收大腿的作用。",//內收長肌
            "股薄肌位於大腿淺層，以腱膜起自恥骨下支。具有內收、內旋髖關節的功能。",//股薄肌
            "位於小腿外側皮下，緊貼腓骨的外側面。此肌收縮，可使足趾屈和外翻。腓骨長肌腱與脛骨前肌腱共同形成一個肌袢，維持足的內、外側足弓及橫弓。",//腓骨長肌
            "脛骨前肌系小腿前群肌之一。此肌可以使足背屈並內翻足心；當足骨固定時與其他肌共同收縮可使小腿前傾",//脛骨前肌
            "幫助除腳拇趾外4根腳指伸展，因為到最遠端趾骨，所以叫長肌",//伸趾長肌
        };
        string[] BackMuscle = { "岡下肌", "背闊肌", "臀中肌", "臀大肌", "腓腸肌", "比目魚肌", "跟腱", "斜方肌","三角肌",
        "小圓肌", "大圓肌","肱三頭肌","橈側伸腕長肌", "尺側伸腕肌","橈側伸腕短肌","大內收肌", "股二頭肌","半腱肌","半膜肌"};

        string[] BackDescription = { "位於岡下窩內，一部分被三角肌和斜方肌復蓋，作用是使肩關節鏇外",//岡下肌
            "將手臂向下和下後拉的背部肌肉" ,//背闊肌
            "髖關節外展，走路時對側肌肉收縮防止軀幹偏斜",//臀中肌
            "臀大肌是人體內最大的肌肉。從事站立行走奔跑和上臺階等動作---實際上凡是伸直或伸展腿部時,都必須要運用這塊肌肉。臀大肌也與其他數塊肌肉一起形成臀部。",//臀大肌
            "腓腸肌是腿部最大的屈肌。當其收縮時，可使足向下彎曲，並輔助膝蓋彎曲。腓腸肌是透過跟腱與足跟相連接。",//腓腸肌
            "踝關節屈曲(往足底面拉)",//比目魚肌
            "跟腱是人體中最粗壯有力的肌腱。由腓腸肌和比目魚肌向下融合而成，連接於跟骨後側。跟腱的主要功能為屈小腿與足跖屈。",//跟腱
            "斜方肌是將頭部和肩部向後拉的背部肌肉。可使頭部抬起和傾斜，並使雙肩抬起或穩定。兩者共同形成一個稱為斜方型的四邊形，其名稱即來自於此。",//斜方肌
            "三角肌俗稱「大頭肌」，圍繞著肩膀連接的肩胛骨、鎖骨及肱骨，肩部和上臂的大多數運動都離不開三角肌，它使肩膀堅固，並使手臂可以作出多方向的運動。",//三角肌
            "小圓肌止點在大結節後側，收縮時可使肱骨外旋、adduction(內收)",//小圓肌
            "大圓肌位於背闊肌上方，有助於肱骨的伸展和內側旋轉",//大圓肌
            "肱三頭肌在上臂後面延伸，可伸直或伸展手臂。如果你盡量伸直手臂，就會感到這條腱繃緊了。",//肱三頭肌
            "橈側腕長伸肌是前臂後羣淺層肌之一。起自肱骨外側髁上嵴下部和外側髁的前面，向下止於第2掌骨底的背面。其功能為伸腕",//橈側伸腕長肌
            "尺側腕伸肌為前臂後群肌淺層伸肌之一，為一長梭形肌此肌收縮可伸腕，",//尺側伸腕肌
            "橈側腕短伸肌系前臂後羣淺層肌之一。外側有橈側腕長伸肌，內側有指總伸肌。其功能為伸腕，受橈神經支配。",//橈側伸腕短肌
            "大內收肌是一塊大的三角形肌肉，位於大腿內側。主要作用為內收大腿以及在末端有孔洞提供血管和神經通過",//大內收肌
            "股二頭肌交叉在膝關節附近的肌腱群，主要負責控制膝蓋彎曲與大腿伸展的動作。",//股二頭肌
            "半腱肌的功能為屈曲膝關節和伸直髖關節",//半腱肌
            "半膜肌位於大腿後側、半腱肌的深面，以扁薄的腱膜起自於坐骨結節，終止於脛骨內側髁後面，主要作用是伸髖關節，屈膝關節並微旋內",//半膜肌
        };

        public Form1()
        {
            InitializeComponent();
            //預設為正面
            radioButton_BodyFront.Checked = true;
            pictureBox1.Image = imageList1.Images[0];
            for (int i = 0; i <= FrontMuscle.GetUpperBound(0); i++)
            {
                listBox_muscle.Items.Add(FrontMuscle[i]);
            }
        }


        private void radioButton_BodyFront_Click(object sender, EventArgs e)
        {
            listBox_muscle.Items.Clear();
            pictureBox1.Image=imageList1.Images[0];
            for (int i = 0; i <= FrontMuscle.GetUpperBound(0); i++)
            {
                listBox_muscle.Items.Add(FrontMuscle[i]);
            }

        }

        private void radioButton_Body_Back_Click(object sender, EventArgs e)
        {
            listBox_muscle.Items.Clear();
            pictureBox1.Image = imageList1.Images[1];
            for (int i = 0; i <= BackMuscle.GetUpperBound(0); i++)
            {
                listBox_muscle.Items.Add(BackMuscle[i]);
            }

        }
        //whem listbox is selected(user choose a muscle)
        private void listBox_muscle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton_BodyFront.Checked ==true)
            {
                textBox_description.Text = FrontMuscleDescription[listBox_muscle.SelectedIndex];
            }
            else
            {
                textBox_description.Text=BackDescription[listBox_muscle.SelectedIndex];
            }
        }
    }
}
