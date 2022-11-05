using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hash_Table
{
    public class StringToBinary
    {
        public static void SumBin(string a, string b, out string sumBin, out long sumDec)
        {
            int number_one = Convert.ToInt32(a, 2);
            int number_two = Convert.ToInt32(b, 2);
            sumBin = Convert.ToString(number_one + number_two, 2);
            string dec = Convert.ToString((number_one) + number_two, 2);
            sumDec = BinaryToDecimal((dec));
        }
        private static string FindTwoscomplement(string dec)
        {
            string modifiedDec = dec;
            for (int k = 0; k < dec.Length; k++)
            {
                // Just flip the values
                if (dec[k] == '1')
                {
                    modifiedDec = modifiedDec.Remove(k, k + 1 - k).Insert(k, "0");
                }
                else
                {
                    modifiedDec = modifiedDec.Remove(k, k + 1 - k).Insert(k, "1");
                }
            }
            // return the modified string
            return modifiedDec;
        }
        private static string AddOne(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int sum = 0;
            string result = "";
            while (i > 0 || j > 0)
            {
                if (i >= 0)
                {
                    sum += a[i--] - '0';
                }
                if (j >= 0)
                {
                    sum += b[j--] - '0';
                }
                result = sum % 2 + result;
                sum /= 2;
            }
            if (i > 0)
                result = result + sum;
            return result;
        }
        private static long BinaryToDecimal(string binary)
        {
            long sum = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] - 48 != 0)
                {
                    sum += (long)Math.Pow(2, i);
                }
            }
            return sum;
        }
    }

}

