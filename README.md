# DotNet-Microservices-Extension(扩展微服务基本功能)
密钥 oy2b4rbydu2jmpf545iahwtcqzichreebpjnxsr5cpf3ki
## 项目搭建
1.运行命令 

`dotnet new classlib -o Microservices.Extension`

2.创建目录

`Controllers` Api控制器

`Dao` 数据访问层

`Filter` 请求过滤器

`Mapper` 对象映射

`Models` 数据库实体映射

`Service` 服务

`Tools` 工具

3.项目添加`Asp.Net Core`依赖

`dotnet add Microservices.Extension/Microservices.Extension.csproj package Microsoft.AspNetCore.Mvc.Core --version 2.2.5`

4. VS Code 调试

进入`Test`目录中,然后`运行-调试`配置目录下`.vscode`文件夹中的`launch.json`文件,修改`console`属性`"console": "internalConsole",` ->`"console": "integratedTerminal"`

然后就在**Test**目录中调试