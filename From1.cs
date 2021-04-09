using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace bishe
{
    public partial class From1 : Form //一个类分两半写
    {
        private string path_密码常量检测 = @".\MisuseCryptographic\houduan\findcrypt3";
        private string path_Openssh动态检测 = @".\MisuseCryptographic\houduan\Openssh动态检测";
        private string path_Dropbear动态检测 = @".\MisuseCryptographic\houduan\Dropbear动态检测";
        private string path_Openssl动态检测= @".\MisuseCryptographic\houduan\Openssl动态检测";
        private string path_密码算法误用静态检测 = @".\MisuseCryptographic\houduan\密码算法误用静态检测";
        private string IDA_path = @"C:\Users\cjt\Desktop\project\CryptoIdentif\CryptoIdentification\bin\Debug\work\work\bin\IDA_7.0";
        private string IDA_script = @".\exp.py";
        private Form2 submit;
        private Form3 form3;
        private string dir = "";
        private string ip = "";
        private string share = @"C:\Users\94938\Desktop\share";
        private string[] strs;
        private int index;
        private void filesolve2(string fileName)
        {
            string strTxt = File.ReadAllText(fileName,Encoding.Default);
            strTxt = strTxt.Replace("[92m", "");
            strTxt = strTxt.Replace("[1;36m", "");
            strTxt = strTxt.Replace("[0m", "");
            strTxt = strTxt.Replace("[93m", "");
            strTxt = strTxt.Replace("[91m", "");
            strTxt = strTxt.Replace("# 附加信息", "");
            strTxt = strTxt.Replace("(nfo) For hardening guides on common OSes, please see: <https://www.ssh-audit.com/hardening_guides.html>", "");
            strTxt = strTxt.Replace("!!! WARNING: unknown algorithm(s) found!: sm2kep-sha2-nistp256.  Please email the full output above to the maintainer (jtesta@positronsecurity.com), or create a Github issue at <https://github.com/jtesta/ssh-audit/issues>.", " ");

            File.WriteAllText(fileName, strTxt,Encoding.Default);
        }
        private void filesolve1(string fileName)
        {
            string strTxt = File.ReadAllText(fileName);
            strTxt = strTxt.Replace("[", "");
            strTxt = strTxt.Replace("]", "");
            strTxt = strTxt.Replace(",", " ");
            strTxt = strTxt.Replace("  ", " ");
            strTxt = strTxt.Replace("   ", " ");
            strTxt = strTxt.Replace("    ", " ");
            strTxt = strTxt.Replace("     ", " ");
            strTxt = strTxt.Replace("      ", " ");
            strTxt = strTxt.Replace("       ", " ");
            strTxt = strTxt.Replace("        ", " ");
            File.WriteAllText(fileName, strTxt);
        }
        private TreeNode FindNodeByValue(TreeNode tnParent, string strValue)
        {

            if (tnParent == null) return null;

            if (tnParent.Text == strValue) return tnParent;

            TreeNode tnRet = null;

            foreach (TreeNode tn in tnParent.Nodes)
            {

                tnRet = FindNodeByValue(tn, strValue);

                if (tnRet != null) break;

            }

            return tnRet;

        }
        public From1()
        {
            InitializeComponent();
        }
        private void givemeanode(string treenode,string filename)
        {
            TreeNode project = FindNodeByValue(this.treeView1.Nodes[0], treenode);
            System.Windows.Forms.TreeNode treeNode = new System.Windows.Forms.TreeNode(filename);
            project.Nodes.Add(treeNode);
        }
        private void showmegraph(string filename)
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.BringToFront();
            string strTxt = File.ReadAllText(filename);
            strs = strTxt.Split(' ');
            strs = strs.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            //foreach (string i in strs)
            // MessageBox.Show(i);
            for (int i = 0; i < (strs.Length / 5); i++)
            {
                index = this.dataGridView1.Rows.Add();
                string content = strs[5 * i];
                content = content.Remove(content.Length - 1, 1);
                MessageBox.Show(content);
                int num = Convert.ToInt32(content);
                this.dataGridView1.Rows[index].Cells[0].Value = num.ToString("x8");
                this.dataGridView1.Rows[index].Cells[1].Value = strs[5 * i + 1];
                this.dataGridView1.Rows[index].Cells[2].Value = strs[5 * i + 2];
                this.dataGridView1.Rows[index].Cells[3].Value = strs[5 * i + 3];
                this.dataGridView1.Rows[index].Cells[4].Value = strs[5 * i + 4];
            }
        }
        private void runcmd0(string order, string output, string path,string nodename)
        {//命令，输出文件夹名，功能文件夹路径
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = "cmd.exe";
            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口    
            CmdProcess.StartInfo.UseShellExecute = false;       //不启用shell启动进程  
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入    
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出    
            CmdProcess.StartInfo.RedirectStandardError = true;
            CmdProcess.Start();//117.88.62.217 
            CmdProcess.StandardInput.AutoFlush = true;
            //CmdProcess.StartInfo.Arguments = "/c "+"cd "+path+"\n"+ order + " >>" + path + "log.txt";
            CmdProcess.StandardInput.WriteLine("cd "+path);
            CmdProcess.StandardInput.WriteLine(order + " >>" + @".\data\"+ output);
            //也可以用這種方式輸入要執行的命令
            CmdProcess.StandardInput.WriteLine("exit"); 
            string strRst = CmdProcess.StandardOutput.ReadToEnd();
            givemeanode(nodename, output);
            //richTextBox1.Clear();//先clear再显示新的内容
            filesolve2(path + "\\data\\" + output);
            richTextBox1.BringToFront();
            richTextBox1.LoadFile(path + "\\data\\" + output, RichTextBoxStreamType.PlainText); //打开      
            richTextBox1.Show();
            CmdProcess.Close();//结束
            
        }
        private void runcmd1(string order, string output, string path)
        {//命令，输出文件夹名，功能文件夹路径
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = "cmd.exe";
            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口    
            CmdProcess.StartInfo.UseShellExecute = true;       //不启用shell启动进程  
            CmdProcess.StartInfo.RedirectStandardInput = false;  // 重定向输入    
            CmdProcess.StartInfo.RedirectStandardOutput = false; // 重定向标准输出    
            CmdProcess.StartInfo.RedirectStandardError = false;
            CmdProcess.StartInfo.Arguments = IDA_path[0] + ":" + "&&" + "cd " + IDA_path + "&&" + order;
            CmdProcess.Start();//117.88.62.217 
            CmdProcess.StandardInput.WriteLine(IDA_path[0]+":");
            //CmdProcess.StandardInput.AutoFlush = true;
            CmdProcess.StartInfo.Arguments = "/c "+"cd "+path+"\n"+ order + " >>" + path + "log.txt";
            CmdProcess.StandardInput.WriteLine("cd "+ IDA_path);
            CmdProcess.StandardInput.WriteLine(order);
            MessageBox.Show(order);
            //也可以用這種方式輸入要執行的命令
            //CmdProcess.StandardInput.WriteLine("exit");
            CmdProcess.Close();//结束
            File.Copy(path+"\\"+"ans.txt", path+"\\"+output);
            File.WriteAllText(path + "\\" + "ans.txt", "It looks like something wrong.");
            TreeNode project = FindNodeByValue(this.treeView1.Nodes[0], "密码常量检测");
            System.Windows.Forms.TreeNode treeNode = new System.Windows.Forms.TreeNode(output);
            project.Nodes.Add(treeNode);
            filesolve1(path + "\\" + output);
            showmegraph(path + "\\" + output);
            CmdProcess.Close();//结束
        }

        private void runcmd2(string order, string output, string path)
        {//命令，输出文件夹名，功能文件夹路径
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = "cmd.exe";
            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口    
            CmdProcess.StartInfo.UseShellExecute = false;       //不启用shell启动进程  
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入    
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出    
            CmdProcess.StartInfo.RedirectStandardError = true;
            CmdProcess.Start();//117.88.62.217 
            CmdProcess.StandardInput.WriteLine(IDA_path[0] + ":");
            CmdProcess.StandardInput.AutoFlush = true;
            //CmdProcess.StartInfo.Arguments = "/c "+"cd "+path+"\n"+ order + " >>" + path + "log.txt";
            CmdProcess.StandardInput.WriteLine("cd path_密码算法误用静态检测");
            CmdProcess.StandardInput.WriteLine(order);
            MessageBox.Show(order);
            //也可以用這種方式輸入要執行的命令
            CmdProcess.StandardInput.WriteLine("exit");
            CmdProcess.Close();//结束
            File.Copy(path + "\\" + "ans.txt", path + "\\" + output);
            File.WriteAllText(path + "\\" + "ans.txt", "It looks like something wrong.");
            TreeNode project = FindNodeByValue(this.treeView1.Nodes[0], "密码常量检测");
            System.Windows.Forms.TreeNode treeNode = new System.Windows.Forms.TreeNode(output);
            project.Nodes.Add(treeNode);
            filesolve1(path + "\\" + output);
            showmegraph(path + "\\" + output);
            CmdProcess.Close();//结束
        }
        public bool DeleteFile(string path1)
        {
            try
            {
                if (File.Exists(path1))
                {
                    File.Delete(path1);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
            private void givemecmdans(string order, string path, string ipordir ,string contr)
        {
            switch (contr)
            {
                case "Openssh动态检测":
                    {
                        DeleteFile(path + "\\" +"data\\"+ ipordir + "_ssh.txt");
                        runcmd0(order, ipordir + "_ssh.txt", path, "Openssh动态检测");
                        break;
                    }
                case "Openssl动态检测":
                    {
                        DeleteFile(path + "\\" + "data\\" + ipordir + "_ssl.txt");
                        runcmd0(order, ipordir + "_ssl.txt", path, "Openssl动态检测");
                        break;
                    }
                case "Dropbear动态检测":
                    {
                        DeleteFile(path + "\\" + "data\\" + ipordir + "_bear.txt");
                        runcmd0(order, ipordir + "_bear.txt", path, "Dropbear动态检测");
                        break;
                    }
                case "密码常量检测":
                    {
                        string filename = System.IO.Path.GetFileName(ipordir);
                        DeleteFile(path+"\\"+filename);
                        runcmd1(order, filename, path);
                        break;

                    }
                case "密码算法误用静态检测":
                {
                        string filename = System.IO.Path.GetFileName(ipordir);
                        DeleteFile(path + "\\" + filename+"ans.txt");
                        runcmd2(order, filename + "ans.txt", path);
                        break;
                }
                default:
                    {
                        MessageBox.Show("非法控制信息。");
                        break;
                    }
            }
        }
        private void 密码常量检测ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            submit = new Form2("密码常量检测");
            submit.ShowDialog();
            dir = submit.getdir();
    
            string order = "idat.exe -A -c -L\""+ @"C:\Users\cjt\Desktop" + "\\"+"log.txt\""+" -S\""+".\\"+"exp.py" + "\" ";
            if (dir.Length == 0)
                return;
            else
            {
                givemecmdans(order + dir,path_密码常量检测,dir, "密码常量检测");
            }
        }

        private void 密码算法误用静态检测ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //submit = new Form2("密码算法误用静态检测");
            //submit.ShowDialog();
            //dir = submit.getdir();
            //DeleteFile(path_密码算法误用静态检测 + "\\" + "log.txt");
            //string order = "";
            //if (dir.Length == 0)
            //    return;
            //else
            //{
            //    givemecmdans(order + dir, path_密码算法误用静态检测, dir, "密码常量检测");
            //}
            Process ps = new Process();
            ps.StartInfo.FileName = ".\\linkCompileEnv\\linkCompileEnv.bat";
            ps.Start();
        }
        private void Openssh动态检测ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            form3 = new Form3("Openssh动态检测");
            //  form3.Show();
            form3.ShowDialog();
            ip = form3.Getip();
            string order = "Opensshdetect ";
            if (ip.Length ==0)
                return;
            else
                {
                    givemecmdans(order+ip, path_Openssh动态检测,ip, "Openssh动态检测");//这里的输入为1命令，2功能文件夹路径，IP，控制码
                }
        }
        private void Dropbear动态检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            form3 = new Form3("Dropbear动态检测");
            //  form3.Show();
            form3.ShowDialog();
            ip = form3.Getip();
            string order = "Dropbeardetect ";
            if (ip.Length == 0)
                return;
            else
            {
                givemecmdans(order + ip, path_Dropbear动态检测, ip, "Dropbear动态检测");//这里的输入为1命令，2功能文件夹路径，IP，控制码
            }
        }
        private void Openssl动态检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3 = new Form3("Openssl动态检测");
            //  form3.Show();
            form3.ShowDialog();
            ip = form3.Getip();
            string order = "sslscan ";
            if (ip.Length == 0)
                return;
            else
            {
                givemecmdans(order + ip, path_Openssl动态检测, ip, "Openssl动态检测");//这里的输入为1命令，2功能文件夹路径，IP，控制码
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string name = e.Node.Text.ToString();
            if (name == "Openssl动态检测" || name == "密码常量检测" || name == "Openssh动态检测" || name == "密码算法误用静态检测" || name == "密码算法误用检测" || name == "密码算法误用动态检测")
                return;
            else
            {
                if (System.IO.File.Exists(path_Openssh动态检测+@"\data\" + name))
                {
                    richTextBox1.BringToFront();
                    richTextBox1.LoadFile(path_Openssh动态检测 + @"\data\" + name, RichTextBoxStreamType.PlainText); //打开      
                    richTextBox1.Show();
                    return;
                }
                if (System.IO.File.Exists(path_Openssl动态检测 + @"\data\" + name))
                {
                    richTextBox1.BringToFront();
                    richTextBox1.LoadFile(path_Openssl动态检测 + @"\data\" + name, RichTextBoxStreamType.PlainText); //打开      
                    richTextBox1.Show();
                    return;
                }
                if (System.IO.File.Exists(path_Dropbear动态检测 + @"\data\" + name))
                {
                    richTextBox1.BringToFront();
                    richTextBox1.LoadFile(path_Dropbear动态检测 + @"\data\" + name, RichTextBoxStreamType.PlainText); //打开      
                    richTextBox1.Show();
                    return;
                }
                if (System.IO.File.Exists(path_密码常量检测 +"\\"+ name))
                {
                    showmegraph(path_密码常量检测 + "\\" + name); //打开
                    return;
                }
                MessageBox.Show("无此文件");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
