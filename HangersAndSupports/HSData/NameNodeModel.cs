using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace HangersAndSupports.HSData
{
   public class NameNodeModel
    {
        public NameNodeModel(string _name, XmlNode _node)
        {
            Name = _name;
            Node = _node;
        }
        public string Name
        {
            get;
            set;
        }
        public XmlNode Node
        {
            get;
            set;
        }
    }
}
