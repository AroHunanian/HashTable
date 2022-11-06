using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hash_Table
{
    public class StringToBinary
    {
        public static string SumBin(string a, string b)
        {
            return Convert.ToString(Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2), 2);

        }
        public static long SumDec(string a,string b)
        {
            return   BinaryToDecimal(SumBin(a,b));
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
        private static string AddOne(string a)
        {
            string one = "00000000000000000000000000000001";
            return Convert.ToString(Convert.ToInt32(a, 2) + Convert.ToInt32(one, 2), 2);
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
            return sum * -1;
        }
        public static long SignedDecimal(Binary binary)
        {


           return(
                    BinaryToDecimal(
                    AddOne(
                    FindTwoscomplement(binary.ToString() ))));
        }
    }

}

