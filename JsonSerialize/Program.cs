using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Runtime.Serialization;

namespace JsonSerialize
{
    public class Program
    {
        public static string Base64 { get; set; }
        public double[][] ConvertionTable { get; set; }

        public double[] Teparture { get; set; }
        static void Main(string[] args)
        {
            /// 画像を読み込んで、Base64String変換
            string sampleFile = @"Resource\nao.jpg";

            var Ser = new Serializer();
            Base64 = Ser.CreateBase64String(sampleFile);

            /// テキストファイルから二次元配列に代入
            /// TODO Jsonファイルから読み取り
            var ctable = new double[][] { new double[]{ 1, 2 }, new double[]{ 1, 2 }};

            /// jsonファイルから温度データを取得
            /// TODO sample.jsonから読み込み
            var path = @"Resource\sample.json";
            var body = File.ReadAllText(path);

            /// デシリアライズ
            Temp temp = JsonUtility.Deserialize<Temp>(body);
            foreach (var p in temp.Temparture)
            {
                Console.WriteLine(p);
            }
            var send = new SendFormat(Base64, ctable, temp.Temparture);

            using(var stream = new MemoryStream())
            {
                var serialize = new DataContractJsonSerializer(send.GetType());
                serialize.WriteObject(stream, send);

                stream.Position = 0;
                using(var reader = new StreamReader(stream))
                {
                    //Console.WriteLine(reader.ReadToEnd());
                    using(var writer = new StreamWriter(@"sample.json",false, Encoding.UTF8))
                    {
                        writer.WriteLine(reader.ReadToEnd());
                    }
                }
            }
        }

        [DataContract]
        public class Temp
        {
            [DataMember]
            public double[] Temparture { get; set; }
        }
    }
}
