# Sistema de Gestión Escolar

> La "Escuela Angelitos" es una institución educativa donde cada aula tiene su propio grupo de estudiantes y está bajo la guía de un profesor dedicado. Los estudiantes se inscriben en diferentes aulas según su nivel y cada aula está diseñada para proporcionar un ambiente de aprendizaje óptimo. María López, la profesora de Matemáticas, y Carlos García, el profesor de Ciencias, son dos de los profesores que trabajan en esta escuela. María enseña en el Aula 1, donde Ana de 10 años y Luis de 11 años son sus estudiantes. Carlos enseña en el Aula 2, donde su única estudiante es Elena de 10 años de edad.
>
> El director de la escuela, Juan Pérez, ha estado trabajando en la institución durante los últimos 15 años y tiene una vasta experiencia en la administración escolar. Él se encarga de supervisar todas las operaciones de la escuela y asegurar que todo funcione sin problemas.
>
> Recientemente, Juan ha decidido implementar un sistema de gestión para la escuela que le permita tener una visión clara de cada aula, los profesores asignados y los estudiantes inscritos en cada una de ellas. Este sistema debe ser capaz de mostrar detalles sobre la escuela, incluyendo la información del administrador, los profesores, y los estudiantes de cada aula.

#### Tu tarea:

Ayuda a Juan a implementar este sistema de gestión escolar. Necesitas desarrollar un programa que represente la estructura de la escuela, las aulas, los estudiantes y los profesores. El sistema debe permitir a Juan ingresar y visualizar la información detallada de la escuela, incluidas las aulas con sus respectivos profesores y estudiantes, así como la información del administrador.

## Estructura del Proyecto

El proyecto se organiza en las siguientes carpetas y archivos:

- **Interfaces**:

  - `IListaEditable<T>`: Define métodos para añadir y quitar elementos de una lista.
  - `IMostrable`: Define el método `MostrarDetalles`, que es implementado por todas las entidades que deben mostrar su información.

- **Modelos**:

  - `EntidadConNombre`: Clase base que contiene la propiedad `Nombre` y un método virtual `MostrarDetalles`. Es la clase base de todas las entidades con nombre en el sistema.
  - `Administrador`: Representa al administrador de la escuela. Hereda de `EntidadConNombre` y añade la propiedad `Experiencia`.
  - `Aula`: Representa un aula en la escuela. Hereda de `EntidadConNombre` e implementa `IListaEditable<Estudiante>`, permitiendo la gestión de los estudiantes en el aula. También tiene una relación con la clase `Profesor`.
  - `Escuela`: Representa a la escuela en sí. Hereda de `EntidadConNombre` e implementa `IListaEditable<Aula>`, permitiendo la gestión de las aulas en la escuela. También contiene un objeto `Administrador`.
  - `Estudiante`: Representa a un estudiante. Hereda de `EntidadConNombre` y añade la propiedad `Edad`.
  - `Materia`: Representa una materia que un profesor puede enseñar. Hereda de `EntidadConNombre` y añade la propiedad `Creditos`.
  - `Profesor`: Representa a un profesor de la escuela. Hereda de `EntidadConNombre` e implementa `IListaEditable<Materia>`, permitiendo la gestión de las materias que enseña.

- **Program**:
  - `Program`: Punto de entrada del sistema. Aquí es donde se podría inicializar y ejecutar el sistema (actualmente está vacío).

## Principios de Programación Orientada a Objetos (POO) Aplicados

1. **Herencia**:

   - `Administrador`, `Aula`, `Escuela`, `Estudiante`, `Materia`, y `Profesor` heredan de `EntidadConNombre`, compartiendo propiedades y métodos comunes como `Nombre` y `MostrarDetalles`.

2. **Polimorfismo**:

   - El método `MostrarDetalles` es virtual en la clase base `EntidadConNombre` y es sobrescrito (`override`) en las clases derivadas, lo que permite que cada clase implemente su versión específica de la funcionalidad de mostrar detalles.

3. **Encapsulamiento**:

   - Las propiedades de las clases están encapsuladas, utilizando métodos `get` y `set` para controlar el acceso y la modificación de los datos. Además, algunas propiedades utilizan validaciones para garantizar la integridad de los datos (por ejemplo, `Experiencia` en `Administrador` y `Edad` en `Estudiante`).

4. **Composición**:

   - La clase `Escuela` tiene una relación de composición con `Administrador` y `Aula`, mientras que `Aula` tiene una relación de composición con `Profesor` y `Estudiante`. Esto significa que la existencia de estos objetos depende de la existencia de su contenedor.

5. **Interfaz**:
   - Las interfaces `IListaEditable<T>` e `IMostrable` definen contratos que las clases deben implementar, lo que asegura la cohesión y facilita la mantenibilidad del código.

## Relación entre Clases

- **Escuela**: Contiene aulas y un administrador.
- **Aula**: Contiene estudiantes y tiene un profesor.
- **Estudiante**: Representa a un estudiante.
- **Profesor**: Representa a un profesor.
- **Administrador**: Representa al administrador de la escuela.

### Relaciones

1. **Composición**: La escuela contiene aulas. Si la escuela se elimina, las aulas también se eliminan.
2. **Agregación**: El aula contiene estudiantes. Si el aula se elimina, los estudiantes pueden existir independientemente.
3. **Asociación**: El aula tiene un profesor. La escuela tiene un administrador. Ambas son relaciones de asociación.

### Explicación de las Relaciones

- **Composición (Escuela -> Aulas)**: La relación entre Escuela y Aula es de composición. Si la escuela se destruye, las aulas también se destruyen.
- **Agregación (Aula -> Estudiantes)**: La relación entre Aula y Estudiante es de agregación. Los estudiantes pueden existir independientemente de las aulas.
- **Asociación (Aula -> Profesor)**: La relación entre Aula y Profesor es de asociación. Un aula tiene un profesor, pero el profesor puede existir independientemente del aula.
- **Asociación (Escuela -> Administrador)**: Tanto Escuela como Administrador pueden existir independientemente, la relación es de asociación y es meramente semántica.
- **Realización (EntidadConNombre -> IMostrable)**: Esta relación se usa cuando implementamos una interfaz. No se usa cardinalida. Se puede conocer como una relación de implementación.

---
