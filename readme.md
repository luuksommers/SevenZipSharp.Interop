# SevenZipSharp.Interop

This plugin installs the 7z interop dll's 19.00 into your project. This way you can use SevenZipSharp without installing 7zip.

[NuGet](https://www.nuget.org/packages/SevenZipSharp.Interop)

### Changelog

- 19.1.0 [Fix file copy](https://github.com/luuksommers/SevenZipSharp.Interop/pull/19) thanks to [RoadTrain](https://github.com/RoadTrain)
- 19.0.2 [Add support for VS2022]
- 19.0.1 [Add support for VS2019](https://github.com/luuksommers/SevenZipSharp.Interop/pull/14) thanks to [SpiridonovAlexMoeDelo](https://github.com/SpiridonovAlexMoeDelo)

### Usage

```csharp
// Toggle between the x86 and x64 bit dll
var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),Environment.Is64BitProcess ? "x64" : "x86", "7z.dll");
SevenZip.SevenZipBase.SetLibraryPath(path);
```
