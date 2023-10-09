namespace Seasons.cs;

class Seasons
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the name of a season and I'll translate it to Spanish\n");
        string seasonChoice = Console.ReadLine();

        switch (seasonChoice.ToLower())
        {
            case "spring":
                Console.WriteLine("Spring in Spanish is 'la primavera'.");
                break;

            case "summer":
                Console.WriteLine("Summer in Spanish is 'el verano'.");
                break;

            case "fall":
            case "autumn":
                Console.WriteLine("Fall and Autumn in Spanish is 'el otoño'.");
                break;

            case "winter":
                Console.WriteLine("Winter in Spanish is 'el invierno'.");
                break;

        }

    }
}

