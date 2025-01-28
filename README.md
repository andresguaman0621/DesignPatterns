# Design Patterns Automobiles

Este proyecto implementa un sistema de gestión de vehículos utilizando ASP.NET Core y patrones de diseño avanzados para garantizar flexibilidad, escalabilidad y adherencia a los principios SOLID.

## Tabla de Contenidos

1. Descripción  
2. Requerimientos del Proyecto  
3. Arquitectura y Patrones Implementados  
   - Singleton  
   - Builder  
   - Factory Method  
4. Instalación  
5. Uso del Sistema  
6. Contribuciones  
7. Licencia  

---

## Descripción

El sistema permite la creación, simulación y gestión de vehículos mediante patrones de diseño como Singleton, Builder y Factory Method. Estos patrones aseguran que el proyecto pueda crecer fácilmente, permitiendo la incorporación de nuevos modelos de vehículos y propiedades adicionales sin comprometer la arquitectura existente.

El proyecto ha sido diseñado teniendo en cuenta:

- **Simulación de almacenamiento sin base de datos:** Implementar un almacenamiento temporal en memoria hasta que el esquema de la base de datos esté listo.
- **Extensibilidad para agregar nuevos modelos de vehículos:** La arquitectura permite incorporar nuevos modelos sin cambios disruptivos.
- **Configuración modular:** Facilita el mantenimiento y futuras integraciones.

---

## Requerimientos del Proyecto

1. **Agregar vehículos Mustang y Explorer:** Implementar funcionalidad para añadir vehículos desde la página principal utilizando un patrón de diseño que facilite la extensión.
2. **Simular almacenamiento sin base de datos:** Implementar un almacenamiento temporal en memoria.
3. **Agregar propiedades por defecto:** Introducir propiedades predefinidas como el año actual y preparar la arquitectura para agregar 20 propiedades adicionales en el futuro.
4. **Soporte para nuevos modelos:** Implementar un patrón Factory Method para gestionar la creación de nuevos modelos (e.g., Escape).

---

## Arquitectura y Patrones Implementados

### Singleton

El patrón Singleton se utilizó para simular el almacenamiento temporal de vehículos. La clase `MemoryCollection` asegura que todos los vehículos se gestionen dentro de una única instancia compartida en memoria.

```csharp
public class MemoryCollection {
    private static MemoryCollection _instance;
    public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    public static MemoryCollection Instance {
        get {
            if (_instance == null) _instance = new MemoryCollection();
            return _instance;
        }
    }
}
```

### Builder

El patrón Builder facilita la creación de objetos `Vehicle` con valores predeterminados y propiedades opcionales. Esto hace que sea sencillo agregar propiedades adicionales en el futuro sin modificar el modelo base.

```csharp
var builder = new CarModelBuilder()
    .setColor("red")
    .setModel("Mustang")
    .setYear(2023);
Vehicle mustang = builder.Build();
```

### Factory Method

El Factory Method fue implementado para gestionar la creación de diferentes modelos de vehículos. La clase abstracta `CarFactory` asegura una estructura estándar para la creación de vehículos, mientras que subclases como `FordMustangFactory` y `FordEscapeFactory` manejan modelos específicos.

```csharp
CarFactory factory = new FordMustangFactory();
Vehicle mustang = factory.Create();
```

---

## Instalación

### Requisitos previos

- **.NET SDK 6.0 o superior**  
- **Visual Studio 2022** (o cualquier IDE compatible con proyectos .NET Core)  
- **Git**

### Pasos de instalación

1. **Clona este repositorio:**

   ```bash
   git clone https://github.com/tu-usuario/design-patterns-automobiles.git
   cd design-patterns-automobiles
   ```

2. **Restaura los paquetes NuGet:**

   ```bash
   dotnet restore
   ```

3. **Compila el proyecto:**

   ```bash
   dotnet build
   ```

4. **Ejecuta el proyecto:**

   ```bash
   dotnet run
   ```

El sistema estará disponible en [http://localhost:5000](http://localhost:5000).

---

## Uso del Sistema

1. Accede a la página principal para visualizar los vehículos existentes.
2. Usa los botones "Add Mustang", "Add Explorer" y "Add Escape" para agregar vehículos al sistema.
3. Usa las acciones disponibles para encender el motor, llenar el tanque, y detener el motor.
4. Los vehículos añadidos se almacenan temporalmente en memoria (simulado).

---

## Contribuciones

Las contribuciones a este proyecto son bienvenidas. Por favor, abre un issue o crea un pull request en el repositorio para proponer cambios o mejoras.

---


