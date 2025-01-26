using DesignPatterns.Factories;
using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factory
{
    public class FordMustangFactory:CarFactory
    {
        
        public override Vehicle Create() 
        {
            return new CarModelBuilder().Build();
        }
    }
}
