using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TargetJson()
            {
                Boolean = true,
                Name = "arisugawa",
                Number = 3.14,
                List = new List<int> { 3, 3, 4 },
                ObS = new ObSample()
                {
                    Name = "USB",
                    Value = 33.45,
                },
            };

            // 第二引数でインデントをつけれる
            string j = Newtonsoft.Json.JsonConvert.SerializeObject(t, Newtonsoft.Json.Formatting.Indented);
            // file書き込み
            File.WriteAllText(@"write.json", j);
            Console.WriteLine(j);


            // デシリアライズ
            // TargetJsonのObSampleにアクセス
            var s = Newtonsoft.Json.JsonConvert.DeserializeObject<TargetJson>(j);
            Console.WriteLine(s.ObS.Name);
            Console.WriteLine($"watashi wa {s.Name} Natsuha!");

            Console.ReadLine();
        }
    }
}
