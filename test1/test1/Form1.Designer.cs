namespace test1
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("添加管理员信息");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("修改管理员信息");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("管理员信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode69,
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("退出系统");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("系统管理", new System.Windows.Forms.TreeNode[] {
            treeNode71,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("开设课程");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("查询课程");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("课程管理", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("录入成绩");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("统计成绩");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("修改成绩");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("成绩管理", new System.Windows.Forms.TreeNode[] {
            treeNode77,
            treeNode78,
            treeNode79});
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("添加学生信息");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("修改学生信息");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("学生信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode81,
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("修改密码");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("关于");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.LineColor = System.Drawing.Color.LightGray;
            this.treeView1.Location = new System.Drawing.Point(5, 16);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode69.Name = "addMan";
            treeNode69.Text = "添加管理员信息";
            treeNode70.Name = "modifyMan";
            treeNode70.Text = "修改管理员信息";
            treeNode71.Name = "manMan";
            treeNode71.Text = "管理员信息管理";
            treeNode72.Name = "节点0";
            treeNode72.Text = "退出系统";
            treeNode73.Name = "userInfo";
            treeNode73.SelectedImageIndex = 2;
            treeNode73.Text = "系统管理";
            treeNode74.Name = "addCL";
            treeNode74.Text = "开设课程";
            treeNode75.Name = "searchCL";
            treeNode75.Text = "查询课程";
            treeNode76.Name = "classMan";
            treeNode76.Text = "课程管理";
            treeNode77.Checked = true;
            treeNode77.Name = "luruCJ";
            treeNode77.NodeFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode77.Text = "录入成绩";
            treeNode78.Name = "tongjiCJ";
            treeNode78.Text = "统计成绩";
            treeNode79.Name = "节点0";
            treeNode79.Text = "修改成绩";
            treeNode80.Name = "chengjiMan";
            treeNode80.Text = "成绩管理";
            treeNode81.Name = "addStu";
            treeNode81.Text = "添加学生信息";
            treeNode82.Name = "modifyStu";
            treeNode82.Text = "修改学生信息";
            treeNode83.Name = "studentMan";
            treeNode83.Text = "学生信息管理";
            treeNode84.Name = "节点0";
            treeNode84.Text = "修改密码";
            treeNode85.Name = "about";
            treeNode85.Text = "关于";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode76,
            treeNode80,
            treeNode83,
            treeNode84,
            treeNode85});
            this.treeView1.Size = new System.Drawing.Size(221, 648);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::test1.Properties.Resources.opwavhv01ra;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(248, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 648);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 666);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1238, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 691);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生综合教务系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}

