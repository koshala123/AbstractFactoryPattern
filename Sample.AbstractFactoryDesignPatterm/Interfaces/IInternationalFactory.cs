namespace Sample.AbstractFactoryDesignPatterm.Interfaces
{
    //Abstract facotry
    public interface IInternationalFactory
    {
        ILanguage CreateLanguage();
        ICapitalCity CreateCapitalCity();
    }
}
