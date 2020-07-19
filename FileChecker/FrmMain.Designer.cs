namespace FileChecker
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCheckingFilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDangerFileCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.导出结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartCheck = new System.Windows.Forms.Button();
            this.txtHandSelectPath = new System.Windows.Forms.TextBox();
            this.tabWaitScanFolder = new System.Windows.Forms.TabPage();
            this.lstWaitScanFolder = new System.Windows.Forms.ListBox();
            this.tabAllFiles = new System.Windows.Forms.TabPage();
            this.lstAllFiles = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabWaitScanFolder.SuspendLayout();
            this.tabAllFiles.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCurrentProgress,
            this.toolStripStatusLabel2,
            this.lblCheckingFilePath,
            this.toolStripStatusLabel3,
            this.lblDangerFileCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(709, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(169, 17);
            this.toolStripStatusLabel1.Text = "有问题请联系：18962234776";
            // 
            // lblCurrentProgress
            // 
            this.lblCurrentProgress.Name = "lblCurrentProgress";
            this.lblCurrentProgress.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // lblCheckingFilePath
            // 
            this.lblCheckingFilePath.Name = "lblCheckingFilePath";
            this.lblCheckingFilePath.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // lblDangerFileCount
            // 
            this.lblDangerFileCount.Name = "lblDangerFileCount";
            this.lblDangerFileCount.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 477);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip2;
            this.tabControl1.Controls.Add(this.tpSetting);
            this.tabControl1.Controls.Add(this.tabWaitScanFolder);
            this.tabControl1.Controls.Add(this.tabAllFiles);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 471);
            this.tabControl1.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出结果ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 26);
            // 
            // 导出结果ToolStripMenuItem
            // 
            this.导出结果ToolStripMenuItem.Name = "导出结果ToolStripMenuItem";
            this.导出结果ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.导出结果ToolStripMenuItem.Text = "导出";
            this.导出结果ToolStripMenuItem.Click += new System.EventHandler(this.导出结果ToolStripMenuItem_Click);
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.label2);
            this.tpSetting.Controls.Add(this.label1);
            this.tpSetting.Controls.Add(this.progressBar1);
            this.tpSetting.Controls.Add(this.groupBox3);
            this.tpSetting.Location = new System.Drawing.Point(4, 22);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetting.Size = new System.Drawing.Size(695, 445);
            this.tpSetting.TabIndex = 0;
            this.tpSetting.Text = "设置";
            this.tpSetting.UseVisualStyleBackColor = true;
            this.tpSetting.Click += new System.EventHandler(this.tpSetting_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件拷贝进度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(8, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 95);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 260);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(683, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnStartCheck);
            this.groupBox3.Controls.Add(this.txtHandSelectPath);
            this.groupBox3.Location = new System.Drawing.Point(6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 211);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "手动选择扫描目录";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(601, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "一键拷贝";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(601, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "进行比对";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStartCheck
            // 
            this.btnStartCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartCheck.Location = new System.Drawing.Point(601, 20);
            this.btnStartCheck.Name = "btnStartCheck";
            this.btnStartCheck.Size = new System.Drawing.Size(76, 23);
            this.btnStartCheck.TabIndex = 2;
            this.btnStartCheck.Text = "开始扫描";
            this.btnStartCheck.UseVisualStyleBackColor = true;
            this.btnStartCheck.Click += new System.EventHandler(this.btnStartCheck_Click);
            // 
            // txtHandSelectPath
            // 
            this.txtHandSelectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHandSelectPath.Location = new System.Drawing.Point(6, 14);
            this.txtHandSelectPath.Multiline = true;
            this.txtHandSelectPath.Name = "txtHandSelectPath";
            this.txtHandSelectPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHandSelectPath.Size = new System.Drawing.Size(589, 191);
            this.txtHandSelectPath.TabIndex = 0;
            this.txtHandSelectPath.DoubleClick += new System.EventHandler(this.txtHandSelectPath_DoubleClick);
            // 
            // tabWaitScanFolder
            // 
            this.tabWaitScanFolder.Controls.Add(this.lstWaitScanFolder);
            this.tabWaitScanFolder.Location = new System.Drawing.Point(4, 22);
            this.tabWaitScanFolder.Name = "tabWaitScanFolder";
            this.tabWaitScanFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tabWaitScanFolder.Size = new System.Drawing.Size(695, 445);
            this.tabWaitScanFolder.TabIndex = 1;
            this.tabWaitScanFolder.Text = "虚拟目录";
            this.tabWaitScanFolder.UseVisualStyleBackColor = true;
            // 
            // lstWaitScanFolder
            // 
            this.lstWaitScanFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWaitScanFolder.ContextMenuStrip = this.contextMenuStrip2;
            this.lstWaitScanFolder.FormattingEnabled = true;
            this.lstWaitScanFolder.ItemHeight = 12;
            this.lstWaitScanFolder.Location = new System.Drawing.Point(5, 4);
            this.lstWaitScanFolder.Name = "lstWaitScanFolder";
            this.lstWaitScanFolder.Size = new System.Drawing.Size(686, 436);
            this.lstWaitScanFolder.TabIndex = 0;
            // 
            // tabAllFiles
            // 
            this.tabAllFiles.Controls.Add(this.lstAllFiles);
            this.tabAllFiles.Location = new System.Drawing.Point(4, 22);
            this.tabAllFiles.Name = "tabAllFiles";
            this.tabAllFiles.Size = new System.Drawing.Size(695, 445);
            this.tabAllFiles.TabIndex = 4;
            this.tabAllFiles.Text = "结果集";
            this.tabAllFiles.UseVisualStyleBackColor = true;
            // 
            // lstAllFiles
            // 
            this.lstAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAllFiles.FormattingEnabled = true;
            this.lstAllFiles.ItemHeight = 12;
            this.lstAllFiles.Location = new System.Drawing.Point(5, 4);
            this.lstAllFiles.Name = "lstAllFiles";
            this.lstAllFiles.Size = new System.Drawing.Size(684, 436);
            this.lstAllFiles.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除选中ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 删除选中ToolStripMenuItem
            // 
            this.删除选中ToolStripMenuItem.Name = "删除选中ToolStripMenuItem";
            this.删除选中ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除选中ToolStripMenuItem.Text = "删除选中";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(709, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件迁移遗漏扫描工具1.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            this.tpSetting.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabWaitScanFolder.ResumeLayout(false);
            this.tabAllFiles.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentProgress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblCheckingFilePath;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblDangerFileCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除选中ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 导出结果ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStartCheck;
        private System.Windows.Forms.TextBox txtHandSelectPath;
        private System.Windows.Forms.TabPage tabWaitScanFolder;
        private System.Windows.Forms.ListBox lstWaitScanFolder;
        private System.Windows.Forms.TabPage tabAllFiles;
        private System.Windows.Forms.ListBox lstAllFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

