using System.Collections.Generic;
using System;
using DesignPatterns.Factories;

namespace DesignPatterns.Factory
{
    public class CarFactoryProvider
    {
        private readonly Dictionary<string, CarFactory> _factories;

        public CarFactoryProvider()
        {
            _factories = new Dictionary<string, CarFactory>
        {
            { "Mustang", new FordMustangFactory() },
            { "Explorer", new FordExplorerFactory() },
            { "Escape", new FordEscapeFactory() }
        };
        }

        public CarFactory ChooseFactory(string vehicle)
        {
            if (_factories.TryGetValue(vehicle, out var factory))
            {
                return factory;
            }

            throw new NotImplementedException($"No factory implemented for vehicle: {vehicle}");
        }
    }
}
