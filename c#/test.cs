using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorChangerApp
{
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set initial properties
            label1.Text = "Click the button to change colors";
            button1.Text = "Change Color";
            
            // Add event handler for button click
            button1.Click += new EventHandler(Button1_Click);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Random color generator
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            // Change the label and button colors
            label1.BackColor = randomColor;
            label1.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            button1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            button1.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
