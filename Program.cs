using Faker;

internal class Program
{
    private static void Main(string[] args)
    {
        var name = Name.FullName();
        var city = Address.City();
        var address = Address.StreetAddress();
        var random = new Random();
        var letter = Convert.ToChar(random.Next('A', 'Z'));
        var tunnus = RandomNumber.Next(0, 100000000);
        Console.WriteLine($"Name: {name}; Osoite: {city} {address}; Henkilötunnus: {letter}{tunnus}.");
    }
}