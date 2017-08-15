namespace Ex02
{
    partial class ProductManagementWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductIdTextbox = new System.Windows.Forms.TextBox();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductNameTextbox = new System.Windows.Forms.TextBox();
            this.ProductPriceTextbox = new System.Windows.Forms.TextBox();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.ProductStatusLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductIdTextbox
            // 
            this.ProductIdTextbox.Location = new System.Drawing.Point(117, 56);
            this.ProductIdTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ProductIdTextbox.Name = "ProductIdTextbox";
            this.ProductIdTextbox.Size = new System.Drawing.Size(164, 30);
            this.ProductIdTextbox.TabIndex = 1;
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Location = new System.Drawing.Point(45, 64);
            this.ProductIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(40, 22);
            this.ProductIdLabel.TabIndex = 2;
            this.ProductIdLabel.Text = "Id:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(45, 121);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(60, 22);
            this.ProductNameLabel.TabIndex = 3;
            this.ProductNameLabel.Text = "Name:";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(45, 173);
            this.ProductPriceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(70, 22);
            this.ProductPriceLabel.TabIndex = 4;
            this.ProductPriceLabel.Text = "Price:";
            // 
            // ProductNameTextbox
            // 
            this.ProductNameTextbox.Location = new System.Drawing.Point(117, 113);
            this.ProductNameTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ProductNameTextbox.Name = "ProductNameTextbox";
            this.ProductNameTextbox.Size = new System.Drawing.Size(164, 30);
            this.ProductNameTextbox.TabIndex = 5;
            // 
            // ProductPriceTextbox
            // 
            this.ProductPriceTextbox.Location = new System.Drawing.Point(117, 170);
            this.ProductPriceTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ProductPriceTextbox.Name = "ProductPriceTextbox";
            this.ProductPriceTextbox.Size = new System.Drawing.Size(164, 30);
            this.ProductPriceTextbox.TabIndex = 6;
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Location = new System.Drawing.Point(45, 222);
            this.ProductCategoryLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(100, 22);
            this.ProductCategoryLabel.TabIndex = 7;
            this.ProductCategoryLabel.Text = "Category:";
            // 
            // ProductStatusLabel
            // 
            this.ProductStatusLabel.AutoSize = true;
            this.ProductStatusLabel.Location = new System.Drawing.Point(45, 271);
            this.ProductStatusLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProductStatusLabel.Name = "ProductStatusLabel";
            this.ProductStatusLabel.Size = new System.Drawing.Size(80, 22);
            this.ProductStatusLabel.TabIndex = 8;
            this.ProductStatusLabel.Text = "Status:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "iPhone",
            "iPad",
            "Mac"});
            this.CategoryComboBox.Location = new System.Drawing.Point(160, 219);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 30);
            this.CategoryComboBox.TabIndex = 11;
            this.CategoryComboBox.Text = "請選擇分類";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "可訂購",
            "特價中",
            "已售完"});
            this.StatusComboBox.Location = new System.Drawing.Point(159, 271);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 30);
            this.StatusComboBox.TabIndex = 12;
            this.StatusComboBox.Text = "請選擇狀態";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(49, 367);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(232, 71);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ProductManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 480);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ProductStatusLabel);
            this.Controls.Add(this.ProductCategoryLabel);
            this.Controls.Add(this.ProductPriceTextbox);
            this.Controls.Add(this.ProductNameTextbox);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductIdLabel);
            this.Controls.Add(this.ProductIdTextbox);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ProductManagementWindow";
            this.Text = "新增產品";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ProductIdTextbox;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.TextBox ProductNameTextbox;
        private System.Windows.Forms.TextBox ProductPriceTextbox;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label ProductStatusLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Button SaveButton;
    }
}