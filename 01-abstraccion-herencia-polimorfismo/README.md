# UTN-TUP Ejercicios de Programación Orientada a Objetos

Estos ejercicios fueron creados para enseñar a los alumnos los conceptos de abstracción, herencia y polimorfismo.

## Descripción de los Ejercicios

### Ejercicio 1: Formas Geométricas

Este ejercicio utiliza una clase abstracta `FormaGeometrica` con subclases `Circulo` y `Cuadrado`. Cada subclase implementa el método abstracto `CalcularArea`.

**Pilares aplicados:**

- **Abstracción:** `FormaGeometrica` define una interfaz para calcular el área.
- **Herencia:** `Circulo` y `Cuadrado` heredan de `FormaGeometrica`.
- **Polimorfismo:** Las subclases implementan el método `CalcularArea` de manera específica.

### Ejercicio 2: Vehículos

Este ejercicio presenta una clase abstracta `Vehiculo` con subclases `Auto` y `Moto`. Cada subclase implementa el método abstracto `Conducir`.

**Pilares aplicados:**

- **Abstracción:** `Vehiculo` define una interfaz para todos los vehículos.
- **Herencia:** `Auto` y `Moto` heredan de `Vehiculo`.
- **Polimorfismo:** Las subclases implementan el método `Conducir` de manera específica.

### Ejercicio 3: Dispositivos Electrónicos

Este ejercicio muestra una clase abstracta `DispositivoElectronico` con subclases `Televisor` y `Radio`. Cada subclase implementa el método abstracto `Encender`.

**Pilares aplicados:**

- **Abstracción:** La clase `DispositivoElectronico` proporciona una interfaz para dispositivos electrónicos.
- **Herencia:** `Televisor` y `Radio` heredan de `DispositivoElectronico`.
- **Polimorfismo:** Las subclases implementan el método `Encender` de manera específica.

### Ejercicio 4: Sistema de Empleados

Este ejercicio presenta una clase abstracta `Empleado` con dos subclases concretas: `EmpleadoTiempoCompleto` y `EmpleadoTiempoParcial`. Cada subclase implementa el método abstracto `CalcularSalario` de manera diferente.

**Pilares aplicados:**

- **Abstracción:** La clase `Empleado` define una interfaz común para todos los empleados.
- **Herencia:** `EmpleadoTiempoCompleto` y `EmpleadoTiempoParcial` heredan de `Empleado`.
- **Polimorfismo:** Las subclases implementan el método `CalcularSalario` de diferentes maneras.

## Bibliografía

Para entender mejor los conceptos de la programación orientada a objetos y cómo se aplican en el análisis y diseño de software, se recomienda consultar la bibliografía de Grady Booch:

- Grady Booch. _Análisis y diseño orientado a objetos_. Addison-Wesley, 1994.
