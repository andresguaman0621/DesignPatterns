using DesignPatterns.Factories;
using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factory
{
    public class FordEscapeFactory:CarFactory
    {
        
        public override Vehicle Create() 
        {
            return new CarModelBuilder().setModel("Escape").setColor("white").Build();
        }
    }
}
