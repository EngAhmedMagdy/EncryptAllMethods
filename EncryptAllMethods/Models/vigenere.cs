using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EncryptAllMethods.Models
{
    public class vigenere
    {
 
        public String generateKey(String str, String key)
        {
            int x = str.Length;

            for (int i = 0; ; i++)
            {
                if (x == i)
                    i = 0;
                if (key.Length == str.Length)
                    break;
                key += (key[i]);
            }
            return key;
        }

        // This function returns the encrypted text 
        // generated with the help of the key 
        public String cipherText(String str, String key)
        {
            String cipher_text = "";

            for (int i = 0; i < str.Length; i++)
            {
                // converting in range 0-25 
                int x = (str[i] + key[i]) % 26;

                // convert into alphabets(ASCII) 
                x += 'A';

                cipher_text += (char)(x);
            }
            return cipher_text;
        }

        // This function decrypts the encrypted text 
        // and returns the original text 
        public String originalText(String cipher_text, String key)
        {
            String orig_text = "";

            for (int i = 0; i < cipher_text.Length &&
                                    i < key.Length; i++)
            {
                // converting in range 0-25 
                int x = (cipher_text[i] -
                            key[i] + 26) % 26;

                // convert into alphabets(ASCII) 
                x += 'A';
                orig_text += (char)(x);
            }
            return orig_text;
        }
    }
}