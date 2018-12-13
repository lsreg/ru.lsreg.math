using Xunit;
using Xunit.Sdk;
using System;

public static class TestHelpers 
{
    private const double Delta = 0.001;
    public static void AssertDoubleEqual(double expected, double actual)
    {
        try
        {
            Assert.InRange(expected - actual, -Delta, Delta);
        }
        catch (InRangeException)
        {
            throw new EqualException(expected, actual);
        }
    }
}