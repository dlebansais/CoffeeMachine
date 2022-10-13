namespace TestCoffeeMachine;

using System;
using System.Diagnostics;

internal static class TestTools
{
    // Compares equality of two doubles up to 1e-10 precision.
    // To account for different results when operations that should give the same result are implemented differently.
    public static bool IsDoubleEqual(double d1, double d2)
    {
        Debug.Assert(!double.IsNaN(d1));
        Debug.Assert(!double.IsNaN(d2));

        return Math.Abs(d2 - d1) < 1e-10;
    }
}
