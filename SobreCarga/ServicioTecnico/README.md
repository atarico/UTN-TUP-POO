# Sistema de Servicio Técnico

## Descripción General

Estás desarrollando un sistema para un servicio técnico que repara dispositivos electrónicos. El sistema debe manejar diferentes tipos de dispositivos electrónicos, como celulares, laptops y tablets, y permitir al servicio técnico reparar estos dispositivos. Además, debes ser capaz de mostrar información detallada sobre el servicio técnico.

Tu tarea es implementar este sistema en C#, usando conceptos de programación orientada a objetos para representar las relaciones entre los dispositivos y el servicio técnico.

## Clases Principales

- **ServicioTecnico**

  - Representa un servicio técnico con información sobre su nombre, dirección, especialidad y año de fundación.
  - **Propiedades**:
    - `Nombre` (string): Nombre del servicio técnico.
    - `Direccion` (string): Dirección del servicio técnico.
    - `Especialidad` (string): Especialidad del servicio técnico.
    - `AñoFundacion` (int): Año en el que se fundó el servicio técnico.
  - **Métodos**:
    - `MostrarDetalles()`: Muestra todos los detalles del servicio técnico.
    - `MostrarDetalles(bool mostrarEspecialidad)`: Muestra detalles del servicio técnico con o sin la especialidad, dependiendo del parámetro booleano.
    - `Reparar(DispositivoElectronico dispositivoElectronico)`: Repara un dispositivo electrónico específico.

- **DispositivoElectronico**

  - Representa un dispositivo electrónico genérico.
  - **Propiedades**:
    - `Nombre` (string): Nombre del dispositivo electrónico.
  - **Constructor**:
    - `DispositivoElectronico(string nombre)`: Inicializa un dispositivo electrónico con el nombre proporcionado.

- **Celular** (hereda de `DispositivoElectronico`)

  - Representa un dispositivo celular.
  - **Constructor**:
    - `Celular(string nombre)`: Inicializa un celular con el nombre proporcionado.

- **Laptop** (hereda de `DispositivoElectronico`)

  - Representa una laptop.
  - **Constructor**:
    - `Laptop(string nombre)`: Inicializa una laptop con el nombre proporcionado.

- **Tablet** (hereda de `DispositivoElectronico`)
  - Representa una tablet.
  - **Constructor**:
    - `Tablet(string nombre)`: Inicializa una tablet con el nombre proporcionado.

## Relaciones y Conceptos

- **Herencia**:

  - **DispositivoElectronico → Celular**
  - **DispositivoElectronico → Laptop**
  - **DispositivoElectronico → Tablet**
    - `Celular`, `Laptop` y `Tablet` heredan de `DispositivoElectronico`, lo que permite representar diferentes tipos de dispositivos electrónicos.

- **Polimorfismo**:
  - El método `Reparar` en `ServicioTecnico` puede manejar cualquier tipo de `DispositivoElectronico`, demostrando polimorfismo.

## Ejemplo de Uso

El siguiente código muestra cómo crear instancias del servicio técnico y reparar distintos tipos de dispositivos electrónicos, incluyendo la nueva clase `Tablet`:

```csharp
class Program
{
    static void Main()
    {
        ServicioTecnico servicioTecnico1 = new ServicioTecnico("UTN", "Colon 332", "informatica", 2024);

        Celular nokia1100 = new Celular("Nokia 1100");
        Laptop asus = new Laptop("Asus");
        Tablet samsungTab = new Tablet("Samsung Tab");

        servicioTecnico1.Reparar(nokia1100);
        servicioTecnico1.Reparar(asus);
        servicioTecnico1.Reparar(samsungTab);
    }
}
```
