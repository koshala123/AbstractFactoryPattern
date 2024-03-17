using Sample.AbstractFactoryDesignPatterm.Implementations;
using Sample.AbstractFactoryDesignPatterm.Interfaces;

namespace Sample.AbstractFactoryDesignPatterm.ConcreteFactories
{
    //Concrete factory 2
    public class SpainFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapitalCity()
        {
            return new Madrid();
        }

        public ILanguage CreateLanguage()
        {
            return new Spanish();
        }
    }
}
