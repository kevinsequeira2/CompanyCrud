
1. dotnet new webapi -o CompanyApi
2. dotnet run
3. dotnet add package Npgsql
4. dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
5. dotnet add package EFCore.NamingConventions
6. dotnet add package Microsoft.EntityFrameworkCore.Design
7. dotnet tool install --global dotnet-ef
8. dotnet ef migrations add InitialMigration
9. dotnet ef database update


Notas:

Volver a una migración especifica:

dotnet ef database update InitialMigration


Table
    Id
    ForeignKeyId

table
    id
    foreign_key_id


Taller:
1. Agregar modelo Employee
2. Agregar relaciones en los modelos
3. Crear nueva migración
4. Actualizar la base de datos con la migración creada.
5. Crear controlador EmployeesController con todas las operaciones CRUD
6. Crear nueva ruta https://localhost:5001/api/branches/1/employees
7. Estudiar para el quiz.