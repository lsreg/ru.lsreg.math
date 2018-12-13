using System;
using Xunit;
using ru.lsreg.math;

namespace ru.lsreg.math.test
{
    public class MatrixTest
    {
        [Fact]
        public void TestMultiplyMatrixByNumber()
        {
            var testMatrix = new Matrix(2, 3);
            testMatrix[0, 0] = 1;
            testMatrix[0, 1] = -1;
            testMatrix[0, 2] = 7;
            testMatrix[1, 0] = 1.1;
            testMatrix[1, 1] = 0;
            testMatrix[1, 2] = 1;
            var multipliedMatrix = testMatrix * 2.1;
            TestHelpers.AssertDoubleEqual(multipliedMatrix[0, 0], 2.1);
            TestHelpers.AssertDoubleEqual(multipliedMatrix[0, 1], -2.1);
            TestHelpers.AssertDoubleEqual(multipliedMatrix[0, 2], 14.7);
            TestHelpers.AssertDoubleEqual(multipliedMatrix[1, 0], 2.31);
            TestHelpers.AssertDoubleEqual(multipliedMatrix[1, 1], 0);
            TestHelpers.AssertDoubleEqual(multipliedMatrix[1, 2], 2.1);
        }
    }
}
