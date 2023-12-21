namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in degrees fahrenheit?");
            double fahrenheitValue = double.Parse(Console.ReadLine());
            double celsiusValue = TempConverter.FahrenheitToCelsius(fahrenheitValue);
            Console.WriteLine($"{fahrenheitValue} Fahrenheit is {celsiusValue} Celsius.");


            Console.WriteLine("What is the temperature in degrees celsius)?");
            double celsiusValue2 = double.Parse(Console.ReadLine());
            double fahrenheitValue2 = TempConverter.CelsiusToFahrenheit(celsiusValue2);
            Console.WriteLine($"{celsiusValue2} Celsius is {fahrenheitValue2} Fahrenheit.");
        }
    }
}
