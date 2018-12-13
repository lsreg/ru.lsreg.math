using System;
using System.Collections.Generic;
using Xunit;
using ru.lsreg.math;

namespace ru.lsreg.math.test
{
    public class GradientDescentTest
    {
        private double TestFunction(List<double> point)
        {
            if (point.Count != 5)
            throw new ArgumentException("Size of vector should be 5");
            double result = 0;
            foreach(var value in point)
                result += (value - 2) * (value - 2);
            return result;
        }
        [Fact]
        public void TestGradientDescent()
        {
            Func<double, double> function = x => x * x;
            double expectedPointValue = 2;
            double epsilon = 0.0001;
            var minimumPoint = new GradientDescent().Calculate(new List<double>(){0,0,0,0,0}, TestFunction);
            Assert.Equal(minimumPoint.Count, 5);
            Assert.InRange(minimumPoint[0] - expectedPointValue, -epsilon, epsilon);
            Assert.InRange(minimumPoint[1] - expectedPointValue, -epsilon, epsilon);
            Assert.InRange(minimumPoint[2] - expectedPointValue, -epsilon, epsilon);
            Assert.InRange(minimumPoint[3] - expectedPointValue, -epsilon, epsilon);
            Assert.InRange(minimumPoint[4] - expectedPointValue, -epsilon, epsilon);
        }
    }
}
