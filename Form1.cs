using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigNumberBetween3Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            if(a>b && a > c)
            {
                label1.Text = "big number is a";
            }

            else if(b>a && b>c)
            {
                label1.Text = "big number is b";

            }
            else
            {
                label1.Text = "big number is c";

            }
        }
    }
}
