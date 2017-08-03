using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            Process.Start("steam://rungameid/582200");
        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            Process.Start("steam://rungameid/451980");
        }
        private void button3_Click(object sender, System.EventArgs e)
        {
            Process.Start("steam://rungameid/548010");
        }
        private void button4_Click(object sender, System.EventArgs e)
        {
            Process.Start("steam://rungameid/493430");
        }
    }
}
