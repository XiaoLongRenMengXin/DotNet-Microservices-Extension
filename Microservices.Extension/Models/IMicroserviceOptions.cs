using Microsoft.Extensions.Configuration;

namespace Microservices.Extension.Models {

    /// <summary>
    /// 服务接口对象定义
    /// </summary>
    public interface IMicroserviceOptions {

        /// <summary>
        /// 初始化NHiberNate
        /// </summary>
        /// <param name="section">关于NHiberNate的配置信息</param>
        void InitNHiberNate(IConfigurationSection section) ;

        /// <summary>
        /// 初始化NHiberNate
        /// </summary>
        /// <param name="connection">数据库初始化连接字符串</param>
        void InitNHiberNate(string connection) ;

    }
}