@ECHO OFF
REM ===========================================================================
REM  build_endpoint_api.bat
REM
REM  Regenerates docs\endpoint\api-reference from the compiled GHIElectronics.Endpoint.*
REM  libraries. The GitHub Pages build does NOT run this -- it just serves the
REM  committed output as-is. Run this locally whenever the Endpoint libraries
REM  change, then COMMIT the updated files.
REM
REM  Requires:
REM    - .NET 10 SDK on PATH
REM    - The sibling Endpoint repo checked out at ..\..\Endpoint\, so the full
REM      path is c:\Projects\2026\Endpoint\ when ghi-website lives at
REM      c:\Projects\2026\TinyCLROS\ghi-website\. Override with --libs.
REM
REM  Pipeline:
REM    1. Build the Endpoint libraries in Release mode (so each .dll has a
REM       matching .xml next to it from <GenerateDocumentationFile>).
REM    2. Run the C# generator (scripts\endpoint-api-gen) against those DLLs,
REM       writing to docs\endpoint\api-reference\.
REM
REM  Optional args pass through to the generator, e.g.:
REM     build_endpoint_api.bat --version 0.4.1
REM     build_endpoint_api.bat --libs "D:\path\to\Endpoint-Libraries"
REM ===========================================================================
SETLOCAL

SET "WEB_ROOT=%~dp0"
SET "DEFAULT_LIBS=%WEB_ROOT%..\..\Endpoint\Endpoint-Libraries\Dotnet\GHIElectronics.Endpoint.Libraries"
SET "GEN_PROJ=%WEB_ROOT%scripts\endpoint-api-gen\EndpointApiGen.csproj"
SET "OUT_DIR=%WEB_ROOT%docs\endpoint\api-reference"

WHERE dotnet >NUL 2>NUL
IF ERRORLEVEL 1 (
  ECHO [build_endpoint_api] ERROR: dotnet was not found on PATH. Install the .NET 10 SDK and retry.
  EXIT /B 1
)

REM If --libs was passed explicitly, skip the build step (user chose their own path).
SET "SKIP_BUILD=0"
FOR %%A IN (%*) DO (
  IF /I "%%A"=="--libs" SET "SKIP_BUILD=1"
)

IF "%SKIP_BUILD%"=="0" (
  IF NOT EXIST "%DEFAULT_LIBS%\" (
    ECHO [build_endpoint_api] ERROR: Endpoint libraries not found at:
    ECHO     %DEFAULT_LIBS%
    ECHO   Clone/checkout Endpoint next to the TinyCLROS tree, or pass --libs ^<path^>.
    EXIT /B 1
  )
  ECHO [build_endpoint_api] Building Endpoint libraries (Release, --nologo) ...
  dotnet build "%DEFAULT_LIBS%\GHIElectronics.Endpoint.Libraries.sln" -c Release --nologo
  IF ERRORLEVEL 1 (
    ECHO [build_endpoint_api] FAILED ^(dotnet build^).
    EXIT /B 1
  )
  SET "LIBS_FOR_GEN=%DEFAULT_LIBS%"
) ELSE (
  SET "LIBS_FOR_GEN="
)

ECHO [build_endpoint_api] Running API generator into docs\endpoint\api-reference ...
IF "%LIBS_FOR_GEN%"=="" (
  dotnet run --project "%GEN_PROJ%" -c Release --nologo -- --out "%OUT_DIR%" %*
) ELSE (
  dotnet run --project "%GEN_PROJ%" -c Release --nologo -- --libs "%LIBS_FOR_GEN%" --out "%OUT_DIR%" %*
)
IF ERRORLEVEL 1 (
  ECHO [build_endpoint_api] FAILED.
  EXIT /B 1
)

ECHO.
ECHO [build_endpoint_api] Done. Review the changes and COMMIT docs\endpoint\api-reference.
ENDLOCAL
