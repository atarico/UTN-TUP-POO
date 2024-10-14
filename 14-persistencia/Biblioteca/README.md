> [!NOTE]
> Todo el proyecto tiene comentarios a modo de documentación para un mayor entendimiento

## Diagrama

<div align="center"> 
    <img src="../Biblioteca/Biblioteca/diagrama_biblioteca.svg" style="background-color: gray; padding: 10px;" />
</div>

> [!IMPORTANT]

## Estructura del Proyecto

El proyecto está organizado en diferentes clases dentro del namespace `Biblioteca.Models`:

- `Libro`: Representa un libro en la biblioteca con propiedades como código, título, autor y ejemplares disponibles.

- `Prestamo`: Registra un préstamo de un libro, almacenando la fecha de préstamo y devolución.

- `Usuario`: Representa un usuario de la biblioteca que puede tener varios préstamos.

- `SysBiblioteca`: Contiene la lógica para gestionar los libros, usuarios y operaciones como préstamos, devoluciones, guardar y cargar datos.

- `Menu`: Proporciona las opciones de interacción para el usuario, como agregar libros, usuarios, realizar préstamos y devoluciones.

- `Program`: El punto de entrada del programa donde se muestra un menú interactivo para operar el sistema.

## Funcionalidades

- `Agregar Libros`: Permite agregar un nuevo libro con un código, título, autor y cantidad de ejemplares disponibles.

- `Agregar Usuarios`: Registra un nuevo usuario con su nombre.

- `Realizar Préstamos`: Realiza un préstamo si hay ejemplares disponibles, asignando un libro a un usuario y reduciendo los ejemplares disponibles.

- `Devolver Libros`: Devuelve un libro, aumentando el número de ejemplares disponibles y eliminando el préstamo asociado al usuario.

- `Guardar y Cargar Datos`: Los datos de libros y usuarios, junto con sus préstamos, se almacenan en archivos de texto para persistencia.

## Archivos

- `Libros.txt`: Almacena la información de los libros.

- `Usuario.txt`: Almacena los datos de los usuarios y sus préstamos.

## Cómo Usar el Sistema

Al iniciar, el sistema carga los datos de los libros y usuarios desde los archivos de texto.
El usuario puede elegir entre las siguientes opciones del menú:

1. Agregar libro.
2. Agregar usuario.
3. Realizar préstamo.
4. Devolver libro.
5. Guardar y salir.

   Al elegir la opción de "Guardar y Salir", los datos actualizados se guardarán en los archivos.

> [!TIP]

## Ejercitaciones y Mejoras

`Usuario.cs`

**_Mejoras sugeridas:_**

Agregar un método para obtener la cantidad de préstamos actuales del usuario.
Incluir un método que verifique si el usuario tiene préstamos vencidos.
Implementar un método ToString() para representar al usuario como una cadena de texto.

`LibroUsuario.cs`

**_Mejoras sugeridas:_**

- Esta clase actualmente no tiene un constructor explícito. Podría ser beneficioso agregar un constructor que inicialice tanto el Libro como el Usuario, asegurando que ambos estén siempre definidos:

```csharp
public LibroUsuario(Libro libro, Usuario usuario)
{
    Libro = libro ?? throw new ArgumentNullException(nameof(libro));
    Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
}
```

<u>Consideraciones adicionales:</u>

- Agregar una propiedad para la fecha de la asociación, especialmente si esta clase se utiliza para representar préstamos o reservas.
- Incluir métodos para validar la relación o realizar acciones específicas, como registrar la devolución de un libro.
- Considerar hacer las propiedades de solo lectura (con setters privados) para garantizar la inmutabilidad de la relación una vez establecida.

`SysBiblioteca`

**_Mejoras sugeridas:_**

- En la carga de datos de usuarios y préstamos, si el libro no se encuentra, el préstamo se ignora silenciosamente. Se podría manejar este caso con una advertencia o mensaje.
- <u>Métodos adicionales sugeridos:</u>
  - Buscar libros por título, autor, etc.
  - Generar reportes de préstamos activos o vencidos.
  - Implementar un sistema de reservas de libros.
  - Manejar multas por retrasos en las devoluciones.

`Menu`

**_Mejoras sugeridas:_**

- Incluir opciones para listar todos los libros o usuarios en el sistema.
- Implementar búsqueda de libros o usuarios por diferentes criterios.
- Mostrar los préstamos actuales de un usuario específico.
- Generar reportes o estadísticas del sistema de biblioteca.
