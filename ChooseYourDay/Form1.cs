using System;
using System.Windows.Forms;

namespace ChooseYourDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            Red.Visible = false; // Hide Red Button
            Blue.Dock = DockStyle.Fill; // Scale Blue Button to full window
        }

        private void Red_Click(object sender, EventArgs e)
        {
            Blue.Visible = false; // Hide Blue Button
            Red.Dock = DockStyle.Fill; // Scale Red Button to full window
        }
    }
}