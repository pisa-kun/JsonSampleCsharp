using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialize
{
    [DataContract]
    public class SendFormat : ISendFormat
    {
        [DataMember]
        public string ImageBase64 { get; set; }
        [DataMember]
        public double[][] ConvertionTable { get; set; }
        [DataMember]
        public double[] Temparture { get; set; }

        public SendFormat(string img, double[][] table, double[] tmp)
        {
            ImageBase64 = img;
            ConvertionTable = table;
            Temparture = tmp;
        }
    }
}
