using DesignPatterns.Models;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singleton
{
    public class MemoryCollection
    {
        private static MemoryCollection _isntance;

        public ICollection<Vehicle> Vehicles { get; set; }
    
        public MemoryCollection() 
        { 
            Vehicles = new List<Vehicle>();
        }

        public static MemoryCollection Instance {

            get 
            { 
                if( _isntance == null)
                {
                    _isntance = new MemoryCollection();
                }
                return _isntance;
            }

        }
    }
}
