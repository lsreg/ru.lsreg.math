namespace ru.lsreg.math
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    public class GradientDescent
    {
        private List<double> CopyPointWithReplace(List<double> point, double replace, int replaceIndex)
        {
            var result = new List<double>();
            for (var i = 0; i < point.Count; i++)
                if (i == replaceIndex)
                    result.Add(replace);
                else
                    result.Add(point[i]);

            return result;
        }

        public List<double> Calculate(List<double> startPoint, Func<List<double>, double> function)
        {
            double alpha = 1;
            var alphaDecreaseRate = 0.9;
            var currentPoint = startPoint;
            while (true)
            {
                var currentValue = function(currentPoint);
                var newPoint = new List<double>();
                for (var i = 0; i < currentPoint.Count; i++)
                {
                    Func<double, double> func = x => function(CopyPointWithReplace(currentPoint, x, i));
                    newPoint.Add(currentPoint[i] - alpha * (1.0 / Convert.ToDouble(startPoint.Count)) * new Derivative().GetDerivative(func, currentPoint[i]));
                }
                var newValue = function(newPoint);

                if (newValue > currentValue)
                    alpha *= alphaDecreaseRate;
                else
                {
                    if (currentValue - newValue <= Constants.DoubleComparisonDelta)
                        return newPoint;
                    else
                        currentPoint = newPoint;
                }
            }

        }
    }
}