namespace bishe
{
    partial class From1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        
        void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("密码常量检测");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("密码算法误用静态检测");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Openssh动态检测");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Dropbear动态检测");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Openssl动态检测");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("密码算法误用动态检测", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("密码算法误用检测", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode6});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.菜单 = new System.Windows.Forms.MenuStrip();
            this.密码常量检测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码常量检测ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.密码算法误用静态检测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码算法误用静态检测ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.密码算法误用动态检测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Openssh动态检测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dropbear动态检测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Openssl动态检测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.菜单.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // 菜单
            // 
            this.菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.密码常量检测ToolStripMenuItem,
            this.密码算法误用静态检测ToolStripMenuItem,
            this.密码算法误用动态检测ToolStripMenuItem});
            this.菜单.Location = new System.Drawing.Point(0, 0);
            this.菜单.Name = "菜单";
            this.菜单.Size = new System.Drawing.Size(1924, 25);
            this.菜单.TabIndex = 0;
            this.菜单.Text = "menuStrip1";
            // 
            // 密码常量检测ToolStripMenuItem
            // 
            this.密码常量检测ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.密码常量检测ToolStripMenuItem1});
            this.密码常量检测ToolStripMenuItem.Name = "密码常量检测ToolStripMenuItem";
            this.密码常量检测ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.密码常量检测ToolStripMenuItem.Text = "密码常量检测";
            // 
            // 密码常量检测ToolStripMenuItem1
            // 
            this.密码常量检测ToolStripMenuItem1.Name = "密码常量检测ToolStripMenuItem1";
            this.密码常量检测ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.密码常量检测ToolStripMenuItem1.Text = "密码常量检测";
            this.密码常量检测ToolStripMenuItem1.Click += new System.EventHandler(this.密码常量检测ToolStripMenuItem1_Click);
            // 
            // 密码算法误用静态检测ToolStripMenuItem
            // 
            this.密码算法误用静态检测ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.密码算法误用静态检测ToolStripMenuItem1});
            this.密码算法误用静态检测ToolStripMenuItem.Name = "密码算法误用静态检测ToolStripMenuItem";
            this.密码算法误用静态检测ToolStripMenuItem.Size = new System.Drawing.Size(140, 21);
            this.密码算法误用静态检测ToolStripMenuItem.Text = "密码算法误用静态检测";
            // 
            // 密码算法误用静态检测ToolStripMenuItem1
            // 
            this.密码算法误用静态检测ToolStripMenuItem1.Name = "密码算法误用静态检测ToolStripMenuItem1";
            this.密码算法误用静态检测ToolStripMenuItem1.ShowShortcutKeys = false;
            this.密码算法误用静态检测ToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.密码算法误用静态检测ToolStripMenuItem1.Text = "密码算法误用静态检测";
            this.密码算法误用静态检测ToolStripMenuItem1.Click += new System.EventHandler(this.密码算法误用静态检测ToolStripMenuItem1_Click);
            // 
            // 密码算法误用动态检测ToolStripMenuItem
            // 
            this.密码算法误用动态检测ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Openssh动态检测ToolStripMenuItem,
            this.Dropbear动态检测ToolStripMenuItem,
            this.Openssl动态检测ToolStripMenuItem});
            this.密码算法误用动态检测ToolStripMenuItem.Name = "密码算法误用动态检测ToolStripMenuItem";
            this.密码算法误用动态检测ToolStripMenuItem.Size = new System.Drawing.Size(140, 21);
            this.密码算法误用动态检测ToolStripMenuItem.Text = "密码算法误用动态检测";
            // 
            // Openssh动态检测ToolStripMenuItem
            // 
            this.Openssh动态检测ToolStripMenuItem.Name = "Openssh动态检测ToolStripMenuItem";
            this.Openssh动态检测ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.Openssh动态检测ToolStripMenuItem.Text = "Openssh动态检测";
            this.Openssh动态检测ToolStripMenuItem.Click += new System.EventHandler(this.Openssh动态检测ToolStripMenuItem_Click);
            // 
            // Dropbear动态检测ToolStripMenuItem
            // 
            this.Dropbear动态检测ToolStripMenuItem.Name = "Dropbear动态检测ToolStripMenuItem";
            this.Dropbear动态检测ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.Dropbear动态检测ToolStripMenuItem.Text = "Dropbear动态检测";
            this.Dropbear动态检测ToolStripMenuItem.Click += new System.EventHandler(this.Dropbear动态检测ToolStripMenuItem_Click);
            // 
            // Openssl动态检测ToolStripMenuItem
            // 
            this.Openssl动态检测ToolStripMenuItem.Name = "Openssl动态检测ToolStripMenuItem";
            this.Openssl动态检测ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.Openssl动态检测ToolStripMenuItem.Text = "Openssl动态检测";
            this.Openssl动态检测ToolStripMenuItem.Click += new System.EventHandler(this.Openssl动态检测ToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(268, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1619, 957);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.HotTracking = true;
            this.treeView1.ItemHeight = 16;
            this.treeView1.Location = new System.Drawing.Point(33, 44);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点2";
            treeNode1.Text = "密码常量检测";
            treeNode2.Name = "节点3";
            treeNode2.Text = "密码算法误用静态检测";
            treeNode3.Name = "节点5";
            treeNode3.Text = "Openssh动态检测";
            treeNode4.Name = "节点6";
            treeNode4.Text = "Dropbear动态检测";
            treeNode5.Name = "节点7";
            treeNode5.Text = "Openssl动态检测";
            treeNode6.Name = "节点4";
            treeNode6.Text = "密码算法误用动态检测";
            treeNode7.Name = "节点1";
            treeNode7.Text = "密码算法误用检测";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(229, 957);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(268, 44);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1619, 957);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "地址";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "规则文件";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "符合规则";
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "匹配项";
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "匹配字符串";
            this.Column5.Name = "Column5";
            this.Column5.Width = 377;
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1035);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.菜单);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.菜单;
            this.Name = "From1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "密码误用检测";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.From1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.菜单.ResumeLayout(false);
            this.菜单.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.MenuStrip 菜单;
        private System.Windows.Forms.ToolStripMenuItem 密码常量检测ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码算法误用静态检测ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码算法误用动态检测ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码常量检测ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 密码算法误用静态检测ToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem Openssh动态检测ToolStripMenuItem;

        private void From1_Load(object sender, System.EventArgs e)
        {

        }

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem Dropbear动态检测ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Openssl动态检测ToolStripMenuItem;
        protected System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

