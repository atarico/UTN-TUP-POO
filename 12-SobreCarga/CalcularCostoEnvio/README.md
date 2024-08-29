# Sistema de Cálculo de Costo de Envío

## Enunciado:

> Una empresa de logística necesita un sistema para gestionar diferentes tipos de paquetes que envían a través de su red de transporte. Los paquetes pueden ser de diferentes tamaños y pesos, y pueden enviarse utilizando diversos métodos de envío, como estándar, exprés o internacional. El sistema debe ser capaz de calcular el costo de envío basado en diferentes parámetros como el peso, el tamaño, el destino, y el método de envío. A veces, los clientes proporcionan solo el peso del paquete, otras veces solo el tamaño y, en ocasiones, ambos.
>
> El encargado de la empresa, Pablo, desea una solución que permita calcular el costo de envío de varias maneras, dependiendo de la información proporcionada por el cliente. Él espera que el sistema sea lo suficientemente flexible para manejar estos diferentes escenarios de cálculo sin requerir que los usuarios proporcionen toda la información en cada caso.
>
> Tarifas y Reglas de Cálculo:
>
> Por Peso:
>
> - Tarifa de 5.0 unidades monetarias por kilogramo.
>
> Por Tamaño:
>
> - Tarifa de 2.0 unidades monetarias por volumen (largo x ancho x alto).
>
> Por Peso y Destino:
>
> - Tarifa base de 10.0 unidades monetarias.
> - Destino Nacional: Tarifa base + 4.0 unidades monetarias por kilogramo.
> - Destino Internacional: Doble de la tarifa base + 1.5 veces la tarifa por kilogramo (4.0 x 1.5).
>
> Por Peso, Tamaño, y Método de Envío:
>
> - Cálculo base sumando los costos de peso y tamaño.
> - Envío Estándar: Tarifa calculada sin alteraciones.
> - Envío Exprés: 25% adicional al costo base.
> - Envío Internacional: 50% adicional al costo base.

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
