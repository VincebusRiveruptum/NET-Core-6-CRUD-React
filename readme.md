Para esta prueba técnica se utilizó el siguiente stack:

- Back End :
	- ASP.NET Core 6.0
 	- Entity Framework para la interacción con la base de datos y los controladores.
    	- HttpClass para la conexión de la API random: Se escogió esta libreria para conectar a la API Random por ser el mas usual y recomendado por Microsoft.
    	- Swagger para la documentación de los métodos de la API: Swagger venía junto a la plantilla de Proyecto React + ASP Net Core de Visual Studio Community por lo que su uso fue sencillo.
    	- SQLite para el motor de base de datos, junto con DB Browser para visualizar los cambios de la base de datos.
- Front End:
 	- React + Redux y Hooks 
     	- Axios para las conexión a la API
        - Styled Components para estilo de la app, se escogió esta libreria ya que es la que considero la mas fácil y rapida de manejar.
- IDE:
  	- Visual Studio Community
  
La app esta programada completamente en inglés y contiene algunos comentarios.
 
Para ejecutar el proyecto hay que instalar las dependencias del codigo del cliente y el servidor, para ello simplemente utilizar npm i y dotnet restore, respectivamente.

El seeding se realiza durante la primera migración, sin embargo se adjunta el archivo db en caso de algún inconveniente.

Hecha por Vicente Riveros Garay, 2024.


	
