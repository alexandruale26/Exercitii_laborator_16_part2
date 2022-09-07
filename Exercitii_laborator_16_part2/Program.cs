using Exercitii_laborator_16_part2;
using Exercitii_laborator_16_part2.Models;
using Exercitii_laborator_16_part2.Data;
using Microsoft.EntityFrameworkCore;


#region Manufacturers
Manufacturer vwAG = new Manufacturer
{
    Name = "Volkswagen AG",
    Address = "Wolfsburg Germany"
};

Manufacturer honda = new Manufacturer
{
    Name = "Honda",
    Address = "Minato Japan"
};

Manufacturer ford = new Manufacturer
{
    Name = "Ford",
    Address = "Michigan USA"
};

Manufacturer toyota = new Manufacturer
{
    Name = "Toyota",
    Address = "Aichi Japan"
};
#endregion



SeedTable();


using AutovehiclesContextDB context = new AutovehiclesContextDB();


context.Autovehicles.OrderByDescending(a => a.ManufactureDate).ToList().ForEach(a => Console.WriteLine(a));

//Not allowed to use GroupBy on SQL server. Execute the query and convert the result to a list, then GroupBy.
var autos = context.Autovehicles.Include(a => a.Manufacturer).ToList().GroupBy(a => a.Manufacturer.Name); 

foreach (var auto in autos)
{
    Console.WriteLine($"\n\nMasinile producatorului {auto.Key}");
    foreach (var a in auto)
    {
        Console.WriteLine(a);
    }
}




void SeedTable()
{
    using AutovehiclesContextDB context = new AutovehiclesContextDB();

    if (context.Autovehicles.Any() || context.Manufacturers.Any()) return;


    context.Add(new Autovehicle
    {
        Name = "Audi A3",
        VIN = "WAUZZZ378499212",
        ManufactureDate = 2013,
        Manufacturer = vwAG
    });

    context.Add(new Autovehicle
    {
        Name = "Honda Jazz",
        VIN = "LJCPC753829438",
        ManufactureDate = 2010,
        Manufacturer = honda
    });

    context.Add(new Autovehicle
    {
        Name = "Golf 7 Plus",
        VIN = "VWWZZZ584521557",
        ManufactureDate = 2013,
        Manufacturer = vwAG
    });

    context.Add(new Autovehicle
    {
        Name = "Toyota Corolla",
        VIN = "JT4RN12P7K84448",
        ManufactureDate = 2017,
        Manufacturer = toyota
    });

    context.Add(new Autovehicle
    {
        Name = "Mustang",
        VIN = "1FX6P8XXH96884",
        ManufactureDate = 2019,
        Manufacturer = ford
    });

    context.Add(new Autovehicle
    {
        Name = "Audi A7",
        VIN = "WAUZZZ885320147",
        ManufactureDate = 2018,
        Manufacturer = vwAG
    });

    context.Add(new Autovehicle
    {
        Name = "Toyota Celica",
        VIN = "JT4RN985LC78554",
        ManufactureDate = 1999,
        Manufacturer = toyota
    });

    context.Add(new Autovehicle
    {
        Name = "Audi A4",
        VIN = "WAUZZZ73326770",
        ManufactureDate = 2010,
        Manufacturer = vwAG
    });

    context.Add(new Autovehicle
    {
        Name = "Toyota Prius",
        VIN = "JT4RN12K2213421",
        ManufactureDate = 2011,
        Manufacturer = toyota
    });

    context.Add(new Autovehicle
    {
        Name = "Honda Civic",
        VIN = "LJCPC75KX899975",
        ManufactureDate = 2022,
        Manufacturer = honda
    });

    context.SaveChanges();
}
