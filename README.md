# temperature-converter

Converts a temperature between Celsius and Fahrenheit.

## Getting started

```bash
git clone https://github.com/Arthure-code/temperature-converter.git
cd temperature-converter
dotnet run --project ConvertisseurTemperatures
```

```
Choose a conversion:
                    1. Celsius to Fahrenheit

                    2. Fahrenheit to Celsius
1
Enter the temperature in Celsius: 37

                37.0 °C = 98.6 °F
```

Requires the [.NET SDK 8.0](https://dotnet.microsoft.com/download) or later.

## How it works

Celsius to Fahrenheit applies `F = C * 9 / 5 + 32`, and the reverse applies
`C = (F - 32) * 5 / 9`. Both are computed in `double` and printed with one
decimal place, so a value such as 98.6 is not rounded away.

The menu choice is matched with a `switch` on the raw string, which keeps the
comparison exact and leaves any other entry to the `default` branch.

Temperatures are read with `double.TryParse`, which reports failure through its
return value instead of throwing, so a malformed entry stays an ordinary branch.

## License

MIT
