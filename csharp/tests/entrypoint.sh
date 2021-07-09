#!/bin/sh

set -e

cd /jail

dotnet nuget disable source nuget.org
dotnet nuget add source /dotnetpkg

cp -rf /app ./tests
cp -rf ./student ./repo

cd tests

dotnet restore --packages /dotnetpkg
dotnet test --filter $EXERCISE --no-restore
