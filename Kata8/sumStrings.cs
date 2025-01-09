using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata8
{
    public class sumStrings
    {
        // https://www.codewars.com/kata/5324945e2ece5e1f32000370/train/csharp
        public static string sumString(string a, string b)
        {
            if (string.IsNullOrEmpty(a)) a = "0";
            if (string.IsNullOrEmpty(b)) b = "0";

            StringBuilder result = new StringBuilder();
            int carry = 0;
            int i = a.Length - 1, j = b.Length - 1;

            while (i >= 0 || j >= 0 || carry != 0)
            {
                int sum = carry;

                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }

                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                carry = sum / 10;
                result.Insert(0, sum % 10);
            }

            string finalResult = result.ToString().TrimStart('0');

            return string.IsNullOrEmpty(finalResult) ? "0" : finalResult;
        }
    }
}
