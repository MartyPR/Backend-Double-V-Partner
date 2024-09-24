# Discutir decisiones de diseño y arquitectura
En este apartado, describirás las principales decisiones que tomaste durante el desarrollo. Aquí tienes un ejemplo de cómo podrías redactarlo para cada parte del proyecto.

Back-End (API .NET Core)
## Diseño y arquitectura:

Se optó por ASP.NET Core y Entity Framework Core debido a su integración fluida con bases de datos relacionales y la facilidad para generar APIs RESTful de manera eficiente.
Se utilizó el patrón de diseño Repository para mantener el acceso a datos desacoplado de los controladores, lo que facilita la mantenibilidad y escalabilidad del código.
La separación en capas (Models, Controllers, Data) permite un mejor manejo de la lógica de negocio y facilita futuras expansiones del proyecto.
Justificación de Entity Framework:

Entity Framework fue elegido como ORM para aprovechar la generación automática de SQL y el manejo de las migraciones, lo cual facilita el desarrollo y reduce el riesgo de errores manuales.

## Desafíos en el Back-End:

Manejo de relaciones en Entity Framework: Al definir las relaciones entre Producto, Categoria, y ProductoDeseado, fue necesario ajustar la configuración del DbContext y las migraciones para asegurar que las llaves foráneas se manejen correctamente. Se resolvió mediante la correcta implementación de las entidades y las convenciones de EF Core.
Optimización de consultas: Durante el desarrollo, se observó que las consultas a la base de datos podían ser más eficientes. Se resolvió utilizando eager loading (Include) para cargar relaciones necesarias al momento de consultar productos.
