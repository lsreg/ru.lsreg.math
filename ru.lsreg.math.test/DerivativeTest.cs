using System;
using Xunit;
using ru.lsreg.math;

namespace ru.lsreg.math.test
{
    public class DerivativeTest
    {
        [Fact]
        public void Test1()
        {
            Func<double, double> function = x => x * x;
            double point = 1;
            double expectedDerivative = 2;
            double epsilon = 0.0001;
            Assert.InRange(new Derivative().GetDerivative(function, point) - expectedDerivative, -epsilon, epsilon);
        }
    }
}
