using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


namespace Hash_Table
{
    internal class Hashing
    {
        public string InputText;
        byte[] Hash;

        public Hashing(string inputText)
        {
            InputText = inputText;

        }

        public new void GetHashCode()
        {
            Binary sum = new Binary();

            for (int i = 0; i < InputText.Length; i += 4)
            {
                if (i + 4 < InputText.Length)
                {
                    Hash = stringToASSCII(InputText.Substring(i, 4));
                    Binary binary = new Binary(ASSCIIToBinary(Hash));
                    sum += binary;
                    Console.WriteLine(binary.ToString());
                    if (i + 8 > InputText.Length)
                        Console.WriteLine(BinaryToDecimal(sum));
                    else
                        Console.WriteLine(StringToBinary.SignedDecimal(sum));
                }
                else
                {
                    Hash = stringToASSCII(InputText.Substring(i, InputText.Length - i));
                    Binary binary = new Binary(ASSCIIToBinary(Hash));
                    sum += binary;
                    Console.WriteLine(BinaryToDecimal(sum));
                }
            }
        }

        private byte[] stringToASSCII(string text)
             => Encoding.ASCII.GetBytes(text);

        private string FillBytes(string binary)
             => binary = FillZeros(binary);

        private string FillZeros(string digits)
        {
            while (digits.Length < 8)
            {
                digits = "0" + digits;
            }
            return digits;
        }
        private string ASSCIIToBinary(byte[] asciiCode)
        {
            string binary = string.Empty;
            for (int i = asciiCode.Length - 1; i >= 0; i--)
            {
                binary += FillBytes(Convert.ToString(asciiCode[i], 2));
            }

            return binary;
        }
        private long BinaryToDecimal(Binary binaryCode)
             => Convert.ToInt64(binaryCode.ToString(), 2);

    }
}
