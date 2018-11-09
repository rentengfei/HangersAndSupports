using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangersAndSupports
{
    public class HSModel
    {
        public HSModel(string _name, string _id, string _ref) {
            Name = _name;
            ID = _id;
            Ref = _ref;
        }
        string Name {
            get;
            set;
        }
        string ID {
            get;
            set;
        }
        string Ref {
            get;
            set;
        }
            
    }
}
