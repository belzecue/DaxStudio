﻿using DaxStudio.UI.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaxStudio.UI.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum FilterType
    {
        [Description("Contains")]
        Contains,
        [Description("Does not contains")]
        DoesNotContain,
        [Description("Starts with")]
        StartsWith,
        [Description("Does not start with")]
        DoesNotStartWith,
        [Description("Is")]
        Is,
        [Description("Is not")]
        IsNot,
        [Description("Is blank")]
        IsBlank,
        [Description("Is not blank")]
        IsNotBlank
    }
}