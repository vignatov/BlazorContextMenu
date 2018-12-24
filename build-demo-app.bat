@echo off
cd "%~dp0"


dotnet publish DemoApp\BlazorContextMenu.DemoApp -c Release -o ..\..\Artifacts\DemoApp
if %errorlevel% neq 0 exit /b %errorlevel%