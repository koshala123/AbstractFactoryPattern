using Sample.AbstractFactoryDesignPatterm.Interfaces;

namespace Sample.AbstractFactoryDesignPatterm.Implementations
{
    //Concrete product B2
    internal class Madrid : ICapitalCity
    {
        public int GetPopulation()
        {
            return 3200000;
        }

        public IList<string> ListAllTopAttractions()
        {
            return new List<string>
            {
                "The Prado Museum",
                "The Royal Palace of Madrid",
                "The Buen Retiro Park",
                "The Thyssen-Bornemisza Museum",
                "The Reina Sofia Museum"
            };
        }
    }
}
