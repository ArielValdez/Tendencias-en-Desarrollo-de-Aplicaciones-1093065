# Tendencias-en-Desarrollo-de-Aplicaciones-1093065
## User Manual
These are programs coded in the multiparadigm programming language **C#,** with the framework technology `.NetCore 3.1`. The name of the project is as followed: `TD.01`.

The user, with this program, can verify a sequence of numbers, as followed in the requirements linked below, which is the SSN.

To be able to download the project, follow the instructions below:
1. git clone https://github.com/ArielValdez/Tendencias-en-Desarrollo-de-Aplicaciones-1093065.git
2. cd ".\Tendencias-en-Desarrollo-de-Aplicaciones-1093065\Proyecto Tendencias\TD.01"
3. dotnet run "333-01-9999" -> Valid 
   
   (This is valid, because this completes satisfactorily the requirements to make this a valid SSN)
  - OR: dotnet run "666-00-0000" -> Invalid 
  
  (This is invalid, because an SSN does not validates numbers like 000, 666 or between 900 and 999 in the first part,
  00 in the second and 0000 in the third parts)

If you do not have the framework `.NetCore 3.1`, please use the following command:
- Install-Package Microsoft.NETCore.Platforms -Version 3.1.1

**Below, the documents "Requirement document" and "Manual tests" for the project *TD.01***
- Requirement Document link: https://github.com/ArielValdez/Tendencias-en-Desarrollo-de-Aplicaciones-1093065/blob/main/Proyecto%20Tendencias/Doc/Requirements.md
- Manual Tests link: https://github.com/ArielValdez/Tendencias-en-Desarrollo-de-Aplicaciones-1093065/blob/main/Proyecto%20Tendencias/Doc/ManualTests.md
