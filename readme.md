# SevenZipSharp.Interop  #
This plugin installs the 7z interop dll's 19.00 into your project. This way you can use SevenZipSharp without installing 7zip.

[NuGet](https://www.nuget.org/packages/SevenZipSharp.Interop)

### Usage ###
```csharp
// Toggle between the x86 and x64 bit dll
var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),Environment.Is64BitProcess ? "x64" : "x86", "7z.dll");
SevenZip.SevenZipBase.SetLibraryPath(path);
```