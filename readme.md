# Native dll extension for SevenZipSharp #
This plugin installs the latest 7zip dll's into your project. This way 7zip will just be deployed.

### Usage ###
```csharp
// Toggle between the x86 and x64 bit dll
var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),Environment.Is64BitProcess ? "x64" : "x86", "7z.dll");
SevenZip.SevenZipBase.SetLibraryPath(path);
```