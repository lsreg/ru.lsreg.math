using Xunit;
using Xunit.Sdk;
using System;

public static class TestHelpers 
{
    public static void AssertDoubleEqual(double expected, double actual)
    {
        try
        {
            Assert.InRange(expected - actual, -Constants.DoubleComparisonDelta, Constants.DoubleComparisonDelta);
        }
        catch (InRangeException)
        {
            throw new EqualException(expected, actual);
        }
    }

    public static void AssertMatrixEqual(Matrix expected, Matrix actual)
    {
        Assert.Equal(expected.M, actual.M);
        Assert.Equal(expected.N, actual.N);
        for (var i = 0; i < expected.M; i++)
            for (var j = 0; j < expected.N; j++)
                AssertDoubleEqual(expected[i, j], actual[i, j]);
    }
}