using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EncryptAllMethods.Models
{
    public class Caesar_Cipher
    {
        public char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }
    }
}