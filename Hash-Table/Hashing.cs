//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;

//namespace Hash_Table
//{
//    internal class Hashing
//    {
//        public string InputText;
//        public string OutputText;
//        byte[] Hash;
//        string[] StringHash;

//        public Hashing(string inputText)
//        {
//            InputText = inputText;
            
//        }

       
//        public void  HashCode(string binaryCode)
//        {
//            for (int i = binaryCode.Length; i >0 ; i--)
//            {
//                OutputText +=binaryCode[i];
//            }
//        }
//        public string DivideInputText(string text)
//        {
//            StringBuilder newText = new StringBuilder();
//            for (int i = 0; i < text.Length; i+=4)
//            {
//                text[i] += ".";
//            }
//        }
//        public new void GetHashCode()
//        {
//            Hash =  stringToASSCII(InputText);

//            string binary = ASSCIIToBinary(Hash);
//            ByteToString();
//            FillBytes();
//            long dec = BinaryToDecimal(binary);
//            Console.WriteLine(dec);
//        }
//        public void ByteToString()
//        {
//            StringHash = new string[Hash.Length + (Hash.Length / 4)];
//            for (int i = 0; i < StringHash.Length; i++)
//            {if (i % 4 == 0)
//                    StringHash[i] = stringToASSCII(".").ToString();
//                StringHash[i] = Hash[i].ToString();
//            }
//        }
//        private byte[] stringToASSCII(string text)
//        {
//            return Encoding.ASCII.GetBytes(text); 
//        }
//        private void FillBytes()
//        {
//            for (int i = 0; i < StringHash.Length; i++)
//            {
//                if (StringHash[i].Length < 8)
//                {
//                    StringHash[i] = (FillZeros(StringHash[i]));
//                }
//            }
//        }
//        private string FillZeros(string digits)
//        {
//            while (digits.Length < 8)
//            {
//                digits = "0" + digits;
//            }
//            return digits;
//        }
//        private string ASSCIIToBinary(byte[] asciiCode)
//        {
//            string binary = string.Empty;
//            for (int i = asciiCode.Length-1; i > 0; i--)
//            {
//                binary += Convert.ToString(asciiCode[i], 2);
//            }
           
//            return binary;
//        }
//        private long BinaryToDecimal(string binaryCode)
//        {
//           long dec =  Convert.ToInt64("bianryCode", 2);
//            return dec;

//        }


//    }
//}
