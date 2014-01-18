﻿using System;
using YAMP.Attributes;
using YAMP.Core;
using YAMP.Numerics;

namespace YAMP.Core.Functions
{
    [Description("In mathematics, binomial coefficients are a family of positive integers that occur as coefficients in the binomial theorem. They are indexed by two nonnegative integers; the binomial coefficient indexed by n and r is usually written (n k). It is the coefficient of the x^k term in the polynomial expansion of the binomial power (1 + x)^n. Under suitable circumstances the value of the coefficient is given by the expression n! / (k! * (n - k)!). Arranging binomial coefficients into rows for successive values of n, and in which k ranges from 0 to n, gives a triangular array called Pascal's triangle.")]
    [Kind(KindAttribute.FunctionKind.Mathematics)]
    [Link("http://en.wikipedia.org/wiki/Binomial_coefficient")]
    sealed class NcrFunction : YFunction
    {
        [Description("Computes the value of r out of n, i.e. n choose r.")]
        [Example("ncr(8, 2)", "Computes 8! / (2! * 6!), which is 28.")]
        public Double Invoke(Int64 n, Int64 r)
        {
            return Helpers.Factorial(n) / (Helpers.Factorial(r) * Helpers.Factorial(n - r));
        }
    }
}
