using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee;

namespace SalaryWindow
{
    public partial class SalaryWindow : Form
    {
        public SalaryWindow()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int baseSalary = int.Parse(BaseSalaryTextBox.Text);
            int benifit = int.Parse(BenifitTextBox.Text);

            Employees someone = new Employees("NICK", baseSalary, benifit);
            MessageBox.Show(someone.ToString());
        }
    }
}