using Sample.AbstractFactoryDesignPatterm.Implementations;
using Sample.AbstractFactoryDesignPatterm.Interfaces;

namespace Sample.AbstractFactoryDesignPatterm.ConcreteFactories
{
    //Concrete factory 1
    public class EnglandFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapitalCity()
        {
            return new London();
        }

        public ILanguage CreateLanguage()
        {
            return new English();
        }
    }
}
