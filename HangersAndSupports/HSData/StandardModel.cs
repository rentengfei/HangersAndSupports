using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace HangersAndSupports.HSData
{
   public class StandardModel
    {
        public StandardModel(string _name, string _description,XmlNode _node)
        {
            this.Name = _name;
            this.Description = _description;
            this.Node = _node;

        }
        public string Name
        {
            get;
            set;
        }
        public string Description
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
