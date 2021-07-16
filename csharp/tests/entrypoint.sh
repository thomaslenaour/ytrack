#!/bin/sh

set -e

cd /jail

dotnet nuget disable source nuget.org
dotnet nuget add source /dotnetpkg

cp -rf ./student ./repo

mkdir tests && cd tests
ls -all /app
cp -rf "/app/${EXERCISE}Tests" /app/tests.csproj .

dotnet restore --packages /dotnetpkg
dotnet test --filter $EXERCISE --no-restore
