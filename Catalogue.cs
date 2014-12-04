﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpQuant.ObjectStore
{
    public class Catalogue : ICatalogue
    {
        public string CODE { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IDictionary<string,string> Tags {get;set;}
    }

    public interface ICatalogue
    {
        string CODE { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        IDictionary<string, string> Tags { get; set; }
    }

}
