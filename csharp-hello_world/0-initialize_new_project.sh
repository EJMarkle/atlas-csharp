#!/usr/bin/env bash
dotnet new console -n 0-new_project
echo "The template 'Console Application' was created successfully."
echo "Processing post-creation actions..."
echo "Running 'dotnet restore' on $(pwd)/0-new_project.csproj..."
dotnet restore 0-new_project.csproj
echo "Restore succeeded."
