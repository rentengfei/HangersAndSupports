﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangersAndSupports
{
    public  class NameRef
    {
        public NameRef(string _name,int[] _ref) {
            Name = _name;
            Ref = _ref;
        }
      public string Name {
            get;
            set;
        }
        public int[] Ref {
            get;
            set;
        }
    }
}
