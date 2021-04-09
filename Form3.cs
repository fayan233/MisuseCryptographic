using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bishe
{

    public partial class Form3 : Form
    {
        private string ip="";
        public Form3(string name)
        {
            InitializeComponent(name);
        }
        public bool IsValidIP(string ip)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ip, "[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}"))
            {
                string[] ips = ip.Split('.');
                if (ips.Length == 4 || ips.Length == 6)
                {
                    if (System.Int32.Parse(ips[0]) < 256 && System.Int32.Parse(ips[1]) < 256 & System.Int32.Parse(ips[2]) < 256 & System.Int32.Parse(ips[3]) < 256)
                        return true;
                    else
                        return false;
                }
                else
                    return false;

            }
            else
                return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("请在上方输入密码套件服务主机地址后确认。");
                return;
            }
            else
            {
                if(!IsValidIP(textBox1.Text))
                {
                    MessageBox.Show("非法输入");
                    return;
                }
                else
                {
                    ip = textBox1.Text;
                    this.Close();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ip = "";
            this.Close();
        }
        public string Getip()
        {
            return ip;
        }

        
    }
}
