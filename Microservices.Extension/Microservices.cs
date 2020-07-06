using System;
using Microservices.Extension.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.Extension{

    /// <summary>
    /// 服务注册扩展类
    /// </summary>
    public static class Microservices{

        /// <summary>
        /// 服务注册
        /// </summary>
        /// <param name="services">当前运行的服务程序</param>
        /// <returns></returns>
        public static IServiceCollection AddMicroservices(this IServiceCollection services, Action<MicroserviceOptions> setupAction = null){
            // 向程序中注册服务功能
            return services;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureMicroservices(this IServiceCollection services){
        }

        /// <summary>
        /// HTTP管道
        /// </summary>
        /// <param name="app"></param>
        public static void UseMicroservicesExtensions(this IApplicationBuilder app){
            // 对于管道进行操作
        }
    }
}