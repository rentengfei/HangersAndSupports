using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace HangersAndSupports.HSData
{
   public class CTypeModel
    {

        public CTypeModel(string _name,string _description,string _imgurl,XmlNode _node) {
            this.Name = _name;
            this.Description = _description;
            this.Imgurl = _imgurl;
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
        public string Imgurl
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
