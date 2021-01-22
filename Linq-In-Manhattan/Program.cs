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
            GetOurJson();
            OutputAllContent();
        }

        public static void GetOurJson()
        {
            string jsonString = File.ReadAllText("../../../data.json");
            JsonData = JsonConvert.DeserializeObject<Example>(jsonString);
        }

        public static void OutputAllContent()
        {
            foreach (var item in JsonData.features)
            {
                Console.WriteLine($"Total is: {JsonData.features.Count()}");
                Console.ReadLine();
            }
        }
        public static IEnumerable<Features> FilterNoNameNeighborhoods(Example data)
        {
            IEnumerable<Features> filteredData = data.features.Where(x => x.properties.neighborhood != "");
            foreach (var item in filteredData)
            {
                Console.WriteLine(item.properties.neighborhood);
            }
            Console.WriteLine($"Total: {filteredData.Count()}");
            Console.ReadLine();
            return filteredData;
        }
    }
}
