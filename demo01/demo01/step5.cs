using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace demo01
{
    public partial class step5 : Form
    {
        public step5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path2 = System.Environment.CurrentDirectory;


            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo($@"{path2}\data\step5");
            di.Create();
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            int 年 = currentTime.Year;
            int 月 = currentTime.Month;
            int 日 = currentTime.Day;
            int 时 = currentTime.Hour;
            int 分 = currentTime.Minute;
            int 秒 = currentTime.Second;
            int 毫秒 = currentTime.Millisecond;
            string time = 年.ToString() + "年" + 月.ToString() + "月" + 日.ToString() + "日" + 时.ToString() + "时" + 分.ToString() + "分" + 秒.ToString() + "秒";
            string line1 = textBox4.Text;
            string line2 = textBox5.Text;
            string line3 = textBox6.Text;
            string[] lines = { time, line1, line2, line3 };
            System.IO.File.WriteAllLines($@"{path2}\data\step5\{time}.txt", lines);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Boolean a = Regex.IsMatch(textBox1.Text, @"^\d+$"); // 判断字符串是否为数字 的正则表达式
            Boolean b = Regex.IsMatch(textBox2.Text, @"^\d+$"); // 判断字符串是否为数字 的正则表达式
            Boolean c = Regex.IsMatch(textBox3.Text, @"^\d+$"); // 判断字符串是否为数字 的正则表达式

            if (!a)
            {
                only_number on = new only_number();
                on.Show();
                return;
            }
            if (!b)
            {
                only_number1 on = new only_number1();
                on.Show();
                return;
            }
            if (!c)
            {
                only_number2 on = new only_number2();
                on.Show();
                return;
            }
            textBox4.Text = textBox1.Text;
            textBox5.Text = textBox2.Text;
            textBox6.Text = textBox3.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
