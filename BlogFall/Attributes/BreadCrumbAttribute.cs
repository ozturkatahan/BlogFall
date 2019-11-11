using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogFall.Attributes
{
    public class BreadCrumbAttribute : Attribute
    {
        public string Name { get; set; }

        public BreadCrumbAttribute(string name)
        {
            Name = name;
        }
    }
}