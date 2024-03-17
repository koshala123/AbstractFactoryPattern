using Sample.AbstractFactoryDesignPatterm.Interfaces;

namespace Sample.AbstractFactoryDesignPatterm.Implementations
{
    //Concrete product B1
    public class London : ICapitalCity
    {
        public int GetPopulation()
        {
            return 8900000;
        }

        public IList<string> ListAllTopAttractions()
        {
            return new List<string>
            {
                "The British Museum",
                "The Tower of London",
                "The London Eye",
                "The National Gallery",
                "The Victoria and Albert Museum"
            };
        }
    }
}
