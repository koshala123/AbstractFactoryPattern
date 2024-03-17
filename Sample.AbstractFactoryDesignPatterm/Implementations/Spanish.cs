﻿using Sample.AbstractFactoryDesignPatterm.Interfaces;

namespace Sample.AbstractFactoryDesignPatterm.Implementations
{
    //Concrete product A2
    public class Spanish : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine("Hola!!");
        }
    }
}
