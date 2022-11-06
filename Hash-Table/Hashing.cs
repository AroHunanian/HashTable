using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



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
        /// <summary>
        /// Get Hash Code
        /// </summary>
        public new void GetHashCode()
        {
            Binary sum = new Binary();

            for (int i = 0; i < InputText.Length; i += 4)
            {
                if (i + 4 < InputText.Length)
                {
                    Hash = stringToASCII(InputText.Substring(i, 4));
                    Binary binary = new Binary(ASCIIToBinary(Hash));
                    sum += binary;
                    Console.WriteLine(binary.ToString());
                    if (i + 8 > InputText.Length)
                        Console.WriteLine(BinaryToDecimal(sum));
                    else
                        Console.WriteLine(StringToBinary.SignedDecimal(sum));
                }
                else
                {
                    Hash = stringToASCII(InputText.Substring(i, InputText.Length - i));
                    Binary binary = new Binary(ASCIIToBinary(Hash));
                    sum += binary;
                    Console.WriteLine(BinaryToDecimal(sum));
                }
            }
        }
        /// <summary>
        /// Get ASSCII code from given string.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>ASCII byte[]   </returns>
        private byte[] stringToASCII(string text)
             => Encoding.ASCII.GetBytes(text);
        /// <summary>
        /// Fill Binary code to 8-bit.
        /// </summary>
        /// <param name="binary"></param>
        /// <returns>8-bit Binary</returns>
        private string FillBytes(string binary)
             => binary = FillZeros(binary);
        /// <summary>
        /// Fill zeroes in front of given Binary code.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns>8-bit Binary code</returns>
        private string FillZeros(string digits)
        {
            while (digits.Length < 8)
            {
                digits = "0" + digits;
            }
            return digits;
        }
        /// <summary>
        /// Get Binary from given ASCII code.
        /// </summary>
        /// <param name="asciiCode"></param>
        /// <returns>Binary code</returns>
        private string ASCIIToBinary(byte[] asciiCode)
        {
            string binary = string.Empty;
            for (int i = asciiCode.Length - 1; i >= 0; i--)
            {
                binary += FillBytes(Convert.ToString(asciiCode[i], 2));
            }

            return binary;
        }
        /// <summary>
        /// Get Decimal from given Binary code.
        /// </summary>
        /// <param name="binaryCode"></param>
        /// <returns>Decimal value </returns>
        private long BinaryToDecimal(Binary binaryCode)
             => Convert.ToInt64(binaryCode.ToString(), 2);

    }
}
