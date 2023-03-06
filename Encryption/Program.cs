using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encrypt encrypt = new Encrypt();
            Decrypt decrypt = new Decrypt();
            Console.WriteLine("What do you wish to encrypt?");
            string inputEncrypt = Console.ReadLine();
            Console.WriteLine(encrypt.Encryption(inputEncrypt));

            Console.WriteLine("What do you wish to decrypt?");
            string inputDecrypt = Console.ReadLine();
            Console.WriteLine(decrypt.Decrypter(inputDecrypt));
            Console.ReadKey();
        }
    }
}
