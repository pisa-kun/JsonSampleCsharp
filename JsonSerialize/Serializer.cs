using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace JsonSerialize
{
    /// <summary>
    /// シリアライズ関連のクラス
    /// </summary>
    public class Serializer
    {
        /// <summary>
        /// 画像ファイルをBase64エンコードする
        /// </summary>
        /// <param name="inputImagePath"></param>
        /// <returns></returns>
        public string CreateBase64String(string inputImagePath)
        {
            using (var file = new FileStream(inputImagePath, FileMode.Open, FileAccess.Read))
            {
                byte[] bs = new byte[file.Length];
                var readBytes = file.Read(bs, 0, (int)file.Length);

                var base64 = Convert.ToBase64String(bs);
                //Console.WriteLine(base64);
                return base64;
            }
        }
    }
}
