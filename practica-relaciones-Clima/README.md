# Sistema de Gestión de Red Climática

## Descripción General

Estás desarrollando un sistema de gestión climática para una red de estaciones meteorológicas. Cada estación, ubicada en una ciudad específica, tiene un meteorólogo encargado de reportar las condiciones climáticas locales. El jefe de la red, **Juan Torres**, necesita un sistema que le permita ver la información de cada estación, los meteorólogos asignados, y las condiciones climáticas actuales en cada ciudad.

Tu tarea es implementar este sistema en C#, usando conceptos de **composición** para representar la relación entre las estaciones, los meteorólogos y los datos del clima.

## Tabla de Contenidos

- [Clases Principales](#clases-principales)
- [Relaciones](#relaciones)
- [Explicación de las Relaciones](#explicación-de-las-relaciones)
- [Consignas Adicionales](#consignas-adicionales)
  - [1. Crear una Nueva Clase](#1-crear-una-nueva-clase)
  - [2. Modularización del Programa](#2-modularización-del-programa)
- [Estructura de Directorios](#estructura-de-directorios)
- [Cómo Ejecutar el Proyecto](#cómo-ejecutar-el-proyecto)
- [Requisitos Previos](#requisitos-previos)
- [Contacto](#contacto)

---

## Clases Principales

- **Clima**
  - Representa las condiciones climáticas, incluyendo la temperatura y una descripción del clima.
  - **Propiedades**:
    - `Temperatura` (double): La temperatura actual en grados Celsius.
    - `Descripcion` (string): Una breve descripción de las condiciones climáticas (e.g., soleado, nublado).
- **Ubicacion**
  - Representa la ubicación geográfica de una estación, incluyendo la ciudad, el país y el clima asociado.
  - **Propiedades**:
    - `Ciudad` (string): Nombre de la ciudad donde se encuentra la estación.
    - `Pais` (string): Nombre del país donde se encuentra la estación.
    - `Clima` (Clima): Objeto que representa las condiciones climáticas actuales de la ubicación.
- **Meteorologo**
  - Representa un meteorólogo responsable de reportar el clima en una estación específica.
  - **Propiedades**:
    - `Nombre` (string): Nombre completo del meteorólogo.
    - `Especialidad` (string): Área de especialización del meteorólogo.
- **Estacion**
  - Representa una estación meteorológica que recopila y reporta datos climáticos.
  - **Propiedades**:
    - `Ubicacion` (Ubicacion): La ubicación geográfica de la estación.
    - `Meteorologo` (Meteorologo): El meteorólogo asignado a la estación.
- **RedClimatica**
  - Representa una red de estaciones meteorológicas supervisadas por un jefe.
  - **Propiedades**:
    - `Jefe` (string): Nombre del jefe de la red climática.
    - `Estaciones` (List<Estacion>): Lista de estaciones que pertenecen a la red.

---

## Relaciones

### Composición:

- **RedClimatica -> Estaciones**
  - La `RedClimatica` contiene `Estacion`es. Si la red climática se elimina, las estaciones también se eliminan.
  - **Símbolo**: ♦

### Composición:

- **Estacion -> Ubicacion**
  - Una `Estacion` tiene una `Ubicacion` específica. Si la estación se elimina, la ubicación no tiene sentido sin ella.
  - **Símbolo**: ♦

### Agregación:

- **Ubicacion -> Clima**
  - La `Ubicacion` contiene un `Clima`. El clima puede existir independientemente de la ubicación.
  - **Símbolo**: ◇

### Asociación:

- **Estacion -> Meteorologo**
  - La `Estacion` tiene un `Meteorologo` asociado. El meteorólogo puede existir independientemente de la estación.
  - **Símbolo**: →

---

## Explicación de las Relaciones

- **Composición (RedClimatica -> Estaciones)**: La relación entre `RedClimatica` y `Estacion` es de composición. Si la red se destruye, las estaciones también se destruyen.
- **Composición (Estacion -> Ubicacion)**: La relación entre `Estacion` y `Ubicacion` es de composición. La ubicación no tiene sentido sin una estación.
- **Agregación (Ubicacion -> Clima)**: La relación entre `Ubicacion` y `Clima` es de agregación. El clima puede existir independientemente de la ubicación.
- **Asociación (Estacion -> Meteorologo)**: La relación entre `Estacion` y `Meteorologo` es de asociación. Un meteorólogo puede existir independientemente de la estación.

---

## Consignas Adicionales

### 1. Crear una Nueva Clase

Crea una clase llamada `InformeClimatico` que contenga información sobre la fecha y el resumen del clima para un día específico.

**Detalles de la Clase**:

- **InformeClimatico**
  - **Propiedades**:
    - `Fecha` (DateTime): La fecha del informe climático.
    - `Resumen` (string): Un resumen detallado de las condiciones climáticas.
    - `Ubicacion` (Ubicacion): La ubicación para la cual se genera el informe.
  - **Métodos**:
    - `GenerarInforme()`: Genera y devuelve un string con el informe completo, incluyendo la fecha, la ubicación y el resumen del clima.

**Relación**:

- **Asociación**:
  - **InformeClimatico ─── Ubicacion**
    - Un `InformeClimatico` está asociado con una `Ubicacion` específica pero puede existir independientemente de ella.

### 2. Modularización del Programa

Refactoriza el código actual para que cada clase se defina en su propio archivo dentro de una carpeta llamada `Modelos`.

**Pasos a Seguir**:

1. **Organización por Carpetas**:

   - Crear una carpeta llamada `Modelos` y mover allí todas las clases que representan entidades del dominio (`Clima`, `Ubicacion`, `Meteorologo`, `Estacion`, `RedClimatica`, `InformeClimatico`).

2. **Uso de Interfaces**:

   - Si decides utilizar interfaces adicionales, crea una carpeta llamada `Interfaces` para organizarlas correctamente.

3. **Archivo `Program.cs`**:
   - Mantener el punto de entrada del programa en un archivo separado llamado `Program.cs` en la raíz del proyecto. Aquí, se debe instanciar y demostrar la funcionalidad completa del sistema.

---

## Estructura de Directorios

La estructura final del proyecto debería verse de la siguiente manera:

```plaintext
RedClimaticaApp/
│
├── Modelos/
│   ├── Clima.cs
│   ├── Ubicacion.cs
│   ├── Meteorologo.cs
│   ├── Estacion.cs
│   ├── RedClimatica.cs
│   └── InformeClimatico.cs
│
├── Program.cs
├── RedClimaticaApp.csproj
└── README.md
```
