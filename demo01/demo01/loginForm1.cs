using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo01
{
    public partial class loginForm1 : Form
    {
        public loginForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Run(new step1());//启动
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            step3 f = new step3();
            f.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            step1 f = new step1();
            f.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            step2 f = new step2();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            step4 f = new step4();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            step5 f = new step5();
            f.ShowDialog();
        }
    }
}
