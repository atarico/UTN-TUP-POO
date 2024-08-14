# Ejercicios de Programación Orientada a Objetos

## Ejercicio: Tarjeta de Identificación y Empleado

> En la empresa "Tech Solutions", cada empleado tiene una tarjeta de identificación personal que contiene su nombre, apellido, número de identificación y fecha de emisión. La empresa necesita implementar un sistema que gestione a los empleados y sus tarjetas de identificación.

### Descripción General

En este ejercicio, se definen dos clases: `TarjetaIdentificacion` y `Empleado`. La clase `TarjetaIdentificacion` se encarga de generar una tarjeta única para cada empleado, manteniendo un contador estático para asegurar que cada tarjeta tenga un número de identificación único. La clase `Empleado` contiene una instancia de `TarjetaIdentificacion`, y ambos están relacionados a través de composición.

### Consigna

1. Define una nueva clase llamada `Gerente` que herede de `Empleado`.
2. Añade una propiedad específica para `Gerente` que almacene el departamento al que pertenece.
3. Crea un método para mostrar los detalles del gerente, incluyendo la información de la tarjeta de identificación y el departamento.
4. Instancia un objeto de la clase `Gerente` y muestra su información.

### Pilares Aplicados

- **Abstracción**: Manejo de la información de identificación y empleado de manera encapsulada y organizada.
- **Encapsulamiento**: Protección de los datos mediante propiedades con acceso restringido y métodos para mostrar la información.
- **Composición**: La clase `Empleado` contiene una instancia de `TarjetaIdentificacion`, mostrando cómo una clase puede formar parte de otra.

---
