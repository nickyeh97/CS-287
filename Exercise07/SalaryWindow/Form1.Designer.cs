namespace SalaryWindow
{
    partial class SalaryWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.BaseSalaryTextBox = new System.Windows.Forms.RichTextBox();
            this.BenifitTextBox = new System.Windows.Forms.RichTextBox();
            this.BenifitLabel = new System.Windows.Forms.Label();
            this.BaseSalaryLabel = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BaseSalaryTextBox
            // 
            this.BaseSalaryTextBox.Location = new System.Drawing.Point(260, 28);
            this.BaseSalaryTextBox.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BaseSalaryTextBox.Name = "BaseSalaryTextBox";
            this.BaseSalaryTextBox.Size = new System.Drawing.Size(234, 42);
            this.BaseSalaryTextBox.TabIndex = 2;
            this.BaseSalaryTextBox.Text = " ";
            // 
            // BenifitTextBox
            // 
            this.BenifitTextBox.Location = new System.Drawing.Point(260, 107);
            this.BenifitTextBox.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BenifitTextBox.Name = "BenifitTextBox";
            this.BenifitTextBox.Size = new System.Drawing.Size(234, 42);
            this.BenifitTextBox.TabIndex = 3;
            this.BenifitTextBox.Text = " ";
            // 
            // BenifitLabel
            // 
            this.BenifitLabel.AutoSize = true;
            this.BenifitLabel.Location = new System.Drawing.Point(63, 131);
            this.BenifitLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BenifitLabel.Name = "BenifitLabel";
            this.BenifitLabel.Size = new System.Drawing.Size(110, 21);
            this.BenifitLabel.TabIndex = 1;
            this.BenifitLabel.Text = "請輸入獎金";
            // 
            // BaseSalaryLabel
            // 
            this.BaseSalaryLabel.AutoSize = true;
            this.BaseSalaryLabel.Location = new System.Drawing.Point(63, 52);
            this.BaseSalaryLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BaseSalaryLabel.Name = "BaseSalaryLabel";
            this.BaseSalaryLabel.Size = new System.Drawing.Size(110, 21);
            this.BaseSalaryLabel.TabIndex = 0;
            this.BaseSalaryLabel.Text = "請輸入新水";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(260, 189);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(230, 68);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // SalaryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 458);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.BenifitTextBox);
            this.Controls.Add(this.BaseSalaryTextBox);
            this.Controls.Add(this.BenifitLabel);
            this.Controls.Add(this.BaseSalaryLabel);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "SalaryWindow";
            this.Text = "Salary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox BaseSalaryTextBox;
        private System.Windows.Forms.RichTextBox BenifitTextBox;
        private System.Windows.Forms.Label BenifitLabel;
        private System.Windows.Forms.Label BaseSalaryLabel;
        private System.Windows.Forms.Button ShowButton;
    }
}

