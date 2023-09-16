using TemperatureConverter.App.Interfaces;

namespace TemperatureConverter.App.Entities
{
    public class ConvertKelvin : IConvertKelvin
    {
        private double _kelvin;

        public double Kelvin
        {
            get { return _kelvin; }
            private set { _kelvin = value; }
        }

        public ConvertKelvin(double kelvin)
        {
            Kelvin = kelvin;
        }
        
        public double ConvertKelvinToCelsius()
        {
            try
            {
                var celsius = _kelvin - 273.15;
                return Math.Round(celsius, 2);
            }
            catch (Exception exception)
            {
                throw new Exception($"Error convert Kelvin to Celsius: {exception.Message}" );
            }
        }

        public double ConvertKelvinToFahrenheit()
        {
            try
            {
                var fahrenheit = _kelvin - 273.75;
                return Math.Round(fahrenheit, 2);
            }
            catch (Exception exception)
            {
                throw new Exception($"Error convert Kelvin to Fahrenheit: {exception.Message}" );
            }
        }
    }
}