﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaltwaterTaffy.Utility
{
    
    public static class StringExtensions
    {
        public static string Capitalize(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);

            return new string(a);
        }
    }
}
