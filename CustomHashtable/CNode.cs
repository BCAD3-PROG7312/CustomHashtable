using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHashtable
{
    class CNode
    {
        public CNode(int key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public int key { get; set; }
        public string value { get; set; }

        public override string ToString()
        {
            return "(" + key + " - " + value + ")";
        }
    }
}
