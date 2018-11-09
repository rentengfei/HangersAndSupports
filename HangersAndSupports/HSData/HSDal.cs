using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace HangersAndSupports.HSData
{
   public class HSDal
    {
        string XmlPath = @"C:\AVEVA\Plant\PDMS12.1.SP4\HS.xml";
        public HSDal() {

        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <returns></returns>
        public List<StandardModel> GetStandardList() {
            XmlHelper xmlHelper = new XmlHelper();
            System.Xml.XmlNodeList list = xmlHelper.GetXmlNodeListByXpath(XmlPath, "//standards//standard");
            List<StandardModel> modellist = new List<StandardModel>();
            foreach (System.Xml.XmlNode node in list)
            {
                string name = node.Attributes["name"] != null ? node.Attributes["name"].Value : "";
                string description = node.Attributes["description"] != null ? node.Attributes["description"].Value : "";

                modellist.Add(new StandardModel(name, description, node));
            }
            return modellist;
        }
        /// <summary>
        /// 根据标准获取分类列表
        /// </summary>
        /// <returns></returns>
        public List<TypeModel> GetTypeListByStandard(XmlNode node)
        {
            XmlHelper xmlHelper = new XmlHelper();
            System.Xml.XmlNodeList list = xmlHelper.GetXmlNodeListByXmlNode("types/type", node);
            List<TypeModel> modellist = new List<TypeModel>();
            foreach (System.Xml.XmlNode n in list)
            {
                string name = n.Attributes["name"] != null ? n.Attributes["name"].Value : "";
                string description = n.Attributes["description"] != null ? n.Attributes["description"].Value : "";
                modellist.Add(new TypeModel(name, description, n));
            }
            return modellist;
        }
        /// <summary>
        /// 根据分类获取支吊架图列表
        /// </summary>
        /// <returns></returns>
        public List<CTypeModel> GetCTypeListByType(XmlNode node)
        {
            XmlHelper xmlHelper = new XmlHelper();
            System.Xml.XmlNodeList list = xmlHelper.GetXmlNodeListByXmlNode("ctype", node);
            List<CTypeModel> modellist = new List<CTypeModel>();
            foreach (System.Xml.XmlNode n in list)
            {
                string name = n.Attributes["name"] != null ? n.Attributes["name"].Value : "";
                string description = n.Attributes["description"] != null ? n.Attributes["description"].Value : "";
                string imgurl = n.Attributes["imgurl"] != null ? n.Attributes["imgurl"].Value : "";
                modellist.Add(new CTypeModel(name, description, imgurl, n));
            }
            return modellist;
        }
        /// <summary>
        /// 根据分类获取支吊架图列表
        /// </summary>
        /// <returns></returns>
        public List<HSModel> GetHSListByType(XmlNode node)
        {
            XmlHelper xmlHelper = new XmlHelper();
            System.Xml.XmlNodeList list = xmlHelper.GetXmlNodeListByXmlNode("ctype/HS", node);
            List<HSModel> modellist = new List<HSModel>();
            foreach (System.Xml.XmlNode n in list)
            {
                string name = n.Attributes["name"] != null ? n.Attributes["name"].Value : "";
                string id = n.Attributes["id"] != null ? n.Attributes["id"].Value : "";
                bool isgroup = n.Attributes["isgroup"] != null ? Convert.ToBoolean(n.Attributes["isgroup"].Value) : false;
                string description = n.Attributes["description"] != null ? n.Attributes["description"].Value : "";
                string imgurl = n.Attributes["imgurl"] != null ? n.Attributes["imgurl"].Value : "";
                modellist.Add(new HSModel(name,id, isgroup, description, imgurl, n));
            }
            return modellist;
        }
        /// <summary>
        /// 根据支吊架图获取等级库列表
        /// </summary>
        /// <returns></returns>
        public List<ElementModel> GetElementByHS(XmlNode node)
        {
            XmlHelper xmlHelper = new XmlHelper();
            System.Xml.XmlNodeList list = xmlHelper.GetXmlNodeListByXmlNode("Current/element", node);
            List<ElementModel> modellist = new List<ElementModel>();
            foreach (System.Xml.XmlNode n in list)
            {
                string name = n.Attributes["name"] != null ? n.Attributes["name"].Value : "";
                string id = n.Attributes["id"] != null ? n.Attributes["id"].Value : "";
                string description = n.Attributes["description"] != null ? n.Attributes["description"].Value : "";
                modellist.Add(new ElementModel(name, id, description, n.Value, n));
            }
            return modellist;
        }
        /// <summary>
        /// 根据支吊架图获取组合等级库列表
        /// </summary>
        /// <returns></returns>
        public List<ElementModel> GetRefByHS(XmlNode node)
        {
            XmlHelper xmlHelper = new XmlHelper();
            XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(XmlPath); //加载XML文档
            
                System.Xml.XmlNodeList list = xmlHelper.GetXmlNodeListByXmlNode("group/ref", node);
            List<ElementModel> modellist = new List<ElementModel>();

            foreach (System.Xml.XmlNode n in list)
            {
                XmlElement e = xmldoc.GetElementById(n.Value);
                string name = e.Attributes["name"] != null ? e.Attributes["name"].Value : "";
                string id = e.Attributes["id"] != null ? e.Attributes["id"].Value : "";
                string description = e.Attributes["description"] != null ? e.Attributes["description"].Value : "";
                modellist.Add(new ElementModel(name,id, description, e.Value, e));
            }
            return modellist;
        }
    }
}
