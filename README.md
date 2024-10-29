# SPP.SDK [![Crowdin](https://badges.crowdin.net/steampp/localized.svg)](https://crowdin.com/project/steampp) [![license](https://img.shields.io/github/license/beyonddimension/SPP.SDK)](https://github.com/BeyondDimension/SPP.SDK/blob/main/LICENSE)
Watt Toolkit 服务端 SDK

### Mobius.Models
客户端与服务端通信的数据模型（当前接口版本所使用的，旧接口废弃的仅兼容的内容放入 Compat 库）

1. 模型类一个文件一个类，类名与文件名一致，不可一个文件内有多个模型类
2. 模型类需要能够使用 System.Text.Json 与 MemoryPack 序列化与反序列化，在单元测试项目中利用反射然后循环赋值属性进行测试
3. 模型类命名空间与所在文件夹一致，目前没有不一致的特殊情况，且新增的命名空间需要在项目的 Properties\GlobalUsings.Mobius.Models.props（虚拟路径，实际文件路径为 src\Shared\GlobalUsings.Mobius.Models.props） 中声明 ```<Using Include="Mobius.Models.XXX" />```

### Mobius.Primitives
客户端与服务端通信的枚举与常量以及接口等基础内容，规则同上


### Mobius.SDK
客户端 HTTP 调用服务类库，包含了所有的接口调用方法，以及一些基础的数据处理方法，业务接口通过扩展函数的形式定义在业务项目中

### Mobius.SDK.UnitTest
当前项目的单元测试用例，对模型序列化等验证，以及业务接口扩展函数定义与测试

1. 业务接口通过扩展函数定义调用请求参数，响应参数，以及测试用例，测试成功后验收完成
2. 客户端复制测试用例中的扩展函数到业务项目中使用