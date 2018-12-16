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

        [Fact]
        public void TestMultiplyMatrixByMatrix()
        {
            var testMatrix = new Matrix(1, 2);
            testMatrix[0, 0] = 1;
            testMatrix[0, 1] = -1;
            var testMatrix2 = new Matrix(2, 3);
            testMatrix2[0, 0] = 1;
            testMatrix2[0, 1] = -1;
            testMatrix2[0, 2] = 7;
            testMatrix2[1, 0] = 1.1;
            testMatrix2[1, 1] = 0;
            testMatrix2[1, 2] = 1;
            var multipliedMatrix = testMatrix * testMatrix2;
            Assert.Equal(multipliedMatrix.M, testMatrix.M);
            Assert.Equal(multipliedMatrix.N, testMatrix2.N);            
            TestHelpers.AssertDoubleEqual(multipliedMatrix[0, 0], -0.1);
            TestHelpers.AssertDoubleEqual(multipliedMatrix[0, 1], -1);
            TestHelpers.AssertDoubleEqual(multipliedMatrix[0, 2], 6);
        }
    }
}
