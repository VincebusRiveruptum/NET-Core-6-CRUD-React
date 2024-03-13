TODO: 

BACK
	- Crear Proyecto React + ASP.NET Core 6				OK
	- Conectar SQLite al servidor :					OK

		- Para el ORM se utilizará Entity Framework 6 con SQLite
	
			dotnet add package Microsoft.EntityFrameworkCore --version 6.0.0

		- Instalacion de SQlite
	
			dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.0
	
		- Instalación de EF Core Micrations
	
			dotnet tool install -g dotnet-ef
	
		- Instalacion de EF Core Desing
	
			dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.0

		- Generación de Migraciones

			dotnet ef migrations add InitialCreate
			dotnet ef database update

	- Crear Entities y Migraciones					OK
		- Banks							OK
	- Implementar consumo de api random				OK, CORREGIR
		- Seeding						MEH
		- Utilizar HttpClient Class				MEH
	- Implementar controladores					OK	
		- Implementar solicitudes REST				OK
			- REVISAR
	- ELIMINAION LÓGICA
		- FECHA DE MODIFCIACION Y ELIMINACION

FRONT
	- Escojer una plantilla 					OK
	- Implementar vista principal					OK
			- Agregar
			- Editar
			- Eliminar de forma lógica
	- Axios									OK
	- STORE								OK
	- CONECTAR API A FRONT						OK
	- IMPLEMENTAR BUSQUEDA POR GUID O ID
	- IMPLEMENTAR AGREGAR
	- IMPLEMNTAR ELIMINAR LOGICAMENTE
		- IMPLEMENTAR FLAG DE ELIMINACIÓN CON FECHA
	- IMPLEMENTAR MODIFICACIÓN
		- IMPLEMENTAR FLAG DE MODIFICACIÓN
	- IMPLEMENTAR ESTILO
	- IMPLEMENTAR PAGINACIÓN


	