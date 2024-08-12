# Community.PowerToys.Run.Plugin.Abstractions

[![build](https://github.com/hlaueriksson/Community.PowerToys.Run.Plugin.Abstractions/actions/workflows/build.yml/badge.svg)](https://github.com/hlaueriksson/Community.PowerToys.Run.Plugin.Abstractions/actions/workflows/build.yml)
[![Community.PowerToys.Run.Plugin.Abstractions](https://img.shields.io/nuget/v/Community.PowerToys.Run.Plugin.Abstractions.svg?label=Community.PowerToys.Run.Plugin.Abstractions)](https://www.nuget.org/packages/Community.PowerToys.Run.Plugin.Abstractions)

This NuGet package is intended for PowerToys Run community plugins authors.

It contains abstractions for the `Wox` DLLs:

- `Wox.Infrastructure.dll`
- `Wox.Plugin.dll`

In other words, interfaces and wrappers for the static classes:

- `Wox.Infrastructure.Helper`
- `Wox.Plugin.Common.DefaultBrowserInfo`
- `Wox.Plugin.Logger.Log`

## Installation

.NET CLI:

```cmd
dotnet add package Community.PowerToys.Run.Plugin.Abstractions
```

Package Manager:

```cmd
PM> NuGet\Install-Package Community.PowerToys.Run.Plugin.Abstractions
```

PackageReference:

```csproj
<PackageReference Include="Community.PowerToys.Run.Plugin.Abstractions" Version="0.1.0" />
```

## Example

```csproj
<ItemGroup>
  <InternalsVisibleTo Include="Community.PowerToys.Run.Plugin.Sample.UnitTests" />
</ItemGroup>
```

```cs
using Community.PowerToys.Run.Plugin.Abstractions;
using static Wox.Infrastructure.Helper;
```

```cs
/// <summary>
/// Initializes a new instance of the <see cref="Main"/> class.
/// </summary>
public Main()
{
    Helper = new HelperWrapper();
    DefaultBrowserInfo = new DefaultBrowserInfoWrapper();
    Log = new LogWrapper();
}

internal Main(IHelper helper, IDefaultBrowserInfo defaultBrowserInfo, ILog log)
{
    Helper = helper;
    DefaultBrowserInfo = defaultBrowserInfo;
    Log = log;
}

private IHelper Helper { get; }
private IDefaultBrowserInfo DefaultBrowserInfo { get; }
private ILog Log { get; }
```

```cs
DefaultBrowserInfo.UpdateIfTimePassed();

if (!Helper.OpenCommandInShell(DefaultBrowserInfo.Path, DefaultBrowserInfo.ArgumentsPattern, url))
{
    Log.Error("Open default browser failed.", GetType());
    Api.ShowMsg($"Plugin: {Metadata.Name}", "Open default browser failed.");
}
```

```cs
[SetUp]
public void SetUp()
{
    _subject = new Main(Substitute.For<IHelper>(), Substitute.For<IDefaultBrowserInfo>(), Substitute.For<ILog>());
}
```

## Disclaimer

This is not an official Microsoft PowerToys package.
