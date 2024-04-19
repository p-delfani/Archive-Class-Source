using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_addad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, i;

            long fact = 1;
            n = Convert.ToInt32(textBox1.Text);

            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            label1.Text = fact.ToString();
        }
    }
}
