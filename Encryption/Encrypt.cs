using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal class Encrypt
    {
        public string Encryption(string input)
        {
            byte[] array = Encoding.ASCII.GetBytes(input);
            string text = "";
            foreach (byte numbers in array)
            {
                var whatever = numbers;
                whatever++;
                char character = (char)whatever;
                text += Char.ConvertFromUtf32(whatever);
            }
            return text;
        }
    }
}
