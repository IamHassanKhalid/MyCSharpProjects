using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEC_15
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

        private void button1_Click(object sender, EventArgs e)
        {
            EXAMPLE obj1 = new EXAMPLE(50);
            label1.Text = "the obj1:" + obj1.display();
            EXAMPLE obj2 = obj1;
            label2.Text = "the obj2:" + obj2.display();

        }
    }
}
