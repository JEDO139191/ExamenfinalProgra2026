a. Decisiones 
Utilicé la entidad producto para almacenar la información con id, nombre, precio
y stock. El proyecto fue organizado para mantener una estructura clara con CONTROLLERS,
MODELO, DATA Y MIGRATIONS. De esta manera es más fácil darle mantenimiento y mejorar
el proyecto.

b. secuencia de comandos
Instalación de herramientas:

dotnet tool install --global dotnet-ef

Creación de migración:

dotnet ef migrations add InitialCreate

Aplicación de migración:

dotnet ef database update

c. comandos docker utilizados
creacion de contenedor
docker run --name mysql-productos -e MYSQL_ROOT_PASSWORD=123456 -e MYSQL_DATABASE=productosdb
 -p 3306:3306 -d mysql:8.0

Verificar contenedores:

docker ps

Ver todos los contenedores:

docker ps -a

Iniciar contenedor:

docker start mysql-productos

d. Trabajo manualmente y con asistencia de IA
Manualmente
Creación de la API Web en ASP.NET Core.
Implementación de la entidad Producto.
Creación del controlador ProductosController con operaciones CRUD.
Pruebas de los endpoints mediante Swagger.

con IA 
Con asistencia de IA
Orientación para configurar Entity Framework Core.
Apoyo para resolver errores de paquetes NuGet.
Apoyo para configurar la conexión a MySQL.
Apoyo para generar migraciones y verificar el funcionamiento del CRUD.
Revisión de la documentación solicitada en el examen.
Diagnóstico del error Swagger/OpenAPI