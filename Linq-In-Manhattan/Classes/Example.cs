using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Linq_In_Manhattan.Classes
{
    class Example
    {
        public string type { get; set; }
        public IEnumerable<Features> features { get; set; }
    }
}
