using DesignPatterns.Infraestructure.Singleton;
using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        // Accedemos a la instancia de MemoryCollection a través del Singleton  
        private readonly MemoryCollection _memoryCollection = MemoryCollection.Instance;

        // Constructor
        public MyVehiclesRepository() { }

        // Método para añadir un vehículo a la colección
        public void AddVehicle(Vehicle vehicle)
        {
            _memoryCollection.Vehicles.Add(vehicle);
        }

        // Método para encontrar un vehículo por su ID
        public Vehicle Find(string id)
        {
            return _memoryCollection.Vehicles.FirstOrDefault(v => v.ID.Equals(new Guid(id)));
        }

        // Método para obtener todos los vehículos
        public ICollection<Vehicle> GetVehicles()
        {
            return _memoryCollection.Vehicles;
        }
    }
}
