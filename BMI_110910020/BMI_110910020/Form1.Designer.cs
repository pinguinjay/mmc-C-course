namespace BMI_110910020
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.cleanup_botton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(274, 199);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 102);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "身體質量指數（Body Mass Index, BMI）世界衛生組織建議衡量肥胖程度的指標，BMI 值計算公式是以體重 (公斤) 除以身高 (公尺) 的平方，來算" +
    "算看自己的 BMI 是否標準吧！";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(12, 73);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 28);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "身高(cm)";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(12, 145);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 28);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "體重(kg)";
            // 
            // heightBox
            // 
            this.heightBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.heightBox.ForeColor = System.Drawing.Color.Silver;
            this.heightBox.Location = new System.Drawing.Point(127, 73);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 25);
            this.heightBox.TabIndex = 4;
            this.heightBox.Text = "請輸入您的身高";
            this.heightBox.Enter += new System.EventHandler(this.heightBox_Enter);
            this.heightBox.Leave += new System.EventHandler(this.heightBox_Leave);
            // 
            // weightBox
            // 
            this.weightBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightBox.ForeColor = System.Drawing.Color.Silver;
            this.weightBox.Location = new System.Drawing.Point(127, 150);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 25);
            this.weightBox.TabIndex = 5;
            this.weightBox.Text = "請輸入您的體重";
            this.weightBox.Enter += new System.EventHandler(this.weightBox_Enter);
            this.weightBox.Leave += new System.EventHandler(this.weightBox_Leave);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculate.Location = new System.Drawing.Point(27, 199);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(176, 57);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "計算";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cleanup_botton
            // 
            this.cleanup_botton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cleanup_botton.Location = new System.Drawing.Point(27, 272);
            this.cleanup_botton.Name = "cleanup_botton";
            this.cleanup_botton.Size = new System.Drawing.Size(176, 29);
            this.cleanup_botton.TabIndex = 7;
            this.cleanup_botton.Text = "清空";
            this.cleanup_botton.UseVisualStyleBackColor = true;
            this.cleanup_botton.Click += new System.EventHandler(this.cleanup_botton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(538, 328);
            this.Controls.Add(this.cleanup_botton);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "BMI_110910020";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button cleanup_botton;
    }
}

