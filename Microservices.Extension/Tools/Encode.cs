using System;
using System.Text;

namespace Microservices.Extension{
    public class Encode{
        /// <summary>
        /// 将字符串转换成base64格式,使用UTF8字符集
        /// </summary>
        /// <param name="EncodeContent">加密内容</param>
        /// <returns>base64加密字符串</returns>
        public static string Base64Encode (string EncodeContent) {
            if (string.IsNullOrEmpty(EncodeContent)) {
                return EncodeContent;
            }
            byte[] bytes = Encoding.UTF8.GetBytes (EncodeContent);
            return Convert.ToBase64String (bytes);
        }

        /// <summary>
        /// 将base64加密字符串转换成明文字符串,使用UTF8字符集
        /// </summary>
        /// <param name="DecodeContent">解密内容</param>
        /// <returns>明文字符串</returns>
        public static string Base64Decode (string DecodeContent) {
            if (string.IsNullOrEmpty(DecodeContent)) {
                return DecodeContent;
            }
            byte[] bytes = Encoding.UTF8.GetBytes (DecodeContent);
            return Convert.ToBase64String (bytes);
        }
    }
}