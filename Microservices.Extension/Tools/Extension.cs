using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using Microservices.Extension.Models;

namespace Microservices.Extension {

    /// <summary>
    /// .Net原始对象扩展
    /// </summary>
    public static class Extension {

        /// <summary>
        /// 判断对象是否为空
        /// </summary>
        /// <param type="object" name="data">对象本身</param>
        /// <returns></returns>
        public static bool IsNull (this object data) {
            if (data == null) {
                return true;
            } else {
                return false;
            }

        }

        /// <summary>
        /// 获取枚举描述
        /// </summary>
        /// <param type="Enum" name="data">枚举项</param>
        /// <returns>枚举描述</returns>
        public static string GetDescription (this Enum data) {
            // 判断枚举是否为空
            if (data.IsNull ()) {
                return string.Empty;
            }

            // 获取枚举描述
            object obj = data.GetType ().GetField (data.ToString ()).GetCustomAttribute (typeof (DescriptionAttribute), true);

            // 返回
            return obj == null ? string.Empty : (obj as DescriptionAttribute).Description;
        }

        /// <summary>
        /// 将枚举转换为集合
        /// </summary>
        /// <param type="Enum" name="data">枚举</param>
        /// <returns></returns>
        public static IList<ListItem> ToList (this Enum data, string selected = "", string disabled = "") {
            IList<ListItem> lst = new List<ListItem> ();
            // 判断枚举是否为空
            if (data.IsNull ()) {
                return lst;
            }

            // 获取枚举类型
            Type type = data.GetType ();

            // 根据枚举类型,获取该枚举的选项集合
            foreach (var e in Enum.GetValues (type)) {
                // 寻找枚举的描述(Description 特性)
                object obj = e.GetType ().GetField (e.ToString ()).GetCustomAttribute (typeof (DescriptionAttribute), true);
                ListItem item = new ListItem ();
                item.Value = Convert.ToInt32 (e).ToString ();

                if (obj.IsNull ()) {
                    item.Text = $"未获取到枚举{item.Value}描述";
                } else {
                    item.Text = (obj as DescriptionAttribute).Description;
                }

                // 是否为选中项
                if(item.Value.Equals(selected)) {
                    item.Selected = true;
                }

                // 是否为禁用项
                if(item.Value.Equals(disabled)) {
                    item.Disabled = true;
                }

                lst.Add(item);
            }

            return lst;
        }
    }
}