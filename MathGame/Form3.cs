using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string filesource = @"C:\Users\ilyas.bayram\source\repos\MathGame\HowToPlay.txt.";
            string text = System.IO.File.ReadAllText(filesource);
            textBox1.Text = text;
        }
    }
}
