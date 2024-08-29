# Sistema de Cálculo de Costo de Envío

## Descripción General

Estás desarrollando un sistema para calcular el costo de envío de paquetes basado en diferentes parámetros. El sistema debe manejar diferentes métodos de envío, destinos, y tamaños de paquetes para calcular el costo total. Tu tarea es implementar este sistema en C#, utilizando sobrecarga de métodos y enumeraciones para representar las diferentes opciones.

## Clases Principales

- **Enumeraciones**:

  - **MetodoEnvio**:
    - `Estandar`: Método de envío estándar.
    - `Expres`: Método de envío exprés.
    - `Full`: Método de envío completo.
  - **Destino**:
    - `Nacional`: Envío a nivel nacional.
    - `Internacional`: Envío internacional.

- **CalculadorCostoEnvio**:

  - Representa el cálculo del costo de envío basado en peso, dimensiones del paquete, destino y método de envío.
  - **Métodos**:

    - `CalcularCosto(double peso)`: Calcula el costo basado en el peso del paquete.
    - `CalcularCosto(double largo, double ancho, double alto)`: Calcula el costo basado en las dimensiones del paquete.
    - `CalcularCosto(double peso, Destino destino)`: Calcula el costo basado en el peso del paquete y el destino.
    - `CalcularCosto(double peso, double largo, double ancho, double alto, MetodoEnvio metodoEnvio)`: Calcula el costo total considerando el peso, dimensiones del paquete, y el método de envío.

## Relaciones y Conceptos

### Sobrecarga de Métodos

La clase `CalculadorCostoEnvio` utiliza sobrecarga de métodos para proporcionar diferentes formas de calcular el costo del envío. Los métodos están sobrecargados según los parámetros que reciben (peso, dimensiones, destino, y método de envío).

### Enumeraciones

Las enumeraciones `MetodoEnvio` y `Destino` se utilizan para especificar las opciones disponibles para el cálculo del costo del envío.

## Consignas Adicionales

### Crear una Nueva Clase

Crea una clase llamada `Paquete` que contenga propiedades para el peso, largo, ancho, alto, destino y método de envío. Implementa un método que utilice una instancia de `CalculadorCostoEnvio` para calcular el costo del envío basado en las propiedades del `Paquete`.

### Modularización del Programa

Refactoriza el código actual para que cada clase y enumeración se defina en su propio archivo dentro de una carpeta llamada `Modelos`.

- Crea una carpeta llamada `Interfaces` si decides usar interfaces adicionales en el futuro.
- Asegúrate de que el método `Main` quede en un archivo separado llamado `Program.cs`, manteniendo el código organizado y modular.

## Estructura del Proyecto

```plaintext
/Modelos
    - CalculadorCostoEnvio.cs
    - MetodoEnvio.cs
    - Destino.cs
    - Paquete.cs
/Program.cs
```

## Ejemplo de Uso

El siguiente código muestra cómo utilizar la clase `CalculadorCostoEnvio` para calcular el costo de envío de diferentes paquetes:

```csharp
public class Program
{
    public static void Main()
    {
        CalculadorCostoEnvio calculador = new CalculadorCostoEnvio();

        Console.WriteLine("Costo solo por peso (5kg): $" + calculador.CalcularCosto(5));
        Console.WriteLine("Costo por tamaño (2x3x4): $" + calculador.CalcularCosto(2, 3, 4));
        Console.WriteLine("Costo por peso y destino (5kg, Internacional): $" + calculador.CalcularCosto(5, Destino.Internacional));
        Console.WriteLine("Costo completo (5kg, 2x3x4, expres): $" + calculador.CalcularCosto(5, 2, 3, 4, MetodoEnvio.Expres));
    }
}
```
