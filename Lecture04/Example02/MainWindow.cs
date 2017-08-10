using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code.Org;

namespace Example02
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            //Made Elsa  object!
            Person elsa = new Person()
            {
                Name = "Elsa",
                Pos = new Position()
                {
                    x = 100.0,
                    y = 0.0,
                },
                Theta = 0.0
            };

            int x = (int)elsa.Pos.x + 50;
            int y = 120;
            ElsaPictureBox.Location = new Point(x, y);

            if (elsa.isHappy())
            {
                this.ElsaPictureBox.Image = global::Example02.Properties.Resources._123___10IV18g;
            }
            else
            {
                this.ElsaPictureBox.Image = global::Example02.Properties.Resources.下載;
            }
        }
    }
}