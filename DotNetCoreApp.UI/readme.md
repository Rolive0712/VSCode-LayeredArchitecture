STEPS ( .Net Core CLI commands)
* check=> https://docs.microsoft.com/en-us/dotnet/core/tools/index?tabs=netcore1x

* dotnet new sln            -- create blank solution
* mkdir "DotNetCoreApp.UI"
* cd "DotNetCoreApp.UI"
* run "dotnet new angular"  -- setup angular boiler plate within UI folder
* run "dotnet restore"
* run "npm install"
* run "dotnet build"        -- after setup build to create bin,obj folders and .dll files within the same.

Now add UI project to blank solution file

* run "cd.."                -- to come to level where the solution file is present
* run "dotnet sln add ".\DotNetCoreApp.UI\DotNetCoreApp.UI.csproj"    -- this adds project to solution

Create new "business" c# library project 

* run "dotnet new classlib -n "DotNetCoreApp.Business"
* Add a method call in the library
* run "dotnet build"
* run dotnet sln add ".\DotNetCoreApp.Business\DotNetCoreApp.Business.csproj"

Create new "dataaccess" c# library project 

* dotnet new classlib -n "DotNetCoreApp.DataAccess"
* Add a method call in the library
* run "dotnet build"
* run dotnet sln add ".\DotNetCoreApp.DataAccess\DotNetCoreApp.DataAccess.csproj"

Reference DataAccess library within Business library

* get into business library project folder
* run dotnet add .\DotNetCoreApp.Business.csproj reference "..\DotNetCoreApp.DataAccess\DotNetCoreApp.DataAccess.csproj"
* run dotnet build

Reference Business library within UI project

* get into UI app project folder
* dotnet add .\DotNetCoreApp.UI.csproj reference "..\DotNetCoreApp.Business\DotNetCoreApp.Business.csproj"
* dotnet build

finally run the project by selecting the configured browser

RUN below command to check for errors if any
* run dotnet run --project "${workspaceFolder}\DotNetCoreApp.UI.csproj" --configuration debug

As folder structures are created, its very important to specify correct path in launch.json configuration for each browser.
* in configuration mention correct path under attributes mentioned below.
>> "program":
>> "cwd":
refer : http://blog.evizija.si/webpack-dev-middleware-failed-because-of-an-error-while-loading-aspnet-webpack/

* IE 9, IE 10, IE 11 support
refer: https://github.com/aspnet/JavaScriptServices/wiki/Supporting-Internet-Explorer-11-(or-older)

* C# support
Visual Studio Code uses the power of Roslyn and OmniSharp to offer an enhanced C# experience.
* check: https://code.visualstudio.com/docs/languages/csharp

* to get intellisense working, added one more TestConsole project as standalone project not included within the root solution
* then started debugging console using ".NET Core Attach" configuration
* then automatically intellisense started working in UI project and all other class libraries also.

Quick way to add dll references in class library project
check:
* https://stackoverflow.com/questions/42000798/how-to-add-assembly-references-in-visual-studio-code/42399545#42399545
* https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package

VSCode behind firewall
 * https://taeguk.co.uk/blog/working-in-visual-studio-behind-the-firewall/