set TARGET=%~DP0..\NugetPreCompiled
md %TARGET%
c:\Windows\Microsoft.NET\Framework64\v4.0.30319\aspnet_compiler.exe -f -v Temp -p %~DP0Src\NuGetGallery %TARGET%
del %TARGET%\NuGetGallery.csproj
del %TARGET%\NuGetGallery.csproj.DotSettings
del %TARGET%\NuGetGallery.csproj.user