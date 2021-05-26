using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SimpleReaderTools.Utilities
{
    public class XMLOperations
    {
        public static string GetXmlString(string xml, bool isFormat)
        {
            var doc = GetXmlDoc(xml);
            return GetXmlFormatString(doc, isFormat);
        }

        public static string GetOrderedNodesXmlString(string xml, bool isFormat)
        {
            var doc = GetXmlDoc(xml);
            var list = SortXmlNodes(doc.ChildNodes);
            foreach (var nd in list)
            {
                doc.AppendChild(nd);
            }

            return GetXmlFormatString(doc, isFormat);
        }

        private static List<XmlNode> SortXmlNodes(XmlNodeList nodeList)
        {
            List<XmlNode> nodes = new List<XmlNode>();
            var list = nodeList.OfType<XmlNode>().OrderBy(x => x.Name);
            foreach (var node in list)
            {
                if (node.HasChildNodes)
                {
                    var childList = SortXmlNodes(node.ChildNodes);
                    foreach (var cnodel in childList)
                    {
                        node.AppendChild(cnodel);
                    }
                }
                nodes.Add(node);
            }
            return nodes;
        }

        private static XmlDocument GetXmlDoc(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            return doc;
        }
        private static string GetXmlFormatString(XmlDocument doc, bool isFormat)
        {
            string result = "";
            using (System.IO.StringWriter sw = new System.IO.StringWriter())
            {
                using (XmlTextWriter writer = new XmlTextWriter(sw)
                { Formatting = isFormat ? Formatting.Indented : Formatting.None })
                {
                    doc.Save(writer);
                    writer.Flush();
                    sw.Flush();
                    result = sw.ToString();
                }
            }
            return result;
        }
    }
}
