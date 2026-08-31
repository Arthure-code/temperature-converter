// Converts a temperature between Celsius and Fahrenheit.

double celsius = 0;
double fahrenheit = 0;

Console.Write("\nChoose a conversion:\n");
Console.Write("\t\t\t\t\t1. Celsius to Fahrenheit\n");
Console.WriteLine("\n\t\t\t\t\t2. Fahrenheit to Celsius");

// ReadLine returns null once the input stream is closed, hence the nullable type.
string? input = Console.ReadLine();

switch (input)
{
    case "1":
        Console.Write("Enter the temperature in Celsius: ");

        // TryParse reports failure through its return value rather than throwing,
        // so a malformed entry stays an ordinary branch instead of an exception.
        if (double.TryParse(Console.ReadLine(), out celsius))
        {
            fahrenheit = (celsius * 9.0 / 5.0) + 32.0;
            Console.Write($"\n\n\t\t\t\t{celsius:f1} °C = {fahrenheit:f1} °F");
        }
        break;

    case "2":
        Console.Write("Enter the temperature in Fahrenheit: ");

        if (double.TryParse(Console.ReadLine(), out fahrenheit))
        {
            celsius = (fahrenheit - 32.0) * 5.0 / 9.0;
            Console.Write($"\n\n\t\t\t\t{fahrenheit:f1} °F = {celsius:f1} °C");
        }
        break;

    default:
        Console.Write("\nInvalid choice.\n");
        break;
}
