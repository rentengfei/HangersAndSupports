using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace HangersAndSupports.HSData
{
   public class HSModel
    {
        public HSModel(string _name, string _id, bool _isgroup,string _imgurl, string _description,XmlNode _node)
        {
            this.Name = _name;
            this.ID = _id;
            this.IsGroup = _isgroup;
            this.ImgUrl = _imgurl;
            this.Node = _node;
            this.Description = _description;
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

        public string ImgUrl
        {
            get;
            set;
        }
        public XmlNode Node
        {
            get;
            set;
        }
        public bool IsGroup
        {
            get;
            set;
        }
       public string Description
        {
            get;
            set;
        }
    }
}
