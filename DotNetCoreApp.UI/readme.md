STEPS ( .Net Core CLI commands)
* check=> https://docs.microsoft.com/en-us/dotnet/core/tools/index?tabs=netcore1x

* npm install webpack-notifier --save-dev
* npm install -g webpack
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
 * http://blog.majcica.com/2016/04/07/visual-studio-code-behind-a-proxy/

 MSBuild command line publish
 * https://docs.microsoft.com/en-us/aspnet/web-forms/overview/deployment/visual-studio-web-deployment/command-line-deployment

 Publish to local folder
 * dotnet publish -o "C:\Roshit\VisualStudioCode_Projects\publish_path" --configuration release
 dotnet publish -o "C:\inetpub\wwwroot\DotNetCoreUI" --configuration release
 Always publish from root folder. Here its "VSCODE-LAYEREDAECHITECTURE".
 If published from other child folders, you will get error as below one you run the application
* "One or more errors occurred. (Webpack dev middleware failed because of an error while loading 'aspnet-webpack'. Error was: Error:      Cannot find module 'aspnet-webpack'"
 * if publish fails due to access issues, then provide "authenticated users" full permission on "wwwroot" folder.
 * after publish is success, go to the published folder cd <publish path>
 * then run "dotnet DotNetCoreApp.UI.dll"
 * you should get message 
   server listening on ......
   application started
   
Publish to IIS on server
 * Install .Net Core hosting bundle
 * After that, ensure "AspNetCoreModule" is listed as part of all native modules in IIS
 * Then create application pool configured to "No Managed Code" and "network service"
 * Create new website and map it to this new app pool.

 Publish to IIS on local dev machine
 * AspNetCoreModule" will be available as dev machine has .net core sdk.
 * create application pool configured to "No Managed Code" and "network service"
 * Create new website and map it to this new app pool.
 * now browse app from IIS. it should run fine.
if below error appears,

 


All works fine. Now lets separate the API part by creating new API project and adding JWT support on it to secure the API.
* run dotnet new webapi -n "DotNetCore.API"

