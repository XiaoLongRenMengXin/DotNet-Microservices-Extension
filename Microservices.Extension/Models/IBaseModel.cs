namespace Microservices.Extension {

    /// <summary>
    /// 实体类映射接口定义
    /// </summary>
    public interface IBaseModel {

        /// <summary>
        /// 获取一个Guid
        /// </summary>
        /// <returns></returns>
        string GetGuid();

        /// <summary>
        /// 获取一个Guid-N格式
        /// </summary>
        /// <returns></returns>
        string GetGuidN();

        /// <summary>
        /// 获取一个Guid-D格式
        /// </summary>
        /// <returns></returns>
        string GetGuidD();

        /// <summary>
        /// 获取一个Guid-B格式
        /// </summary>
        /// <returns></returns>
        string GetGuidB();

        /// <summary>
        /// 获取一个Guid-P格式
        /// </summary>
        /// <returns></returns>
        string GetGuidP();

        /// <summary>
        /// 获取一个Guid-X格式
        /// </summary>
        /// <returns></returns>
        string GetGuidX();
     }
}