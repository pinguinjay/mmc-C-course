namespace SkeletonMuscle110910020
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
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.listBox_muscle = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_BodyFront = new System.Windows.Forms.RadioButton();
            this.radioButton_Body_Back = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(12, 506);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(360, 154);
            this.textBox_description.TabIndex = 0;
            // 
            // listBox_muscle
            // 
            this.listBox_muscle.FormattingEnabled = true;
            this.listBox_muscle.ItemHeight = 15;
            this.listBox_muscle.Location = new System.Drawing.Point(12, 91);
            this.listBox_muscle.Name = "listBox_muscle";
            this.listBox_muscle.Size = new System.Drawing.Size(360, 334);
            this.listBox_muscle.TabIndex = 1;
            this.listBox_muscle.SelectedIndexChanged += new System.EventHandler(this.listBox_muscle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "功能解釋";
            // 
            // radioButton_BodyFront
            // 
            this.radioButton_BodyFront.AutoSize = true;
            this.radioButton_BodyFront.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_BodyFront.Location = new System.Drawing.Point(17, 50);
            this.radioButton_BodyFront.Name = "radioButton_BodyFront";
            this.radioButton_BodyFront.Size = new System.Drawing.Size(173, 29);
            this.radioButton_BodyFront.TabIndex = 3;
            this.radioButton_BodyFront.TabStop = true;
            this.radioButton_BodyFront.Text = "人體正面骨骼肌";
            this.radioButton_BodyFront.UseVisualStyleBackColor = true;
            this.radioButton_BodyFront.Click += new System.EventHandler(this.radioButton_BodyFront_Click);
            // 
            // radioButton_Body_Back
            // 
            this.radioButton_Body_Back.AutoSize = true;
            this.radioButton_Body_Back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_Body_Back.Location = new System.Drawing.Point(199, 50);
            this.radioButton_Body_Back.Name = "radioButton_Body_Back";
            this.radioButton_Body_Back.Size = new System.Drawing.Size(173, 29);
            this.radioButton_Body_Back.TabIndex = 4;
            this.radioButton_Body_Back.TabStop = true;
            this.radioButton_Body_Back.Text = "人體背面骨骼肌";
            this.radioButton_Body_Back.UseVisualStyleBackColor = true;
            this.radioButton_Body_Back.Click += new System.EventHandler(this.radioButton_Body_Back_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "frontMuscle.png");
            this.imageList1.Images.SetKeyName(1, "backMuscle.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(452, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 494);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 688);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton_Body_Back);
            this.Controls.Add(this.radioButton_BodyFront);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_muscle);
            this.Controls.Add(this.textBox_description);
            this.Name = "Form1";
            this.Text = "人體骨骼肌導覽110910020";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.ListBox listBox_muscle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_BodyFront;
        private System.Windows.Forms.RadioButton radioButton_Body_Back;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

