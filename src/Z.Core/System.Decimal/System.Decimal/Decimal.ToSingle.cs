// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of the specified  to the equivalent single-precision floating-point number.
    /// </summary>
    /// <param name="d">The decimal number to convert.</param>
    /// <returns>A single-precision floating-point number equivalent to the value of .</returns>
    public static Single ToSingle(this Decimal d)
    {
        return Decimal.ToSingle(d);
    }
}