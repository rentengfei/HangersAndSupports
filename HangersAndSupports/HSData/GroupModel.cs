using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangersAndSupports.HSData
{
  public  class GroupModel
    {
        public GroupModel(string _name, string _description, string _imgurl)
        {
            this.Name = _name;
            this.Description = _description;
            this.Imgurl = _imgurl;

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
    }
}
