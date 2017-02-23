# .NET Core Hello World Dependencies

The output is run using [nuget-tree](https://www.npmjs.com/package/nuget-tree)

If you want to scare yourself silly run it with the `--showSystem` flag to show system dependencies. It creates a 100mb file!!

```
project.lock.json
├─┬ Microsoft.AspNetCore.Server.Kestrel 1.1.0
│ ├─┬ Libuv 1.9.1
│ │ └── Microsoft.NETCore.Platforms 1.1.0
│ ├─┬ Microsoft.AspNetCore.Hosting 1.1.0
│ │ ├─┬ Microsoft.AspNetCore.Hosting.Abstractions 1.1.0
│ │ │ ├─┬ Microsoft.AspNetCore.Hosting.Server.Abstractions 1.1.0
│ │ │ │ ├─┬ Microsoft.AspNetCore.Http.Features 1.1.0
│ │ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Configuration.Abstractions 1.1.0
│ │ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.AspNetCore.Http.Abstractions 1.1.0
│ │ │ │ ├─┬ Microsoft.AspNetCore.Http.Features 1.1.0
│ │ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.Configuration.Abstractions 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.DependencyInjection.Abstractions 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.FileProviders.Abstractions 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.Logging.Abstractions 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ ├─┬ Microsoft.AspNetCore.Hosting.Server.Abstractions 1.1.0
│ │ │ ├─┬ Microsoft.AspNetCore.Http.Features 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.Configuration.Abstractions 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ ├─┬ Microsoft.AspNetCore.Http 1.1.0
│ │ │ ├─┬ Microsoft.AspNetCore.Http.Abstractions 1.1.0
│ │ │ │ ├─┬ Microsoft.AspNetCore.Http.Features 1.1.0
│ │ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.AspNetCore.WebUtilities 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ ├─┬ Microsoft.Net.Http.Headers 1.1.0
│ │ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.ObjectPool 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.Options 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.DependencyInjection.Abstractions 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Net.Http.Headers 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ ├─┬ Microsoft.AspNetCore.Http.Extensions 1.1.0
│ │ │ ├─┬ Microsoft.AspNetCore.Http.Abstractions 1.1.0
│ │ │ │ ├─┬ Microsoft.AspNetCore.Http.Features 1.1.0
│ │ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.FileProviders.Abstractions 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Net.Http.Headers 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ ├─┬ Microsoft.Extensions.Configuration 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.Configuration.Abstractions 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ ├─┬ Microsoft.Extensions.Configuration.EnvironmentVariables 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.Configuration 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Configuration.Abstractions 1.1.0
│ │ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ ├─┬ Microsoft.Extensions.DependencyInjection 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.DependencyInjection.Abstractions 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ ├─┬ Microsoft.Extensions.FileProviders.Physical 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.FileProviders.Abstractions 1.1.0
│ │ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.FileSystemGlobbing 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ ├─┬ Microsoft.Extensions.Logging 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.DependencyInjection.Abstractions 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.Logging.Abstractions 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ ├─┬ Microsoft.Extensions.Options 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.DependencyInjection.Abstractions 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ ├─┬ Microsoft.Extensions.Primitives 1.1.0
│ │ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ ├─┬ Microsoft.Extensions.PlatformAbstractions 1.1.0
│ │ │ └─┬ NETStandard.Library 1.6.1
│ │ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │ │     └── Microsoft.NETCore.Targets 1.1.0
│ │ └─┬ NETStandard.Library 1.6.1
│ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │     └── Microsoft.NETCore.Targets 1.1.0
│ ├─┬ Microsoft.Extensions.Logging.Abstractions 1.1.0
│ │ └─┬ NETStandard.Library 1.6.1
│ │   ├── Microsoft.NETCore.Platforms 1.1.0
│ │   └─┬ Microsoft.Win32.Primitives 4.3.0
│ │     ├── Microsoft.NETCore.Platforms 1.1.0
│ │     └── Microsoft.NETCore.Targets 1.1.0
│ └─┬ NETStandard.Library 1.6.1
│   ├── Microsoft.NETCore.Platforms 1.1.0
│   └─┬ Microsoft.Win32.Primitives 4.3.0
│     ├── Microsoft.NETCore.Platforms 1.1.0
│     └── Microsoft.NETCore.Targets 1.1.0
├─┬ Microsoft.NETCore.App 1.1.0
│ ├─┬ Libuv 1.9.1
│ │ └── Microsoft.NETCore.Platforms 1.1.0
│ ├── Microsoft.CSharp 4.3.0
│ ├─┬ Microsoft.CodeAnalysis.CSharp 1.3.0
│ │ └─┬ Microsoft.CodeAnalysis.Common 1.3.0
│ │   └── Microsoft.CodeAnalysis.Analyzers 1.1.0
│ ├─┬ Microsoft.CodeAnalysis.VisualBasic 1.3.0
│ │ └─┬ Microsoft.CodeAnalysis.Common 1.3.0
│ │   └── Microsoft.CodeAnalysis.Analyzers 1.1.0
│ ├── Microsoft.DiaSymReader.Native 1.4.0
│ ├─┬ Microsoft.NETCore.DotNetHostPolicy 1.1.0
│ │ └─┬ Microsoft.NETCore.DotNetHostResolver 1.1.0
│ │   └── Microsoft.NETCore.DotNetHost 1.1.0
│ ├─┬ Microsoft.NETCore.Runtime.CoreCLR 1.1.0
│ │ ├── Microsoft.NETCore.Jit 1.1.0
│ │ └── Microsoft.NETCore.Windows.ApiSets 1.0.1
│ ├── Microsoft.VisualBasic 10.1.0
│ └─┬ NETStandard.Library 1.6.1
│   ├── Microsoft.NETCore.Platforms 1.1.0
│   └─┬ Microsoft.Win32.Primitives 4.3.0
│     ├── Microsoft.NETCore.Platforms 1.1.0
│     └── Microsoft.NETCore.Targets 1.1.0
├─┬ Microsoft.Win32.Registry 4.3.0
│ └── Microsoft.NETCore.Platforms 1.1.0
├─┬ runtime.native.System 4.3.0
│ ├── Microsoft.NETCore.Platforms 1.1.0
│ └── Microsoft.NETCore.Targets 1.1.0
├─┬ runtime.native.System.IO.Compression 4.3.0
│ ├── Microsoft.NETCore.Platforms 1.1.0
│ └── Microsoft.NETCore.Targets 1.1.0
├─┬ runtime.native.System.Net.Http 4.3.0
│ ├── Microsoft.NETCore.Platforms 1.1.0
│ └── Microsoft.NETCore.Targets 1.1.0
├─┬ runtime.native.System.Net.Security 4.3.0
│ ├── Microsoft.NETCore.Platforms 1.1.0
│ └── Microsoft.NETCore.Targets 1.1.0
├─┬ runtime.native.System.Security.Cryptography.Apple 4.3.0
│ └── runtime.osx.10.10-x64.runtime.native.System.Security.Cryptography.Apple 4.3.0
└─┬ runtime.native.System.Security.Cryptography.OpenSsl 4.3.0
  ├── runtime.debian.8-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0
  ├── runtime.fedora.23-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0
  ├── runtime.fedora.24-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0
  ├── runtime.opensuse.13.2-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0
  ├── runtime.opensuse.42.1-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0
  ├── runtime.osx.10.10-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0
  ├── runtime.rhel.7-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0
  ├── runtime.ubuntu.14.04-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0
  ├── runtime.ubuntu.16.04-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0
  └── runtime.ubuntu.16.10-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0


```
