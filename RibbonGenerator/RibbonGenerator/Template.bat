"{Windows7SDKToolsPath}UICC.exe" "{XmlFilename}" "{BmlFilename}" /res:"{RcFilename}"
"{Windows7SDKToolsPath}rc.exe" /v "{RcFilename}"
cmd /c "("%VS140COMNTOOLS%..\..\VC\bin\vcvars32.bat") && ("%VS140COMNTOOLS%..\..\VC\bin\link.exe" /VERBOSE /NOENTRY /DLL /OUT:"{DllFilename}" "{ResFilename}")"