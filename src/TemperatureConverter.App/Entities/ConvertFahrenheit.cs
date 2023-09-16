using TemperatureConverter.App.Interfaces;

namespace TemperatureConverter.App.Entities
{
    public class ConvertFahrenheit : IConvertFahrenheit
    {
        private double _fahrenheit;

        public double Fahrenheit
        {
            get { return _fahrenheit; }
            private set { _fahrenheit = value; }
        }

        public ConvertFahrenheit(double fahrenheit)
        {
            Fahrenheit = fahrenheit;
        }
        
        public double ConvertFahrenheitToCelsius()
        {
            try
            {
                var celsius = (_fahrenheit - 32) * 5 / 9;
                return Math.Round(celsius, 2);
            }
            catch (Exception exception)
            {
                throw new Exception($"Error convert Fahrenheit to Celsius: {exception.Message}" );
            }
        }

        public double ConvertFahrenheitToKelvin()
        {
            try
            {
                var kelvin = (_fahrenheit - 32) * 5 / 9 + 273.15;
                return Math.Round(kelvin, 2);
            }
            catch (Exception exception)
            {
                throw new Exception($"Error convert Fahrenheit to Kelvin: {exception.Message}" );
            }
        }
    }
}