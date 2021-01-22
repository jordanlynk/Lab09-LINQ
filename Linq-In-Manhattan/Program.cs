using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace Linq_In_Manhattan
{
    class Program
    {

        public static Example JsonData { get; set; }
        public static void Main()
        {
        }

        public static void GetOurJson()
        {
            string jsonString = File.ReadAllText("../../../../data.json");
            JsonData = JsonConvert.DeserializeObject<Example>(jsonString);
        }
    }
}
