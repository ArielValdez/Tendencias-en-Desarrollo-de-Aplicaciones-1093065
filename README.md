# Tendencias-en-Desarrollo-de-Aplicaciones-1093065
# Requeriminetos 
Validación de SSN: Se requiere poder validar SSN
Tiene que cumplir con las siguientes condiciones:
1. Debe tener exactamente 9 dígitos,
2. Debe estar separado en 3 partes, separados pr un guión (-),
3. La primera parte debía tener exactamente 3 dígitos. Los dígitos no deberían tener los dígitos 000, 666, o ninguno entre 900 y 999.
4. La segunda parte debería tener exactamente 2 dígitos: Debe ser entre 01 y 99.
5. La tercera parte debería tener exactamente 4 dígitos: Debe ser entre 0001 a 9999

# Pruebas manuales
1. Permitir que el programa lea desde los argumentos de una consola
2. El programa lea 3 divisiones en un array
3. Cumpla con los requisitos mencionados anteriormente
4. Los casos de pruebas string serán: 
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

# Descarga
1. git clone https://github.com/ArielValdez/Tendencias-en-Desarrollo-de-Aplicaciones-1093065.git
2. cd "\Tendencias-en-Desarrollo-de-Aplicaciones-1093065\TD.01\program.cs"
3. dotnet run "333-01-9999"
4. dotnet run "666-00-0000"
5. Muestra debe mostrar "Valido" o "Inválido", según el número puesto
