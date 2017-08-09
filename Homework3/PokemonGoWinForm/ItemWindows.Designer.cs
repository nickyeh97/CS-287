namespace PokemonGoWinForm
{
    partial class ItemsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsWindow));
            this.PotionLabel = new System.Windows.Forms.Label();
            this.SuperPotionLabel = new System.Windows.Forms.Label();
            this.HyperPotionLabel = new System.Windows.Forms.Label();
            this.Pokemon1Label = new System.Windows.Forms.Label();
            this.Pokemon2Label = new System.Windows.Forms.Label();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PotionLabel
            // 
            this.PotionLabel.AutoSize = true;
            this.PotionLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotionLabel.Location = new System.Drawing.Point(15, 48);
            this.PotionLabel.Name = "PotionLabel";
            this.PotionLabel.Size = new System.Drawing.Size(90, 28);
            this.PotionLabel.TabIndex = 0;
            this.PotionLabel.Text = "Potion";
            this.PotionLabel.Click += new System.EventHandler(this.PotionLabel_Click);
            // 
            // SuperPotionLabel
            // 
            this.SuperPotionLabel.AutoSize = true;
            this.SuperPotionLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperPotionLabel.Location = new System.Drawing.Point(15, 109);
            this.SuperPotionLabel.Name = "SuperPotionLabel";
            this.SuperPotionLabel.Size = new System.Drawing.Size(155, 28);
            this.SuperPotionLabel.TabIndex = 1;
            this.SuperPotionLabel.Text = "SuperPotion";
            this.SuperPotionLabel.Click += new System.EventHandler(this.SuperPotionLabel_Click);
            // 
            // HyperPotionLabel
            // 
            this.HyperPotionLabel.AutoSize = true;
            this.HyperPotionLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HyperPotionLabel.Location = new System.Drawing.Point(15, 186);
            this.HyperPotionLabel.Name = "HyperPotionLabel";
            this.HyperPotionLabel.Size = new System.Drawing.Size(155, 28);
            this.HyperPotionLabel.TabIndex = 2;
            this.HyperPotionLabel.Text = "HyperPotion";
            this.HyperPotionLabel.Click += new System.EventHandler(this.HyperPotionLabel_Click);
            // 
            // Pokemon1Label
            // 
            this.Pokemon1Label.AutoSize = true;
            this.Pokemon1Label.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pokemon1Label.Location = new System.Drawing.Point(15, 397);
            this.Pokemon1Label.Name = "Pokemon1Label";
            this.Pokemon1Label.Size = new System.Drawing.Size(116, 28);
            this.Pokemon1Label.TabIndex = 3;
            this.Pokemon1Label.Text = "Pokemon1";
            this.Pokemon1Label.Click += new System.EventHandler(this.Pokemon1Label_Click);
            // 
            // Pokemon2Label
            // 
            this.Pokemon2Label.AutoSize = true;
            this.Pokemon2Label.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pokemon2Label.Location = new System.Drawing.Point(15, 467);
            this.Pokemon2Label.Name = "Pokemon2Label";
            this.Pokemon2Label.Size = new System.Drawing.Size(116, 28);
            this.Pokemon2Label.TabIndex = 4;
            this.Pokemon2Label.Text = "Pokemon2";
            this.Pokemon2Label.Click += new System.EventHandler(this.Pokemon2Label_Click);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreButton.Location = new System.Drawing.Point(507, 397);
            this.RestoreButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(202, 108);
            this.RestoreButton.TabIndex = 5;
            this.RestoreButton.Text = "回復";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // ItemsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 548);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.Pokemon2Label);
            this.Controls.Add(this.Pokemon1Label);
            this.Controls.Add(this.HyperPotionLabel);
            this.Controls.Add(this.SuperPotionLabel);
            this.Controls.Add(this.PotionLabel);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemsWindow";
            this.Text = "神奇寶貝中心";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PotionLabel;
        private System.Windows.Forms.Label SuperPotionLabel;
        private System.Windows.Forms.Label HyperPotionLabel;
        private System.Windows.Forms.Label Pokemon1Label;
        private System.Windows.Forms.Label Pokemon2Label;
        private System.Windows.Forms.Button RestoreButton;
    }
}

