#!/usr/bin/env bash
dotnet new console -n 1-new_project
echo "The template 'Console Application' was created successfully."
echo "Processing post-creation actions..."
echo "Running 'dotnet restore' on $(pwd)/1-new_project.csproj..."
dotnet restore 1-new_project.csproj
echo "Building the project..."
dotnet build
echo "Build succeeded."
