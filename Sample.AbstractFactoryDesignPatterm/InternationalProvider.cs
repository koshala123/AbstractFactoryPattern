using Sample.AbstractFactoryDesignPatterm.Implementations;
using Sample.AbstractFactoryDesignPatterm.Interfaces;

namespace Sample.AbstractFactoryDesignPatterm
{
    public class InternationalProvider
    {
        public static ILanguage CreateLanguage(Country country)
        {
            switch (country)
            {
                case Country.England:
                    return new English();
                case Country.Spain:
                    return new Spanish();
                default:
                    throw new NotImplementedException("Invalid country");
            }
        }

        public static ICapitalCity CreateCapital(Country country)
        {
            switch (country)
            {
                case Country.England:
                    return new London();
                case Country.Spain:
                    return new Madrid();
                default:
                    throw new NotImplementedException("Invalid country");
            }
        }
    }

    public enum Country
    {
        England,
        Spain
    }
}
