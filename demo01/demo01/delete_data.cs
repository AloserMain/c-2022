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
    public partial class delete_data : Form
    {
        public delete_data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            else
            {
                errinfo ei = new errinfo();
                ei.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
