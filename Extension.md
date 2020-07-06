# 文件介绍

以下是一个启动文件的默认配置，增加注释一步步理解，目前看来`Configure`方法更多是在实际业务开始之前对请求的处理, `ConfigureServices`则是在请求处理阶段的处理，比如日志的拦截记录、事务的处理、实体
类对象的映射
```C#
    /// <summary>
    /// 项目启动文件
    /// </summary>
    public class Startup {

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="configuration">配置管理对象注入(appsettings.json)、appsettings.Development.json</param>
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        /// <summary>
        /// 本项目的配置对象
        /// </summary>
        /// <value></value>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 服务注册方法，每个项目都有一个服务容器，用来将我们使用的服务集中起来，然后依次的执行，这个方法就是帮助我们将服务注册进容器中，以便随时调用
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">容器对象</param>
        public void ConfigureServices (IServiceCollection services) {
            // 注册控制器服务、注册NewtonsoftJson服务，.net core本身自带一个JSON序列化的服务，但是使用不方便，所以替换
            services.AddControllers ().AddNewtonsoftJson ();

            // 注册MVC 服务
            services.AddMvc ();
        }

        /// <summary>
        /// Http管道方法，每个项目实例都是以“管道模式”运行的，我们的请求就是入口，响应是出口，这个方法是为了让我们自定义在这个阶段内处理
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">管道对象</param>
        /// <param name="env">web运行托管环境信息</param>
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            // 判断运行环境是否是开发环境
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            // 将HTTP请求重定向值HTTPS
            app.UseHttpsRedirection ();

            // 路由
            app.UseRouting ();

            // 身份验证、权限
            app.UseAuthorization ();

            app.UseEndpoints (endpoints => {
                endpoints.MapControllers ();
            });
        }
    }
```

# 服务注入

利用扩展方法的特性，直接对 `IServiceCollection`、`IApplicationBuilder`两个对象增加方法

```C#
    /// <summary>
    /// 服务注册扩展类
    /// </summary>
    public static class MicroservicesExtensions{

        /// <summary>
        /// 服务注册
        /// </summary>
        /// <param name="services">当前运行的服务程序</param>
        /// <returns></returns>
        public static IServiceCollection AddMicroservicesExtensions(this IServiceCollection services){
            // 向程序中注册服务功能
            return null;
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
```