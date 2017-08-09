namespace Ex02
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ShoppingCartRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ProductLabel1 = new System.Windows.Forms.Label();
            this.ProductLabel2 = new System.Windows.Forms.Label();
            this.AddButton1 = new System.Windows.Forms.Button();
            this.AddButton2 = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShoppingCartRichTextBox
            // 
            this.ShoppingCartRichTextBox.Location = new System.Drawing.Point(28, 393);
            this.ShoppingCartRichTextBox.Name = "ShoppingCartRichTextBox";
            this.ShoppingCartRichTextBox.Size = new System.Drawing.Size(498, 137);
            this.ShoppingCartRichTextBox.TabIndex = 0;
            this.ShoppingCartRichTextBox.Text = "";
            // 
            // ProductLabel1
            // 
            this.ProductLabel1.AutoSize = true;
            this.ProductLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel1.Location = new System.Drawing.Point(54, 81);
            this.ProductLabel1.Name = "ProductLabel1";
            this.ProductLabel1.Size = new System.Drawing.Size(81, 19);
            this.ProductLabel1.TabIndex = 1;
            this.ProductLabel1.Text = "Product1";
            // 
            // ProductLabel2
            // 
            this.ProductLabel2.AutoSize = true;
            this.ProductLabel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel2.Location = new System.Drawing.Point(54, 157);
            this.ProductLabel2.Name = "ProductLabel2";
            this.ProductLabel2.Size = new System.Drawing.Size(81, 19);
            this.ProductLabel2.TabIndex = 2;
            this.ProductLabel2.Text = "Product2";
            // 
            // AddButton1
            // 
            this.AddButton1.Location = new System.Drawing.Point(359, 81);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(167, 38);
            this.AddButton1.TabIndex = 3;
            this.AddButton1.Text = "加入購物清單";
            this.AddButton1.UseVisualStyleBackColor = true;
            this.AddButton1.Click += new System.EventHandler(this.AddButton1_Click);
            // 
            // AddButton2
            // 
            this.AddButton2.Location = new System.Drawing.Point(359, 157);
            this.AddButton2.Name = "AddButton2";
            this.AddButton2.Size = new System.Drawing.Size(167, 38);
            this.AddButton2.TabIndex = 5;
            this.AddButton2.Text = "加入購物清單";
            this.AddButton2.UseVisualStyleBackColor = true;
            this.AddButton2.Click += new System.EventHandler(this.AddButton2_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(58, 356);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(94, 24);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "總金額:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(359, 346);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(167, 41);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "清空購物車";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 548);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.AddButton2);
            this.Controls.Add(this.AddButton1);
            this.Controls.Add(this.ProductLabel2);
            this.Controls.Add(this.ProductLabel1);
            this.Controls.Add(this.ShoppingCartRichTextBox);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Welcom to Apple Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ShoppingCartRichTextBox;
        private System.Windows.Forms.Label ProductLabel1;
        private System.Windows.Forms.Label ProductLabel2;
        private System.Windows.Forms.Button AddButton1;
        private System.Windows.Forms.Button AddButton2;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

