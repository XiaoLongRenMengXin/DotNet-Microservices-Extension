using System;

namespace Microservices.Extension.Models {

    /// <summary>
    /// 实体类映射基类
    /// </summary>
    public class BaseModel : IBaseModel
    {
        /// <summary>
        /// 获取一个Guid
        /// </summary>
        /// <returns></returns>
        public string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 获取一个Guid-B格式
        /// </summary>
        /// <returns></returns>
        public string GetGuidB()
        {
            return Guid.NewGuid().ToString("B");
        }

        /// <summary>
        /// 获取一个Guid-D格式
        /// </summary>
        /// <returns></returns>
        public string GetGuidD()
        {
            return Guid.NewGuid().ToString("D");
        }

        /// <summary>
        /// 获取一个Guid-N格式
        /// </summary>
        /// <returns></returns>
        public string GetGuidN()
        {
            return Guid.NewGuid().ToString("N");
        }

        /// <summary>
        /// 获取一个Guid-P格式
        /// </summary>
        /// <returns></returns>
        public string GetGuidP()
        {
            return Guid.NewGuid().ToString("P");
        }

        /// <summary>
        /// 获取一个Guid-X格式
        /// </summary>
        /// <returns></returns>
        public string GetGuidX()
        {
            return Guid.NewGuid().ToString("X");
        }
    }
}