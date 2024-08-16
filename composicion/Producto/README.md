# Ejercicios de Programación Orientada a Objetos

## Ejercicio: Sistema de Orden de Compra

> En el supermercado "Compras Felices", se ha decidido implementar un sistema para gestionar el inventario de productos y las órdenes de compra de los clientes. Los productos se categorizan en diferentes secciones como frutas, verduras, lácteos, y carnes. Cada producto tiene un código, nombre, cantidad en stock y precio. Además, se quiere gestionar las órdenes de compra, que contienen múltiples productos y deben calcular el total de la orden.

### Descripción General

En este ejercicio, se implementa un sistema básico para gestionar una orden de compra. Se definen dos clases principales: `Producto` y `OrdenCompra`. La clase `Producto` almacena información sobre los productos disponibles, mientras que la clase `OrdenCompra` permite agregar productos y calcular el total de la orden.

### Consigna

1. Añade una funcionalidad en la clase `OrdenCompra` para que, al agregar un producto a la orden, se disminuya la cantidad de stock del producto correspondiente.
2. Modifica el método `CalcularTotal` para que tenga en cuenta la cantidad de productos en la orden, no solo el precio unitario.
3. Implementa una verificación al agregar un producto a la orden para asegurar que hay suficiente stock disponible.
4. Crea un menú en el programa principal que permita al usuario interactuar con el sistema, agregando productos a la orden y mostrando el detalle de la misma.

### Pilares Aplicados

- **Abstracción**: Manejo de la información relacionada con productos y órdenes de compra de manera encapsulada.
- **Encapsulamiento**: Protección de las propiedades `CantidadStock` y `Precio` en la clase `Producto`, permitiendo que solo se modifiquen de manera controlada.
- **Colecciones**: Uso de una lista (`List<Producto>`) para manejar dinámicamente los productos en una orden de compra.

### Relaciones Entre Clases

1. **Composición (Relación fuerte entre `OrdenCompra` y `Producto`)**:

   - La clase `OrdenCompra` contiene y gestiona una colección de objetos de tipo `Producto`. La composición indica que la `OrdenCompra` es responsable del ciclo de vida de los productos que contiene.

2. **Agregación (Relación débil entre `Producto` y `OrdenCompra`)**:
   - Los objetos `Producto` pueden existir independientemente de cualquier `OrdenCompra`. La agregación refleja que los productos no dependen de la existencia de una orden para existir.

---
