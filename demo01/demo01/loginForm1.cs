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
            /// <summary>
            /// 删除文件夹
            /// </summary>
            /// <param name="path">要删除的文件夹目录</param>
            string pathData = System.Environment.CurrentDirectory;
            string path = $@"{pathData}\data";
                DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                DirectoryInfo[] childs = dir.GetDirectories();
                foreach (DirectoryInfo child in childs)
                {
                    child.Delete(true);
                }
                dir.Delete(true);
                info i = new info();
                i.Show();
            }
            else {
                errinfo ei = new errinfo();
                ei.Show();
            }
            

        }
    }
}
