# Rebuilds the Endpoint API-reference docs on the website.
#
# 1. Builds the GHIElectronics.Endpoint.Libraries .NET solution in Release
#    (produces the DLLs + XML doc files the generator reads).
# 2. Runs the generator against the freshly built DLLs, writing MDX into
#    docs/endpoint/api-reference/{dotnet,python,cpp}/.
#
# Run this whenever you add, rename, or change a class or method in
# Endpoint-Libraries and want the website to reflect it. Pass -NoBuild to
# skip step 1 when the DLLs are already up to date.

[CmdletBinding()]
param(
    [string] $LibsRoot   = 'C:\Projects\2026\Endpoint\Endpoint-Libraries\Dotnet\GHIElectronics.Endpoint.Libraries',
    [string] $Configuration = 'Release',
    [switch] $NoBuild
)

$ErrorActionPreference = 'Stop'

$scriptDir  = Split-Path -Parent $MyInvocation.MyCommand.Path
$websiteDir = Split-Path -Parent $scriptDir
$genProj    = Join-Path $scriptDir 'endpoint-api-gen\EndpointApiGen.csproj'
$outDir     = Join-Path $websiteDir 'docs\endpoint\api-reference'

if (-not $NoBuild) {
    $sln = Join-Path $LibsRoot 'GHIElectronics.Endpoint.Libraries.sln'
    if (-not (Test-Path $sln)) { throw "Solution not found: $sln" }
    Write-Host "[api] building $sln ($Configuration)..." -ForegroundColor Cyan
    dotnet build $sln -c $Configuration --nologo -v minimal
    if ($LASTEXITCODE -ne 0) { throw "dotnet build failed with exit code $LASTEXITCODE" }
}

Write-Host "[api] regenerating MDX under $outDir ..." -ForegroundColor Cyan
dotnet run --project $genProj -c Release -- --libs $LibsRoot --out $outDir
if ($LASTEXITCODE -ne 0) { throw "endpoint-api-gen failed with exit code $LASTEXITCODE" }

Write-Host "[api] done." -ForegroundColor Green
