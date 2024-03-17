// See https://aka.ms/new-console-template for more information
using Sample.AbstractFactoryDesignPatterm;
using Sample.AbstractFactoryDesignPatterm.Interfaces;

Console.WriteLine("Hello, World!");

Country country = Country.England;

ILanguage language = InternationalProvider.CreateLanguage(country);
ICapitalCity capitalCity = InternationalProvider.CreateCapital(country);

language.Greet();
Console.WriteLine($"Total population of the given capital {capitalCity.GetPopulation()}");
Console.WriteLine("Top attractions " + string.Join(",", capitalCity.ListAllTopAttractions()));