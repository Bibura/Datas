using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLaba
{
    public class Region
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Region() { }
        public Region(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
