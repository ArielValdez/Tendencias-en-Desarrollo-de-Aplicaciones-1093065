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

# Descarga
1. git clone https://github.com/ArielValdez/Tendencias-en-Desarrollo-de-Aplicaciones-1093065.git
2. cd "Tendencias en Desarrollo de Aplicaciones 1093065"
3. dotnet run "333-01-9999"
4. dotnet run "666-00-0000"
5. Muestra debe mostrar "Valido" o "Inválido", según el número puesto
