#!/usr/bin/env bash
dotnet new console -n 2-new_project
dotnet restore 2-new_project.csproj
dotnet build
dotnet run
