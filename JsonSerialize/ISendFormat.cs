using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialize
{
    interface ISendFormat
    {
        /// <summary>
        /// Base64に圧縮した画像ファイル
        /// </summary>
        string ImageBase64 { get; set; }

        /// <summary>
        /// 変換テーブル
        /// </summary>
        double[][] ConvertionTable { get; set; }

        /// <summary>
        /// 温度
        /// </summary>
        double[] Temparture { get; set; }
    }
}
