# Tendencias-en-Desarrollo-de-Aplicaciones-1093065
## User Manual
1. git clone https://github.com/ArielValdez/Tendencias-en-Desarrollo-de-Aplicaciones-1093065.git
2. cd ".\Tendencias-en-Desarrollo-de-Aplicaciones-1093065\Proyecto Tendencias\TD.01\bin\Debug\netcoreapp3.1"
4. dotnet run "333-01-9999" -> Valid
5. dotnet run "666-00-0000" -> Invalid

## Requirements
SSN Validation: It is required an SSN validation.
It has to fullfil the following conditions:
1. It must have exactly nine (9) digits,
2. It must be separated in three (3) parts, separated by a hyphen (-),
3. The first part must have exactly 3 digits.
    1. These digits must not have the following digits: 000, 666, nor between 900 and 999,
4. The second part must have exavtly two (2) digits:
    1. It must be between 01 and 99,
5. The third part must have exactly four (4) digits:
    1. It must be between 0001 and 9999.

## Manual Tests
1. Allow the program to read from console command prompt arguments,
2. The program should separate the elements into three (3) in an array,
3. It must complete the requirements mentioned previously,
4. The test cases, in string, must be:
    1. " " = Invalid, 
    2. "000-00-0000" = Invalid,
    3. "333-01-0001" = Valid, 
    4. "666-01-0001" = Invalid, 
    5. "952-01-0001" = Invalid, 
    6. "99-01-0001" = Invalid,
    7. "333-00-0001" = Invalid, 
    8. "333-99-0001" = Valid,
    9. "333-99-0000" = Invalid,
    10. "333-99-100" = Invalid,
    11. "333-99-3333" = Valid
