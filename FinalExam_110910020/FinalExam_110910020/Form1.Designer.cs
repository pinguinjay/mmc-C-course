namespace FinalExam_110910020
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButton_outerEar = new System.Windows.Forms.RadioButton();
            this.radioButton_middleear = new System.Windows.Forms.RadioButton();
            this.radioButton_innerEar = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_outerEar
            // 
            this.radioButton_outerEar.AutoSize = true;
            this.radioButton_outerEar.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_outerEar.Location = new System.Drawing.Point(13, 26);
            this.radioButton_outerEar.Name = "radioButton_outerEar";
            this.radioButton_outerEar.Size = new System.Drawing.Size(60, 23);
            this.radioButton_outerEar.TabIndex = 0;
            this.radioButton_outerEar.TabStop = true;
            this.radioButton_outerEar.Text = "外耳";
            this.radioButton_outerEar.UseVisualStyleBackColor = true;
            this.radioButton_outerEar.Click += new System.EventHandler(this.radioButton_outerEar_Click);
            // 
            // radioButton_middleear
            // 
            this.radioButton_middleear.AutoSize = true;
            this.radioButton_middleear.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_middleear.Location = new System.Drawing.Point(90, 26);
            this.radioButton_middleear.Name = "radioButton_middleear";
            this.radioButton_middleear.Size = new System.Drawing.Size(60, 23);
            this.radioButton_middleear.TabIndex = 1;
            this.radioButton_middleear.TabStop = true;
            this.radioButton_middleear.Text = "中耳";
            this.radioButton_middleear.UseVisualStyleBackColor = true;
            this.radioButton_middleear.Click += new System.EventHandler(this.radioButton_middleear_Click);
            // 
            // radioButton_innerEar
            // 
            this.radioButton_innerEar.AutoSize = true;
            this.radioButton_innerEar.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_innerEar.Location = new System.Drawing.Point(168, 26);
            this.radioButton_innerEar.Name = "radioButton_innerEar";
            this.radioButton_innerEar.Size = new System.Drawing.Size(60, 23);
            this.radioButton_innerEar.TabIndex = 2;
            this.radioButton_innerEar.TabStop = true;
            this.radioButton_innerEar.Text = "內耳";
            this.radioButton_innerEar.UseVisualStyleBackColor = true;
            this.radioButton_innerEar.Click += new System.EventHandler(this.radioButton_innerEar_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(13, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 194);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "功能解釋";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(13, 359);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 156);
            this.textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(335, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "outerEar.png");
            this.imageList1.Images.SetKeyName(1, "MiddleEar.png");
            this.imageList1.Images.SetKeyName(2, "innerEar.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButton_innerEar);
            this.Controls.Add(this.radioButton_middleear);
            this.Controls.Add(this.radioButton_outerEar);
            this.Name = "Form1";
            this.Text = "耳朵導覽_110910020";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_outerEar;
        private System.Windows.Forms.RadioButton radioButton_middleear;
        private System.Windows.Forms.RadioButton radioButton_innerEar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

