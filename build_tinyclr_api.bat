@ECHO OFF
REM ===========================================================================
REM  build_tinyclr_api.bat
REM
REM  Regenerates the TinyCLR-specific generated artifacts and (as always with the
REM  cloud build) leaves you to COMMIT the results:
REM    1. static\bin\fw\tinyclr_firmware.json  -- the firmware manifest the Visual Studio
REM       extension fetches to detect out-of-date devices. Derived from the
REM       Firmware table in docs\tinyclr\downloads.mdx (only needs Node).
REM    2. docs\tinyclr\api             -- the API reference, from the C# source in
REM       the sibling ..\TinyCLR-Libraries repository.
REM
REM  RUN THIS LOCALLY whenever downloads.mdx or the TinyCLR libraries change, then
REM  COMMIT the updated files. The automatic GitHub Pages build does NOT run this
REM  step -- it just serves the committed output as-is. That keeps the cloud build
REM  fast and independent of the TinyCLR-Libraries repo.
REM
REM  Requires: Node.js, and ..\TinyCLR-Libraries checked out next to ghi-website.
REM
REM  Optional args are passed straight through to the API generator, e.g.:
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

REM --- Firmware manifest -----------------------------------------------------
REM  Only reads docs\tinyclr\downloads.mdx, so run it first, independent of the
REM  TinyCLR-Libraries check below.
ECHO [build_tinyclr_api] Generating firmware manifest into static\bin\fw\tinyclr_firmware.json ...
node "%WEB_ROOT%scripts\generate-firmware-manifest.mjs"
IF ERRORLEVEL 1 (
  ECHO [build_tinyclr_api] FAILED ^(firmware manifest^).
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
ECHO [build_tinyclr_api] Done. Review the changes and COMMIT docs\tinyclr\api and static\bin\fw\firmware.json.
ENDLOCAL
