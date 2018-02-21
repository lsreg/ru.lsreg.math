using System;

namespace ru.lsreg.math
{
    public class Derivative
    {
        private const double DEFAULT_DELTA = 0.0000001F;

        public double GetDerivative(Func<double, double> function, double point) {
            return GetDerivative(function, point, DEFAULT_DELTA);
        }

        public double GetDerivative(Func<double, double> function, double point, double delta) {
            double result = (function(point + delta) - function(point - delta)) / (2 * delta);
            return result;
        }
    }
}
