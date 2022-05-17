# Manual Tests
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
