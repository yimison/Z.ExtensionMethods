// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that converts this object to an universal sortable long date time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToUniversalSortableLongDateTimeString(this DateTime @this)
    {
        return @this.ToString("U", DateTimeFormatInfo.CurrentInfo);
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to an universal sortable long date time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToUniversalSortableLongDateTimeString(this DateTime @this, string culture)
    {
        return @this.ToString("U", new CultureInfo(culture));
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to an universal sortable long date time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToUniversalSortableLongDateTimeString(this DateTime @this, CultureInfo culture)
    {
        return @this.ToString("U", culture);
    }
}