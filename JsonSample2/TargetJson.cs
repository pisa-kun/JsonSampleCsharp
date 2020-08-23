using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSample2
{
    [JsonObject("target")]
    public class TargetJson
    {
        [JsonProperty("happy")]
        public bool Boolean { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pi")]
        public double Number { get; set; }

        [JsonProperty("list")]
        public List<int> List { get; set; }

        [JsonProperty("object")]
        public ObSample ObS { get; set; }
    }

    //    "object": {
    //    "currency": "USD",
    //    "value": 42.99
    //},

    public class ObSample
    {
        [JsonProperty("currency")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
