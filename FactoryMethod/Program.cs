// See https://aka.ms/new-console-template for more information

using FactoryMethod;

Product productA = Creator.Create(Creator.valueA);
Console.WriteLine(productA.Result());

Product productB = Creator.Create(Creator.valueB);
Console.WriteLine(productB.Result());

Console.ReadKey();
