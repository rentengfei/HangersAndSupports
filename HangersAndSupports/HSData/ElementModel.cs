using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace HangersAndSupports.HSData
{
   public class ElementModel
    {
        public ElementModel(string _name,string _id, string _description,string _ref,XmlNode _node)
        {
            this.Name = _name;
            this.ID = _id;
            this.Description = _description;
            this.Ref = _ref;
            this.Node = _node;

        }
        public string Name
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string Ref
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
