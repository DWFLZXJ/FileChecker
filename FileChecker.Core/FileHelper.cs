using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FileChecker.Core
{
    public class FileHelper
    {
        static List<FileInformation> FileList = new List<FileInformation>();
        public static List<FileInformation> GetAllFiles(string dirPath)
        {
            DirectoryInfo dir = new System.IO.DirectoryInfo(dirPath);
            if (dir.Exists)
            {

                FileInfo[] allFile = dir.GetFiles();
                foreach (FileInfo fi in allFile)
                {                     
                        FileList.Add(new FileInformation { FileName = fi.Name, FilePath = fi.FullName });
                }
                DirectoryInfo[] allDir = dir.GetDirectories();
                foreach (DirectoryInfo d in allDir)
                {
                    GetAllFiles(d.FullName);
                }
            }
            return FileList;
        }


        //返回不存在的文件目录列表
        public static List<FileInformation> CompareAllFiles(List<string> listfilefullpath)
        {
            try
            {
                foreach (String strfullpath in listfilefullpath)
                {
                    if (!System.IO.File.Exists(strfullpath))
                    {
                        FileList.Add(new FileInformation { FileName = strfullpath, FilePath = strfullpath });
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        
            return FileList;
        }

        public static string ReadFileContent(string filePath)
        {
            string contents = System.IO.File.ReadAllText(filePath, System.Text.Encoding.GetEncoding("gb2312"));
            return contents;//.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", ""); ;
        }






    }
    public class FileInformation
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }  
}
