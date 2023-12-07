using System;
using System.Collections.Generic;

public class City
{
    public string Name;
    public string Region;
    public string Country;
    public int Population;
    public string PostalCode;
    public string AreaCode;

    public City(string name, string region, string country, int population, string postalCode, string areaCode)
    {
        Name = name;
        Region = region;
        Country = country;
        Population = population;
        PostalCode = postalCode;
        AreaCode = areaCode;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"City: {Name}");
        Console.WriteLine($"Region: {Region}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine($"Population: {Population}");
        Console.WriteLine($"Postal Code: {PostalCode}");
        Console.WriteLine($"Area Code: {AreaCode}");
    }

    static void Main()
    {
        City odesa = new City("Odesa", "Odesa region", "Ukraine", 1000000, "65000", "048");
        City kyiv = new City("Kyiv", "Kyiv region", "Ukraine", 2800000, "01000", "044");

        odesa.DisplayInformation();
        Console.WriteLine();
        kyiv.DisplayInformation();
    }
}


