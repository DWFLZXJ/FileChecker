using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace FileChecker.Core
{
    public class LogHelper
    {
        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="strLog"></param>
        public static void WriteLog(List<string> strLog)
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode root = xmlDoc.CreateElement("Exceptions");
            xmlDoc.AppendChild(root);
            foreach (string l in strLog)
            {
                CreateNode(xmlDoc, root, "Exception", l);
            }
            try
            {
                string xmlPath = System.Environment.CurrentDirectory + "\\Logs\\Exception";
                if (!System.IO.Directory.Exists(xmlPath))
                {
                    System.IO.Directory.CreateDirectory(xmlPath);
                }
                xmlPath += "\\Ex_Log_" + DateTime.Now.ToString("yyyyMMddHHmmss.fff") + ".xml";
                xmlDoc.Save(xmlPath);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 记录可疑文件
        /// </summary>
        /// <param name="filesList"></param>
        public static void WriteDangerFilesLog(List<string> filesList)
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode root = xmlDoc.CreateElement("DangerFiles");
            xmlDoc.AppendChild(root);
            foreach (string l in filesList)
            {
                CreateNode(xmlDoc, root, "File", l);
            }
            try
            {
                string xmlPath = System.Environment.CurrentDirectory + "\\Logs\\DangerFiles";
                if (!System.IO.Directory.Exists(xmlPath))
                {
                    System.IO.Directory.CreateDirectory(xmlPath);
                }
                xmlPath += "\\DangerFiles_" + DateTime.Now.ToString("yyyyMMddHHmmss.fff") + ".xml";
                xmlDoc.Save(xmlPath);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>    
        /// 创建节点    
        /// </summary>    
        /// <param name="xmlDoc"></param>  xml文档  
        /// <param name="parentNode"></param>父节点    
        /// <param name="name"></param>  节点名  
        /// <param name="value"></param>  节点值  
        ///   
        private static void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }
    }
}
