using System;
using System.Text;

namespace Microservices.Extension {

    /// <summary>
    /// 类型验证扩展类
    /// </summary>
    public static class Verify {

        #region Int
        /// <summary>
        /// 验证Int最小值
        /// </summary>
        /// <param name="data">验证值</param>
        /// <param name="message">自定义提示语句</param>
        /// <param name="min">最小值</param>
        public static void Min (this int data, string message = "", int min = int.MinValue) {
            if (data <= min) {
                // 判断提示语句是否为空
                if (string.IsNullOrEmpty (message)) {
                    throw new Exception ($"最小值为:{min}");
                } else {
                    throw new Exception (message);
                }
            }
        }

        /// <summary>
        /// 验证Int最小值
        /// </summary>
        /// <param name="data">验证值</param>
        /// <param name="message">自定义提示语句</param>
        /// <param name="max">最大值</param>
        public static void Max (this int data, string message = "", int max = int.MaxValue) {
            if (data >= max) {
                // 判断提示语句是否为空
                if (string.IsNullOrEmpty (message)) {
                    throw new Exception ($"最大值为:{max}");
                } else {
                    throw new Exception (message);
                }
            }
        }

        /// <summary>
        /// 验证Int是否在指定数值大小范围之间
        /// </summary>
        /// <param name="data">验证值</param>
        /// <param name="message">自定义提示语句</param>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        public static void Scope (this int data, string message = "", int min = int.MinValue, int max = int.MaxValue) {
            if (min > max) {
                throw new Exception ("方法配置的参数中最小值大于最大值");
            }

            data.Min (message, min);
            data.Max (message, max);
        }
        #endregion

        #region String

        /// <summary>
        /// 验证String字符串是否为空
        /// </summary>
        /// <param name="data">验证字符串</param>
        /// <param name="whiteSpace">是否过滤空白字符串,默认过滤</param>
        /// <returns>判断结果</returns>
        public static bool DontEmpty (this string data, bool whiteSpace = true) {
            if (whiteSpace) {
                return !string.IsNullOrWhiteSpace (data);
            } else {
                return !string.IsNullOrEmpty (data);
            }
        }

        /// <summary>
        /// 验证String字符串是否为空,为空时抛出异常
        /// </summary>
        /// <param name="data">验证字符串</param>
        /// <param name="whiteSpace">是否过滤空白字符串,默认过滤</param>
        /// <returns>判断结果</returns>
        public static void DontEmptyError (this string data, bool whiteSpace = true) {
            if (whiteSpace) {
                if (string.IsNullOrWhiteSpace (data)) {
                    throw new Exception ($"字符中不可包含空字符、空白字符");
                }
            } else {
                if (string.IsNullOrWhiteSpace (data)) {
                    throw new Exception ($"字符中不可包含空字符");
                }
            }
        }

        /// <summary>
        /// 验证String字符串长度最小值
        /// </summary>
        /// <param name="data">验证字符串</param>
        /// <param name="message">自定义提示消息</param>
        /// <param name="minLength">最小字符长度</param>
        public static void MinLength (this string data, string message = "", int minLength = int.MinValue) {
            data.DontEmptyError ();

            if (data.Length <= minLength) {
                // 判断提示语句是否为空
                if (message.DontEmpty ()) {
                    throw new Exception ($"字符至少包括{minLength}个字符");
                } else {
                    throw new Exception (message);
                }
            }
        }

        /// <summary>
        /// 验证String字符串长度最大值
        /// </summary>
        /// <param name="message">自定义提示消息</param>
        /// <param name="data">验证字符串</param>
        /// <param name="maxLength">最大字符长度</param>
        public static void MaxLength (this string data, string message = "", int maxLength = int.MaxValue) {
            data.DontEmptyError ();

            if (data.Length >= maxLength) {
                // 判断提示语句是否为空
                if (message.DontEmpty ()) {
                    throw new Exception ($"字符至多包括{maxLength}个字符");
                } else {
                    throw new Exception (message);
                }
            }
        }

        /// <summary>
        /// 验证字符串的长度是否在指定数值范围之间
        /// </summary>
        /// <param name="data">验证字符串</param>
        /// <param name="message">自定义提示语句</param>
        /// <param name="minLength">最小长度</param>
        /// <param name="maxLength">最大长度</param>
        public static void ScopeLength (this string data, string message = "", int minLength = int.MinValue, int maxLength = int.MaxValue) {
            if (minLength > maxLength) {
                throw new Exception ("方法配置的参数中最小值大于最大值");
            }

            data.MinLength (message, minLength);
            data.MaxLength (message, maxLength);
        }

        /// <summary>
        /// 验证包括中文字符串的字符串长度最小值
        /// </summary>
        /// <param name="data">验证字符串</param>
        /// <param name="message">自定义提示消息</param>
        /// <param name="minLength">最小字符长度</param>
        public static void ChinaMinLength (this string data, string message = "", int minLength = int.MinValue) {
            data.DontEmptyError ();

            if (Encoding.Default.GetBytes (data).Length <= minLength) {
                // 判断提示语句是否为空
                if (message.DontEmpty ()) {
                    throw new Exception ($"字符至少包括{minLength}个字符");
                } else {
                    throw new Exception (message);
                }
            }
        }

        /// <summary>
        /// 验证包括中文字符串的字符串长度最大值
        /// </summary>
        /// <param name="data">验证字符串</param>
        /// <param name="message">自定义提示消息</param>
        /// <param name="maxLength">最大字符长度</param>
        public static void ChinaMaxLength (this string data, string message = "", int maxLength = int.MaxValue) {
            data.DontEmptyError ();

            if (Encoding.Default.GetBytes (data).Length >= maxLength) {
                // 判断提示语句是否为空
                if (message.DontEmpty ()) {
                    throw new Exception ($"字符至多包括{maxLength}个字符");
                } else {
                    throw new Exception (message);
                }
            }
        }

        /// <summary>
        /// 验证包含中文的字符串的长度是否在指定数值范围之间
        /// </summary>
        /// <param name="data">验证字符串</param>
        /// <param name="message">自定义提示语句</param>
        /// <param name="minLength">最小长度</param>
        /// <param name="maxLength">最大长度</param>
        public static void ChinaScopeLength (this string data, string message = "", int minLength = int.MinValue, int maxLength = int.MaxValue) {
            if (minLength > maxLength) {
                throw new Exception ("方法配置的参数中最小值大于最大值");
            }

            data.MinLength (message, minLength);
            data.MaxLength (message, maxLength);
        }
        #endregion
    
    }
}