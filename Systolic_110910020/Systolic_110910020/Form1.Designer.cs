namespace Systolic_110910020
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
            this.systolicenterlabel = new System.Windows.Forms.Label();
            this.systolic_enter = new System.Windows.Forms.TextBox();
            this.sys_require = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // systolicenterlabel
            // 
            this.systolicenterlabel.AutoSize = true;
            this.systolicenterlabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.systolicenterlabel.Location = new System.Drawing.Point(12, 55);
            this.systolicenterlabel.Name = "systolicenterlabel";
            this.systolicenterlabel.Size = new System.Drawing.Size(122, 21);
            this.systolicenterlabel.TabIndex = 0;
            this.systolicenterlabel.Text = "請輸入縮收壓：";
            // 
            // systolic_enter
            // 
            this.systolic_enter.Location = new System.Drawing.Point(145, 54);
            this.systolic_enter.Name = "systolic_enter";
            this.systolic_enter.Size = new System.Drawing.Size(106, 22);
            this.systolic_enter.TabIndex = 1;
            // 
            // sys_require
            // 
            this.sys_require.Location = new System.Drawing.Point(277, 44);
            this.sys_require.Name = "sys_require";
            this.sys_require.Size = new System.Drawing.Size(105, 46);
            this.sys_require.TabIndex = 2;
            this.sys_require.Text = "查詢血壓狀態";
            this.sys_require.UseVisualStyleBackColor = true;
            this.sys_require.Click += new System.EventHandler(this.sys_require_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 114);
            this.Controls.Add(this.sys_require);
            this.Controls.Add(this.systolic_enter);
            this.Controls.Add(this.systolicenterlabel);
            this.Name = "Form1";
            this.Text = "Systolic_110910020";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label systolicenterlabel;
        private System.Windows.Forms.TextBox systolic_enter;
        private System.Windows.Forms.Button sys_require;
    }
}

