using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);

            if (num1 == 2 || num1 == 6)
            {
                if (num1 == 2 && (num2 >= 19.0 && num2 <= 20.0))
                {
                    flag = 1;
                }
                else if (num1 == 6 && (num2 >= 17.0 && num2 <= 18.0))
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }
            else
            {
                flag = 0;
            }

            if (flag == 1)
            {
                label3.Text = "打折";
            }
            else
            {
                label3.Text = "不打折";
            }

        }
    }
}
