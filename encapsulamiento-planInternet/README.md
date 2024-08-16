# Ejercicios de Programación Orientada a Objetos

## Ejercicio 6: Planes de Internet

> La empresa de telecomunicaciones "Conexión Total" necesita un sistema para gestionar los planes de internet que ofrece a sus clientes. Los planes se dividen en diferentes categorías, como residencial, empresarial y móvil. Es fundamental que la información sobre los planes, como el nombre del plan, la velocidad de conexión y el precio mensual, esté protegida y accesible solo de manera controlada. Además, el sistema debe garantizar que el nombre del plan, la velocidad de conexión y el precio mensual sean válidos.
> Cada plan tiene que tener la posibilidad de mostrar los detalles correspondientes al mismo.

### Descripción General

En este ejercicio, se definen varias clases relacionadas con diferentes tipos de planes de Internet. `PlanInternet` es la clase base, de la cual derivan `PlanResidencial`, `PlanEmpresarial`, y `PlanMobile`. Cada clase derivada sobrescribe el método `MostrarDetalles` para proporcionar información específica del plan.

### Consigna

1. Define una nueva clase llamada `PlanFibraOptica` que herede de `PlanInternet`.
2. Añade una propiedad específica para `PlanFibraOptica`, como la longitud del contrato en meses.
3. Sobrescribe el método `MostrarDetalles` para incluir la información del contrato.
4. Actualiza el programa principal para incluir la opción de seleccionar el `PlanFibraOptica` y muestra los detalles correspondientes.

### Pilares Aplicados

- **Abstracción**: Manejo de la información de los planes de Internet de manera encapsulada y organizada.
- **Herencia**: Las clases `PlanResidencial`, `PlanEmpresarial`, y `PlanMobile` heredan de `PlanInternet`, aprovechando sus propiedades y métodos.
- **Polimorfismo**: Uso de métodos sobrescritos en las clases derivadas para personalizar la presentación de los detalles de cada tipo de plan.

---
