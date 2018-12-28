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

        [Fact]
        public void TestMatrixAddition()
        {
            var testMatrix = new Matrix(1, 2);
            testMatrix[0, 0] = 1;
            testMatrix[0, 1] = 3;
            var testMatrix2 = new Matrix(1, 2);
            testMatrix2[0, 0] = 2;
            testMatrix2[0, 1] = -1;
            var resultMatrix = testMatrix + testMatrix2;
            TestHelpers.AssertDoubleEqual(resultMatrix[0, 0], 3);
            TestHelpers.AssertDoubleEqual(resultMatrix[0, 1], 2);
        }

        [Fact]
        public void TestMatrixSubstraction()
        {
            var testMatrix = new Matrix(1, 2);
            testMatrix[0, 0] = 1;
            testMatrix[0, 1] = 3;
            var testMatrix2 = new Matrix(1, 2);
            testMatrix2[0, 0] = 2;
            testMatrix2[0, 1] = -1;
            var resultMatrix = testMatrix - testMatrix2;
            TestHelpers.AssertDoubleEqual(resultMatrix[0, 0], -1);
            TestHelpers.AssertDoubleEqual(resultMatrix[0, 1], 4);
        }

        [Fact]
        public void TestCreateTransposeMatrix()
        {
            var testMatrix = new Matrix(1, 2);
            testMatrix[0, 0] = 1;
            testMatrix[0, 1] = 3;
            var transposeMatrix = testMatrix.CreateTransposeMatrix();
            Assert.Equal(transposeMatrix.M, 2);
            Assert.Equal(transposeMatrix.N, 1);

            TestHelpers.AssertDoubleEqual(transposeMatrix[0, 0], 1);
            TestHelpers.AssertDoubleEqual(transposeMatrix[1, 0], 3);
        }

        [Fact]
        public void TestMatrixIsSquare()
        {
            Assert.Equal(new Matrix(1, 2).IsSquare, false);
            Assert.Equal(new Matrix(2, 2).IsSquare, true);
        }

        [Fact]
        public void TestDeterminant()
        {
            var testMatrix = new Matrix(3, 3);
            testMatrix[0, 0] = 1;
            testMatrix[0, 1] = 3;
            testMatrix[0, 2] = -2;
            testMatrix[1, 0] = 1;
            testMatrix[1, 1] = 0;
            testMatrix[1, 2] = 7;
            testMatrix[2, 0] = 1;
            testMatrix[2, 1] = 1;
            testMatrix[2, 2] = -1;

            TestHelpers.AssertDoubleEqual(testMatrix.CalculateDeterminant(), 15);
            testMatrix[1, 1] = 2;
            TestHelpers.AssertDoubleEqual(testMatrix.CalculateDeterminant(), 17);
        }
    }
}
