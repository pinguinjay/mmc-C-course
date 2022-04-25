namespace StandardWeightSwitch110910020
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_diagnose = new System.Windows.Forms.Button();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idealW = new System.Windows.Forms.TextBox();
            this.idealWRange = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weightBox);
            this.groupBox1.Controls.Add(this.heightBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_gender);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請輸入您的個人資訊";
            // 
            // button_diagnose
            // 
            this.button_diagnose.Location = new System.Drawing.Point(12, 199);
            this.button_diagnose.Name = "button_diagnose";
            this.button_diagnose.Size = new System.Drawing.Size(75, 23);
            this.button_diagnose.TabIndex = 1;
            this.button_diagnose.Text = "診斷";
            this.button_diagnose.UseVisualStyleBackColor = true;
            this.button_diagnose.Click += new System.EventHandler(this.button_diagnose_Click);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "女",
            "男"});
            this.comboBox_gender.Location = new System.Drawing.Point(89, 26);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(71, 20);
            this.comboBox_gender.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "性別";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "身高(cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "體重(kg)";
            // 
            // heightBox
            // 
            this.heightBox.ForeColor = System.Drawing.Color.Silver;
            this.heightBox.Location = new System.Drawing.Point(89, 61);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 22);
            this.heightBox.TabIndex = 4;
            this.heightBox.Text = "請輸入您的身高";
            this.heightBox.Enter += new System.EventHandler(this.heightBox_Enter);
            this.heightBox.Leave += new System.EventHandler(this.heightBox_Leave);
            // 
            // weightBox
            // 
            this.weightBox.ForeColor = System.Drawing.Color.Silver;
            this.weightBox.Location = new System.Drawing.Point(89, 100);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 22);
            this.weightBox.TabIndex = 5;
            this.weightBox.Text = "請輸入您的體重";
            this.weightBox.Enter += new System.EventHandler(this.weightBox_Enter);
            this.weightBox.Leave += new System.EventHandler(this.weightBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "您的理想體重(kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "合理體重範圍(kg)";
            // 
            // idealW
            // 
            this.idealW.Location = new System.Drawing.Point(128, 263);
            this.idealW.Name = "idealW";
            this.idealW.Size = new System.Drawing.Size(100, 22);
            this.idealW.TabIndex = 4;
            // 
            // idealWRange
            // 
            this.idealWRange.Location = new System.Drawing.Point(128, 329);
            this.idealWRange.Name = "idealWRange";
            this.idealWRange.Size = new System.Drawing.Size(100, 22);
            this.idealWRange.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 259);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 371);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.idealWRange);
            this.Controls.Add(this.idealW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_diagnose);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "標準體重診斷Switch練習110910020";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Button button_diagnose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idealW;
        private System.Windows.Forms.TextBox idealWRange;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

