using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class Binary
    {
        string _binary { get; set; }
        public Binary()
        {

        }
        public Binary(string binary)
        {
            _binary = binary;
        }

        public static Binary operator +(Binary a, Binary b)
            => new Binary(Convert.ToString(Convert.ToInt32(a._binary, 2) +
                          Convert.ToInt32(b._binary, 2), 2));
        

        public override string ToString()
            => $"{_binary}";
        
    }
}
