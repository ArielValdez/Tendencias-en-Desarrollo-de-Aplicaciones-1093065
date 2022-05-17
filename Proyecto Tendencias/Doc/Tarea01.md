# Tarea 01

**1. ¿Qué es un Coding Dojo? referencia https://lorenzosolano.com/what-is-coding-dojo/

Este se puede definir como un conjunto de programadores que se reúnen para completar un desafío en un periodo corto de tiempo, 
de índole de software/programación, con el objetivo de, además de por diversión, mejorar habilidades como programador.


**2. Diferencia entre Requerimientos, Criterios de Aceptación y Escenarios de Prueba. Dar ejemplos a partir de un problema distinto a la referencia. 
Referencia https://lorenzosolano.com/requirements-acceptance-criteria-and/

Un requerimiento, es una propiedad exigida en un producto, para poder resolver un problema. 
Este expresa las necesidades y los límites que existen en el producto de software que, como mencionado anteriormente, 
contribuye a una solución. Los criterios de aceptación indican como se deberían juzgar un componente de software o sistema que 
satisfaga ciertos requerimientos; cada uno de estos elementos de criterio, especifica una declaración.
Los escenarios son un conjunto de ejemplos que indican las aceptaciones de criterios, y estos validan un solo criterio de aceptación.

Ejemplo de Aplicación local registro de usuarios

*Requerimientos:
- Req-00: La aplicación debe poder registrar usuarios.
- Req-01: La aplicación debe registrar usuarios con un rol.
- Req-02: La aplicación debe ser capaz revisar sus datos en la aplicación.

*Criterios de aceptación:

Estos son los criterios de aceptación para el primer requerimiento, Req-00
- Cri-00-1: La aplicación no debe registrar dos personas con el mismo ID.
- Cri-00-2: La aplicación debe registrar a un usuario externo con un rol de menor jerarquía, por defecto.

*Escenarios:
- Sce-00-1-1: 
  - Usuario registrado: ID = 0, Nombre = Abel Lorenzo
  - Usuario a registrar: ID = 0, Nombre = Ariel Francesco
    - Error
- Sce-00-2-1:
  - Usuario a registrar: Nombre = Abel Lorenzo, Rol = Usuario


**3. De dos ejemplos de requerimientos no-funcionales, y especifique cuál es su categoría (seguridad, performance, portabilidad, etc.)

*De seguridad:
- Sistemas de gestión de usuarios, con sus roles (y permisos) y prefiles.
- El sistema, cuando se solicite información personal del usuario final, debe establecer mecanismos de conexión para obtener la autorización y pruebas de ellos, o “logs”.

*De portabilidad:
- Transferencias de datos de un banco a otro
- Un software debe ser capaz de correr en diferentes plataformas, por ejemplo: Windows, Mac y Linux.


**4. ¿Qué es TDD?

Desarrollo dirigido por pruebas, Test-Driven Development o TDD es una metodología en la cual consiste en crear las pruebas,
normalmente unitarias, y después escribir el código fuente basado en la prueba que se diseñó anteriormente, y, últimamente, 
refactorizar el código escrito.


**5. ¿Que son pruebas unitarias automatizadas?

Consisten en la aplicación de herramientas de software para automatizar el proceso manual de revisión y 
validación de un producto de software que lleva a cabo una persona. La mayoría de los proyectos de software ágiles de DevOps
modernos incluyen pruebas automatizadas desde el principio.


**6. ¿Cuál fue el 1er framework de pruebas unitarias y para cual lenguaje fue creado?

xUnit o sUnit, para Java y C#.


**7. ¿Describa los componentes de la arquitectura xUnit?

Es el nombre colectivo de varios marcos de pruebas unitarias que derivan su estructura y funcionalidad de SUnit de Smalltalk. 
Los nombres de muchos de estos marcos son una variación de "SUnit", generalmente reemplazando la "S" con la primera letra (o letras)
en el nombre de su lenguaje previsto. Estos marcos y su arquitectura común se conocen colectivamente como "xUnit".

*Arquitectura:
- Test runner: Es un ejecutable que corre pruebas implementadas, usando xUnit y reporta los resultados de dicha prueba.
- Test cases: Es una clase elemental. Todas las pruebas unitarias son heredadas de esta.
- Test fixtures: Es una serie de precondiciones o estados que se necesitan para poder correr una prueba.
- Test suites: Es un conjunto de pruebas que comparte un fixture o accesorio.
- Test execution: Contienen métodos como “setup()” o “teardown()”.
- Test result formatter: Producen resultados de un test runner.
- Assertions: Es una función o macro que verifica el comportamiento o estado de as unidades en una prueba.


**8. Indique al menos tres desventajas de las pruebas unitarias automatizadas

- No siempre fiables: Un escenario mal definido puede arrojar falsas alarmas y se puede romper por algún cambio de librerías, interfaz de usuario, problemas de red.
- Esfuerzo de mantenimiento: Requieren que se les den mantenimiento, en conjunto con los programas.
- Impactos de diseño: A veces, el diseño no está claro al principio y evoluciona a medida que avanza, que obliga rehacer la prueba.

**9. Indique al menos tres ventajas de las pruebas unitarias automatizadas
- Calidad del código: Realización pruebas continuamente y detectar errores, cuando el código está terminado, es un código limpio y de calidad.
- Detección de errores: Las pruebas unitarias permiten detectar errores rápidamente, analizar el código por partes, haciendo pequeñas pruebas.
- Reducción de costo: Partiendo de la base de que errores se detectan a tiempo, lo cual implica tener que escribir menos código, poder diseñar a la vez que se crea y optimizar los tiempos de entrega, vemos una clara relación con una reducción económica.

**10. Tomando el algoritmo de conversión de números arábigos o "decimales" a números Romanos:
- Cree un documento donde se listen los Requerimientos, Criterios de Aceptación y Casos de Prueba para una aplicación de consola
- Los casos de prueba deben ser de dos categorías: End-To-End (desde el UI) y Unitarios (caja blanca, código, bajo nivel)

*Requerimientos
- Req-1: Los números decimales deben representar sus equivalentes romanos.
- Req-2: Debería poder expresarse de este modo con cualquier número decimal.

*Criterios de aceptación
- Cri-2-1: Los números romanos se presentan como una suma.
  - MCXI = 1000 + 100 + 10 + 1

*Casos de prueba
- 1 = I
- 5 = V
- 10 = X
- 11 = XI
- 100 = C

 
**11. Utilizando el lenguaje de su preferencia cree cinco o más casos de prueba unitarios automatizados utilizando un framework de automatización de pruebas para el algoritmo en cuestión
Utilizando Test cases en Visual Studio

``` C#
[TestClass]
Public class TD._01.Tests
{
	[TestMethod]
	Public class TestMethod1()
{
		Var validateSSN = new Program();
		Var resultado = validateSSN.SSNArray(“”);
		Assert.Matches(“Invalid”, resultado);
	}
  
[TestMethod]
	Public class TestMethod2()
{
		Var validateSSN = new Program();
		Var resultado = validateSSN.SSNArray(“123-aaa-0001”);
		Assert.Matches(“Invalid”, resultado);
	}
  
[TestMethod]
	Public class TestMethod3()
{
		Var validateSSN = new Program();
		Var resultado = validateSSN.SSNArray(“555-23-0001”);
		Assert.Matches(“Valid”, resultado);
	}
  
[TestMethod]
	Public class TestMethod4()
{
		Var validateSSN = new Program();
		Var resultado = validateSSN.SSNArray(“555-55-5555-5”);
		Assert.Matches(“Invalid”, resultado);
	}
  
[TestMethod]
	Public class TestMethod5()
{
		Var validateSSN = new Program();
		Var resultado = validateSSN.SSNArray(“0-0-0”);
		Assert.Matches(“Invalid”, resultado);
	}
}
```
