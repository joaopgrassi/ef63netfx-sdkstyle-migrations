# EF 6.3/.NET Framework with SDK style csproj

This sample repro contains the following projects

- Class library with EF 6.3 code (DbContext, Migrations, Entity and etc)
- A ASP.NET WebAPI 2

All projects are running on `.NET Framework 4.7.2`. No .NET Core involved.

With the work being done by the EF Team on the .NET Core 3.0 release, Entity Framework 6.3 will be able to run on .NET Core, thus also supporting the new [SDK style project](https://docs.microsoft.com/en-us/dotnet/core/tools/csproj).   
  
While upgrading an existing solution to the new SDK csproj style, I ran into problems while migrating an class library which contained the EF code. You can see more about it on the [issue I opened](https://github.com/aspnet/EntityFramework6/issues/1269) in their repo on GitHub.  
  
