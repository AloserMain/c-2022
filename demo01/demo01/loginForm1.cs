using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 第一
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            step1 f = new step1();
            f.ShowDialog();

        }
        /// <summary>
        /// 第二
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            step2 f = new step2();
            f.ShowDialog();
        }
        /// <summary>
        /// 第三
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            step3 f = new step3();
            f.ShowDialog();
        }
        /// <summary>
        /// 第四
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            step4 f = new step4();
            f.ShowDialog();
        }
        /// <summary>
        /// 
        /// 第五
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            step5 f = new step5();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            delete_data dd = new delete_data();
            dd.Show();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            step6 st6 = new step6();
            st6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            step7 st = new step7();
            st.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            step8 st = new step8();
            st.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            step9 st = new step9();
            st.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            step10 st = new step10();
            st.Show();
        }
    }
}
