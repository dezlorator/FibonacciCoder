using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCoder
{
    class DecodeString
    {
        private string string_to_decode;
        private Dictionary<string, char> Symbol_unique_code;
        public DecodeString(string str_to_decode, List<Symbol>Code_Symbol)
        {
            string_to_decode = str_to_decode;
            Symbol_unique_code = new Dictionary<string, char>();
            for (int i = 0; i < Code_Symbol.Count; i++)
            {
                Symbol_unique_code.Add(Code_Symbol[i].Coding.Remove(Code_Symbol[i].Coding.Length - 1), Code_Symbol[i].Name);
            }
        }
        public string Decode_String()
        {
            string decoded_string = "";
            int begin = 0, length = 0;
            int i;
            for (i = 0; i < string_to_decode.Length; i++)
            {
                length++;
                if (string_to_decode[i] == '1' && string_to_decode[i + 1] == '1')
                {
                    decoded_string += Symbol_unique_code[string_to_decode.Substring(begin, length)];
                    begin += length + 1;
                    length = 0;
                    i++;
                }
            }
            return decoded_string;
        }
    }
}
