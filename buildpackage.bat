cd src
..\tools\nuget\nuget.exe pack SevenZipSharp.Interop.nuspec -OutputDirectory ..\artifacts
..\tools\nuget\nuget.exe pack SevenZipSharp.Interop.NoReferences.nuspec -OutputDirectory ..\artifacts
cd ..
pause