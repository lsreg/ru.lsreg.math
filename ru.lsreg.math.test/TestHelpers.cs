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
}