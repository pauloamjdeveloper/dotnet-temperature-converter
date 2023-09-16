using TemperatureConverter.App.Interfaces;

namespace TemperatureConverter.App.Entities
{
    public class ConvertCelsius : IConvertCelsius
    {
        private double _celsius;

        public double Celsius
        {
            get { return _celsius; }
            private set { _celsius = value; }
        }

        public ConvertCelsius(double celsius)
        {
            Celsius = celsius;
        }

        public double ConvertCelsiusToFahrenheit()
        {
            try
            {
                var fahrenheit = (_celsius * 9 / 5) + 32;
                return Math.Round(fahrenheit, 2);
            }
            catch (Exception exception)
            {
                throw new Exception($"Error Convert Celsius To Fahrenheit: {exception.Message}" );
            }
        }

        public double ConvertCelsiusToKelvin()
        {
            try
            {
                var kelvin = _celsius - 273.15;
                return Math.Round(kelvin, 2);
            }
            catch (Exception exception)
            {
                throw new Exception($"Error Convert Celsius To Kelvin: {exception.Message}" );
            }
        }
    }
}