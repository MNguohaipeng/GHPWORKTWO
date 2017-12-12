using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public class ErrorCommon
    {

        /// <summary>
        /// 创建错误字符串
        /// </summary>
        /// <param name="Message">错误信息</param>
        /// <param name="NumForRows">行数</param>
        /// <param name="Url">地址</param>
        /// <returns>错误字符串</returns>
        public static string CreateErrorString(string Message,string NumForRows,string Url) {

            string Txt = "";


            Txt += "------------------------------"+DateTime.Now+ "------------------------------\r\n";
            Txt += "错误信息：" + Message+ "\r\n";
            Txt += "发生位置："+Url+ "\r\n";
            Txt += "所在行数："+NumForRows+ "\r\n";
            Txt += "------------------------------END------------------------------\r\n";

            return Txt;

        }

    }
}
