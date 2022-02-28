using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoilv2.models
{
    public class oil
    {
        public string Name { get; set; }
        public double price { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
