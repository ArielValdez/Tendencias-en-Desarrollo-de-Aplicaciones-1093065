# Tendencias-en-Desarrollo-de-Aplicaciones-1093065
# Requeriminetos 
Validación de SSN: Se requiere poder validar SSN
  Tiene que cumplir con las siguientes condiciones:
    - Debe tener exactamente 9 dígitos,
    - Debe estar separado en 3 partes, separados pr un guión (-),
      -- La primera parte debía tener exactamente 3 dígitos
            * Los dígitos no deberían tener los dígitos 000, 666, o ninguno entre 900 y 999.
      -- La segunda parte debería tener exactamente 2 dígitos
            * Debe se entre 01 y 99.
      -- La tercera parte debería tener exactamente 4 dígitos
            * Debe ser entre 0001 a 9999

# Casos de uso


# Descarga
1. git clone {repositorio}
2. cd repo-directorio
3. dotnet run "prueba"
4. Muestra debe mostrar "Valido" o "Inválido", según el número puesto
