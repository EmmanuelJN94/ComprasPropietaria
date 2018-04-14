using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Compras.Code
{
    public static class Utilities
    {
        public static bool IsNumber(string text)
        {
            if (text.StartsWith("0") || text.StartsWith("1") || text.StartsWith("2") || text.StartsWith("3") || text.StartsWith("4") || text.StartsWith("5") || text.StartsWith("6") || text.StartsWith("7") || text.StartsWith("8") || text.StartsWith("9"))
                return true;
            else
                return false;
        }
    }
}