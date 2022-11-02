using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    internal class Hashing
    {
        public string InputText;
        public string OutputText;
        byte[] Hash;

        public Hashing(string inputText)
        {
            InputText = inputText;
            
        }

       
        public void  HashCode(string binaryCode)
        {
            
            for (int i = binaryCode.Length; i >0 ; i--)
            {
                OutputText +=binaryCode[i];
            }
        }
        public void GetHashCodeee()
        {
             stringToASSCII(InputText);
            string binary = ASSCIIToBinary(Hash);
            long dec = BinaryToDecimal(binary);
            Console.WriteLine(dec);
        }
       
        private byte[] stringToASSCII(string text)
        {

           Hash = Encoding.ASCII.GetBytes(text);
        
            return Hash;
        }
        private string ASSCIIToBinary(byte[] asciiCode)
        {
            string binary = string.Empty;
            for (int i = asciiCode.Length-1; i > 0; i--)
            {
                binary += Convert.ToString(asciiCode[i], 2);
            }
           
            return binary;
        }
        private long BinaryToDecimal(string binaryCode)
        {
           long dec =  Convert.ToInt64("bianryCode", 2);
            return dec;

        }


    }
}
