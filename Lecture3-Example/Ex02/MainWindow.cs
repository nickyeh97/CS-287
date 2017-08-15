using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppleStoreLibrary1;

namespace Ex02
{
    public partial class MainWindow : Form
    {
        public List<Product> Products;
        public int Total = 0;

        public MainWindow()
        {
            InitializeComponent();

            Products = new List<Product>
            {
                new Product()
                {
                     Id = 1,
                     Name = "iphone7",
                     Price = 28900,
                     Category ="iPhone"
                },

                new Product()
                {
                    Id = 2,
                    Name = "iphone 7s",
                    Price = 31900,
                   Category =  "iPhones"
                }
            };
            Render();
        }

        private void AddButton1_Click(object sender, EventArgs e)
        {
            ShoppingCartRichTextBox.Text =
                ShoppingCartRichTextBox.Text + Products[0].Name + "\n";
            Total += Products[0].Price;
            Render();
        }

        private void AddButton2_Click(object sender, EventArgs e)
        {
            ShoppingCartRichTextBox.Text =
                ShoppingCartRichTextBox.Text + Products[1].Name + "\n";
            Total += Products[0].Price;
            Render();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Total = 0;
            ShoppingCartRichTextBox.Text = " ";
            TotalLabel.Text = "總金額: 0元";
        }

        public void Render()
        {
            ProductLabel1.Text = string.Format("產品{0},價格{1}元", Products[0].Name, Products[0].Price);
            ProductLabel2.Text = string.Format("產品{0},價格{1}元", Products[1].Name, Products[1].Price);

            TotalLabel.Text = string.Format("總金額: {0}", Total);
        }

        private void AddProductMenuItem1_Click(object sender, EventArgs e)
        {
            ProductManagementWindow pmWindow = new ProductManagementWindow();
            pmWindow.ParentWindow = this;
            pmWindow.Show();
        }
    }
}