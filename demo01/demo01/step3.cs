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
    public partial class step3 : Form
    {
        public step3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path2 = System.Environment.CurrentDirectory;


            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo($@"{path2}\data\step3");
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

            string[] lines = { time, "这是第一行", "这是第二行", "这是第三行" };
            System.IO.File.WriteAllLines($@"{path2}\data\step3\{time}.txt", lines); ;
        }
    }
}
