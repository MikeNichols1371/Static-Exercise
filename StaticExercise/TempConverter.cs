using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double x)
        {
            return (x - 32) * .5556;
        }

        public static double CelsiusToFahrenheit(double y)
        {
            return (y * 1.8) + 32;
        }


    }
}
