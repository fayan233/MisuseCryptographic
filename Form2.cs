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

namespace bishe
{
    public partial class Form2 : Form
    {
        private string dir="";
        public string getdir()
        {
            return dir;
        }
        public Form2(string name)
        {
            InitializeComponent(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\";    //打开对话框后的初始目录
            fileDialog.Filter = "所有文件|*.*";
            fileDialog.RestoreDirectory = false;    //若为false，则打开对话框后为上次的目录。若为true，则为初始目录
            if (fileDialog.ShowDialog() == DialogResult.OK)
                textBox1.Text = System.IO.Path.GetFullPath(fileDialog.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("请点击“选取文件”按钮选择要进行静态检测的文件。");
            }
            else
            {

                dir = textBox1.Text;
                this.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dir = "";
            this.Close();
        }
        #region 保存对话框


    }
}

#endregion