using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_GUI_PresentationLayer.Utilities
{
    public class Validation
    {
        public static bool checkSDT(string text)
        {
            return Regex.IsMatch(text, @"^(0)[0-9]{9}$");
        }

        public static bool checkEmail(string text)
        {
            return Regex.IsMatch(text, @"^\w+(@gmail.com)$");
        }

        public static bool checkHoTen(string text)
        {
            return Regex.IsMatch(text, @"^[\D]+$");
        }
        public static bool checkCCCD(string text)
        {
            return Regex.IsMatch(text, @"^(0)[0-9]{11}$");
        }
    }
}
