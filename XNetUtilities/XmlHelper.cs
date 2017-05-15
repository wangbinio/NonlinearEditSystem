using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using Common;

namespace XNetUtilities
{
    /// <summary>
    /// 类说明：Xml操作类
    /// 日期：2017-04-25
    /// 作者：szwb
    /// 修改：
    /// </summary>
    public class XmlHelper
    {
        #region 字段

        /// <summary>
        /// XML文件的物理路径
        /// </summary>
        private string _filePath = string.Empty;

        /// <summary>
        /// 是否已经创建了XML根节点
        /// </summary>
        private bool _bCreatedElememt = false;

        /// <summary>
        /// XML文档
        /// </summary>
        private XmlDocument _xmlDocument;

        /// <summary>
        /// XML的根节点
        /// </summary>
        private XmlElement _xmlElement;

        #endregion 字段

        #region 构造

        /// <summary>
        /// 实例化XmlHelper对象
        /// </summary>
        /// <param name="xmlFilePath">Xml文件的相对/绝对路径</param>
        /// <param name="bAbsPath">是否是绝对路径</param>
        public XmlHelper(string xmlFilePath, bool bAbsPath = false)
        {
            if (bAbsPath)
            {
                _filePath = xmlFilePath;
            }
            else
            {
                // 获取XML文件的绝对路径
                _filePath = HttpContext.Current.Server.MapPath(xmlFilePath);
            }
        }

        #endregion 构造

        /// <summary>
        /// 创建XML的根节点
        /// </summary>
        private void CreateXmlElement()
        {
            try
            {
                if (!_bCreatedElememt)
                {
                    // 创建一个XML对象
                    _xmlDocument = new XmlDocument();

                    if (File.Exists(_filePath))
                    {
                        // 加载XML文件
                        _xmlDocument.Load(_filePath);

                        // 为XML的根节点赋值
                        _xmlElement = _xmlDocument.DocumentElement;

                        _bCreatedElememt = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
          
        }

        /// <summary>
        /// 返回指定的xPath表达式节点对象
        /// </summary>
        /// <param name="xPath"></param>
        /// 范例1: @"Skill/First/SkillItem", 等效于 @"//Skill/First/SkillItem"
        /// 范例2: @"Table[USERNAME='a']" , []表示筛选,USERNAME是Table下的一个子节点.
        /// 范例3: @"ApplyPost/Item[@itemName='岗位编号']",@itemName是Item节点的属性.
        /// <returns></returns>
        public XmlNode GetNode(string xPath)
        {
            try
            {
                // 创建XML根节点
                CreateXmlElement();

                // 返回xPath节点
                return _xmlElement.SelectSingleNode(xPath);
            }
            catch (System.Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

            return null;
        }

        /// <summary>
        /// 返回指定xPath表达式节点的值
        /// </summary>
        /// <param name="xPath"></param>
        /// <returns></returns>
        public string GetValue(string xPath)
        {
            try
            {
                // 创建XML根节点
                CreateXmlElement();

                // 返回xPath节点的值
                return _xmlElement.SelectSingleNode(xPath)?.InnerText;
            }
            catch (System.Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

            return null;
        }

        /// <summary>
        /// 返回指定xPath表达式节点的属性值
        /// </summary>
        /// <param name="xPath"></param>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public string GetAttributeValue(string xPath, string attributeName)
        {
            try
            {
                // 创建XML的根节点
                CreateXmlElement();

                // 返回xPath节点的属性值
                return _xmlElement.SelectSingleNode(xPath)?.Attributes?[attributeName].Value;
            }
            catch (System.Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

            return null;
        }

        /// <summary>
        /// 1.功能：新增节点
        /// 2.使用条件：将任意节点插入到当前Xml文件中
        /// </summary>
        /// <param name="xmlNode"></param>
        public void AppendNode(XmlNode xmlNode)
        {
            // 创建XML的根节点
            CreateXmlElement();

            // 导入节点
            XmlNode node = _xmlDocument.ImportNode(xmlNode, true);

            // 将节点插入到根节点下
            _xmlElement.AppendChild(node);
        }

        /// <summary>
        /// 删除指定xPath表达式的节点
        /// </summary>
        /// <param name="xPath"></param>
        public void RemoveNode(string xPath)
        {
            // 创建XML的根节点
            CreateXmlElement();

            // 获取要删除的节点
            XmlNode node = _xmlDocument.SelectSingleNode(xPath);

            // 删除节点
            if (node != null) _xmlElement.RemoveChild(node);
        }

        /// <summary>
        /// 保存XML文件
        /// </summary>
        public void Save()
        {
            // 创建XML的根节点
            CreateXmlElement();

            // 保存XML文件
            _xmlDocument.Save(_filePath);
        }

        public static XmlElement CreateRootElement(string xmlFilePath)
        {
            try
            {
                // 定义变量，表示XML文件的绝对路径
                string filePath = "";

                filePath = HttpContext.Current.Server.MapPath(xmlFilePath);

                // 创建XmlDocument
                XmlDocument xmlDocument = new XmlDocument();

                // 加载XML文件
                if (filePath != null) xmlDocument.Load(filePath);

                // 返回根节点
                return xmlDocument.DocumentElement;
            }
            catch (System.Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

            return null;
        }

        /// <summary>
        /// 获取指定xPath表达式节点的值
        /// </summary>
        /// <param name="xmlFilePath"></param>
        /// <param name="xPath"></param>
        /// <returns></returns>
        public static string GetValue(string xmlFilePath, string xPath)
        {
            try
            {
                // 创建根对象
                XmlElement rootElement = CreateRootElement(xmlFilePath);

                // 返回xPath节点的值
                return rootElement.SelectSingleNode(xPath)?.InnerText;
            }
            catch (System.Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

            return null;
        }

        /// <summary>
        /// 获取指定xPath表达式节点的属性值
        /// </summary>
        /// <param name="xmlFilePath"></param>
        /// <param name="xPath"></param>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public static string GetAttributeValue(string xmlFilePath, string xPath, string attributeName)
        {
            try
            {
                // 创建根对象
                XmlElement rootElement = CreateRootElement(xmlFilePath);

                // 返回xPath节点的属性值
                return rootElement.SelectSingleNode(xPath)?.Attributes?[attributeName].Value;
            }
            catch (System.Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

            return null;
        }
    }
}
