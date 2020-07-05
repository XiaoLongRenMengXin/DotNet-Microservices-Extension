using Microsoft.AspNetCore.Mvc;

namespace Microservices.Extension.Controllers{

    /// <summary>
    /// WebApi控制器基类
    /// </summary>
    public class BaseController: ControllerBase{
        public object _current { get; set; }

        /// <summary>
        /// 成功,用于返回对象信息
        /// </summary>
        public void Success() {
        }

        /// <summary>
        /// 警告,用于返回验证相关
        /// </summary>
        public void Warning() {
        }

        /// <summary>
        /// 错误,用于返回异常信息
        /// </summary>
        public void Error() {
        }

        /// <summary>
        /// 消息,用于返回字符串文本
        /// </summary>
        public void Info() {
        }
    }
}