// Converts a temperature between Celsius and Fahrenheit.

Console.Write("\nChoose a conversion:\n\t\t\t\t\t1. Celsius to Fahrenheit\n\n\t\t\t\t\t2. Fahrenheit to Celsius\n");

// ReadLine returns null once the input stream is closed, hence the nullable type.
string? choice = Console.ReadLine();

if (choice != "1" && choice != "2")
{
    Console.Write("\nInvalid choice.\n");
    return;
}

// Both directions share the same steps, so the choice is kept as a flag and the
// prompt, the formula and the unit symbols are selected from it rather than
// written out twice.
bool toFahrenheit = choice == "1";

Console.Write(toFahrenheit
    ? "Enter the temperature in Celsius: "
    : "Enter the temperature in Fahrenheit: ");

// TryParse reports failure through its return value rather than throwing, so a
// malformed entry stays an ordinary branch instead of an exception to catch.
if (!double.TryParse(Console.ReadLine(), out double input))
{
    Console.Write("\nInvalid temperature.\n");
    return;
}

double result = toFahrenheit
    ? input * 9.0 / 5.0 + 32.0
    : (input - 32.0) * 5.0 / 9.0;

Console.Write($"\n\n\t\t\t\t{input:f1} {(toFahrenheit ? "°C" : "°F")} = {result:f1} {(toFahrenheit ? "°F" : "°C")}");
