REM Descarga ZIP
powershell -Command "(New-Object Net.WebClient).DownloadFile('http://www.afip.gob.ar/genericos/cInscripcion/archivos/apellidoNombreDenominacion.zip', 'C:\DRIVERS\apellidoNombreDenominacion.zip')"

REM Extrae ZIP
"C:\Program Files\7-Zip\7z.exe" e C:\DRIVERS\apellidoNombreDenominacion.zip -oC:\DRIVERS\test

pause