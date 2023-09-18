using TemperatureConverter.App.Interfaces;
using TemperatureConverter.App.Utilities;

namespace TemperatureConverter.App.Entities
{
    public class ConvertFahrenheit : IConvertFahrenheit
    {
        public double Fahrenheit { get; }
        
        public ConvertFahrenheit(double fahrenheit)
        {
            Validate.ValidateNullTemperature(fahrenheit);
            Fahrenheit = fahrenheit;
        }
        
        public double ConvertFahrenheitToCelsius()
        {
            var celsius = (Fahrenheit - 32) * 5 / 9;
            return Math.Round(celsius, 2);
        }

        public double ConvertFahrenheitToKelvin()
        {
            var kelvin = (Fahrenheit - 32) * 5 / 9 + 273.15;
            return kelvin;
        }
    }
}