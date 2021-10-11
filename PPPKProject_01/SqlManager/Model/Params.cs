using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlManager.Model
{
    class Params
    {
        public string Name { get; set; }
        public string Mode { get; set; }
        public string DataType { get; set; }
        public override string ToString() => $"{Name} {Mode} ({DataType})";
    }
}
