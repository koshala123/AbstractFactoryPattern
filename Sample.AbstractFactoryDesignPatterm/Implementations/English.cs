using Sample.AbstractFactoryDesignPatterm.Interfaces;

namespace Sample.AbstractFactoryDesignPatterm.Implementations
{
    //Concrete product A1
    public class English : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine("Hello!!");
        }
    }
}
