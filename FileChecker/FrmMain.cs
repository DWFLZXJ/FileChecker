using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using FileChecker.Core;

namespace FileChecker
{
    using HtmlAgilityPack;
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnStartCheck_Click(object sender, EventArgs e)
        {
            lstWaitScanFolder.Items.Clear();
            lstAllFiles.Items.Clear();
         
            //优先扫描手动选择目录
            if (this.txtHandSelectPath.Text != "")
            {
                string[] paths = this.txtHandSelectPath.Text.Split(';');
                foreach (string path in paths)
                {
                    lstWaitScanFolder.Items.Add(path.Trim(new char[] { '\r', '\n' }));
                }
            }
         
          

            Thread th = new Thread(GetAllFiles);
            th.Start();
        }

        public void GetAllFiles()
        {
            List<string> errList = new List<string>();
            int totalCount = lstWaitScanFolder.Items.Count;
            int i = 0;
            try { 
            foreach (string item in lstWaitScanFolder.Items)
            {
                i++;
                lblCurrentProgress.Text = string.Format("正在读取第 {0} 个虚拟目录内的文件,共 {1} 个", i, totalCount);
                lblCheckingFilePath.Text = item;
                //获取所有待扫描文件
                List<FileChecker.Core.FileInformation> fileInfos = FileChecker.Core.FileHelper.GetAllFiles(item);
                foreach ( FileInformation fileInfo in fileInfos)
                {
                    lstAllFiles.Items.Add(fileInfo.FilePath);
                }
            }
                }
                catch (Exception ex)
                {
                    errList.Add( " 检测失败，原因：" + ex + "\r\n发生时间：" + DateTime.Now + "\r\n");
                }

             //读取文件内容 
            totalCount = lstAllFiles.Items.Count;
            toolStripStatusLabel1.Text = "共需扫描文件" + Convert.ToString(totalCount) + "个。";
            lblCurrentProgress.Text = "";
            i = 0;
            
      
            //扫描完成
            lblCurrentProgress.Text = "扫描完成";
            toolStripStatusLabel2.Text = string.Format("共扫描文件：{0} 个", lstAllFiles.Items.Count);
            lblCheckingFilePath.Text = string.Format("其中成功：{1} 个，失败：{0} 个", errList.Count,
                lstAllFiles.Items.Count - errList.Count);
            if (errList.Count > 0)
            {
                //记录失败日志
                FileChecker.Core.LogHelper.WriteLog(errList);
            }
            

        }

      

        

        string _defaultfilePath = "";
        private void txtHandSelectPath_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = false
            };
            if (_defaultfilePath != "")
            {
                //设置此次默认目录为上一次选中目录  
                fbd.SelectedPath = _defaultfilePath;
            }

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录  
                _defaultfilePath = fbd.SelectedPath;
                this.txtHandSelectPath.Text += string.Format("{0};\r\n", _defaultfilePath);
            }
        }

        private void lstDangerFiles_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void 导出结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = @"(*.txt)|*.txt|(*.*)|*.*",
                AddExtension = true,
                RestoreDirectory = true
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                try
                {
                    string str = "";
                    switch (tabControl1.SelectedTab.Text)
                    {
                        case "虚拟目录":
                            str = this.lstWaitScanFolder.Items.Cast<string>()
                                .Aggregate("", (current, item) => current + (item + ";\r\n"));
                            break;
                        case "结果集":
                            str = this.lstAllFiles.Items.Cast<string>()
                                .Aggregate("", (current, item) => current + (item + ";\r\n"));
                            break;
                       
                        default:
                            break;
                    }
                    sw.Write(str);
                    sw.Flush();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Close();
                    fs.Close();
                }
            }
        }

        //进行比对
        private void button1_Click(object sender, EventArgs e)
        {
           

            lstAllFiles.Items.Clear();
            //从输入路径读取文本
            List<string> errList = new List<string>();
            List<string> listfilefullpath= new List<string>();
            foreach (string str in System.IO.File.ReadAllLines(this.txtHandSelectPath.Text, Encoding.Default))
            {
                listfilefullpath.Add(str);
            }

            try
            {

                List<string> listfileInfos = new List<string>();

                foreach (string strfullpath in listfilefullpath)
                {
                    if (!System.IO.File.Exists(strfullpath.Replace(";","")))
                    {
                        listfileInfos.Add(strfullpath);
                    }
                }

                foreach (string fileInfo in listfileInfos)
                {
                    lstAllFiles.Items.Add(fileInfo);
                }
            }
            catch (Exception ex)
            {
                errList.Add(" 检测失败，原因：" + ex + "\r\n发生时间：" + DateTime.Now + "\r\n");
            }
            if (errList.Count > 0)
            {
                //记录失败日志
                FileChecker.Core.LogHelper.WriteLog(errList);
            }

        }

        private void lstDangerFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> listfilefullpath = new List<string>();
            foreach (string str in System.IO.File.ReadAllLines(this.txtHandSelectPath.Text, Encoding.UTF8))
            {
                listfilefullpath.Add(str.Replace(";",""));
            }
            CopyFileToDir(listfilefullpath, "D:\\queshi\\");
        }


        /// <summary>
        /// 复制文件到指定目录并重命名
        /// </summary>
        /// <param name="sourcePaths">要复制的文件路径集合</param>
        /// <param name="targetDir">目标目录</param>
        /// <returns>Item1:对应路径，Item2:失败文件路径</returns>
        public  Tuple<Dictionary<string, string>, List<string>> CopyFileToDir(List<string> sourcePaths, string targetDir)
        {
            int totalcount = sourcePaths.Count;
            progressBar1.Maximum= sourcePaths.Count;
            progressBar1.Step = 1;
            int i = 0;

            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }
            var errorFiles = new List<string>();
            var saveDirs = new Dictionary<string, string>();
            sourcePaths.ForEach(item =>
            {
                i++;
                //路径不存在或者路径已存在则失败
                if (!File.Exists(item) || saveDirs.ContainsKey(item))
                {
                    errorFiles.Add(item);
                }
                else
                {
                    
                    string savePath = targetDir+ item.Substring(3);
                    string savePathdir = savePath.Remove(savePath.LastIndexOf("\\"));
                    if (!Directory.Exists(savePathdir))
                    {
                        Directory.CreateDirectory(savePathdir);
                    }
                    File.Copy(item, savePath);
                    saveDirs.Add(item, savePath);
                    progressBar1.Value = i;
                }
            });
            var result = new Tuple<Dictionary<string, string>, List<string>>(saveDirs, errorFiles);
            return result;
        }

        private void tpSetting_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
