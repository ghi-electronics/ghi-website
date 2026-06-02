@ECHO OFF
REM ===========================================================================
REM  build_tinyclr_api.bat
REM
REM  Regenerates the TinyCLR API reference (docs\tinyclr\api) from the C# source
REM  in the sibling ..\TinyCLR-Libraries repository.
REM
REM  RUN THIS LOCALLY whenever the TinyCLR libraries change, then COMMIT the
REM  updated docs\tinyclr\api folder. The automatic GitHub Pages build does NOT
REM  run this step -- it just uses the committed docs\tinyclr\api as-is. That
REM  keeps the cloud build fast and independent of the TinyCLR-Libraries repo.
REM
REM  Requires: Node.js, and ..\TinyCLR-Libraries checked out next to ghi-website.
REM
REM  Optional args are passed straight through to the generator, e.g.:
REM     build_tinyclr_api.bat --only Devices.Gpio
REM     build_tinyclr_api.bat --libs "D:\path\to\TinyCLR-Libraries"
REM ===========================================================================
SETLOCAL

SET "WEB_ROOT=%~dp0"
SET "LIBS_DIR=%~dp0..\TinyCLR-Libraries"

WHERE node >NUL 2>NUL
IF ERRORLEVEL 1 (
  ECHO [build_tinyclr_api] ERROR: Node.js was not found on PATH. Install Node and retry.
  EXIT /B 1
)

IF NOT EXIST "%LIBS_DIR%\" (
  IF "%~1"=="" (
    ECHO [build_tinyclr_api] ERROR: Could not find the TinyCLR libraries at:
    ECHO     %LIBS_DIR%
    ECHO   Clone/checkout TinyCLR-Libraries next to ghi-website, or pass --libs ^<path^>.
    EXIT /B 1
  )
)

ECHO [build_tinyclr_api] Generating TinyCLR API reference into docs\tinyclr\api ...
node "%WEB_ROOT%scripts\generate-api.mjs" %*
IF ERRORLEVEL 1 (
  ECHO [build_tinyclr_api] FAILED.
  EXIT /B 1
)

ECHO.
ECHO [build_tinyclr_api] Done. Review the changes and COMMIT docs\tinyclr\api.
ENDLOCAL
