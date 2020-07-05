using System;

namespace Microservices.Extension.Models {

    /// <summary>
    /// 集合项
    /// </summary>
    public class ListItem : BaseModel {
        /// <summary>
        /// 集合项的名称
        /// </summary>
        /// <value></value>
        public string Label { get { return Text; } }

        /// <summary>
        /// 集合项的值
        /// </summary>
        /// <value></value>
        public string Value { get; set; }

        /// <summary>
        /// 集合项的文本
        /// </summary>
        /// <value></value>
        public string Text { get; set; }

        /// <summary>
        /// 集合项的值
        /// </summary>
        /// <value></value>
        public string Id { get { return Value; } }

        /// <summary>
        /// 集合项是否被选中
        /// </summary>
        /// <value></value>
        public bool Selected { get; set; }

        /// <summary>
        /// 集合项是否禁用
        /// </summary>
        /// <value></value>
        public bool Disabled { get; set; }
    }
}