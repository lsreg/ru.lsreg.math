using System;

public static class BinarySearch
{
    public static int Search<T>(T[] data, T value) where T : IComparable
    {
        var left = data.GetLowerBound(0);
        var right = data.GetUpperBound(0);
        if (left == right)
            return left;
        while (true)
        {
            if (right - left == 1)
            {
                if (data[left].CompareTo(value) == 0)
                    return left;
                if (data[right].CompareTo(value) == 0)
                    return right;
                return -1;
            }
            else
            {
                var middle = left + (right - left) / 2;
                var comparisonResult = data[middle].CompareTo(value);
                if (comparisonResult == 0)
                    return middle;
                if (comparisonResult < 0)
                    left = middle;
                if (comparisonResult > 0)
                    right = middle;
            }
        }
    }
}