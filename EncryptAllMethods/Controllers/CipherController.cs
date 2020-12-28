using EncryptAllMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EncryptAllMethods.Controllers
{
    public class CipherController : Controller
    {
        // GET: Cipher
        vigenere vigenere = new vigenere();
        Class1 rc = new Class1();
        Caesar_Cipher CC = new Caesar_Cipher();
        Monoalphabetic_Cipher MC = new Monoalphabetic_Cipher();
        playfair PF =new playfair();
        railfence RF = new railfence();
        intEncipher intencipher = new intEncipher();
        stringEncipher stringencipher = new stringEncipher();
        string AlphaKey = "zyxwvutsrqponmlkjihgfedcbaABCDEFGHIJKLMNOPQRSTUVWXYZ";

       
        [HttpGet]
        public ActionResult Caesar()
        {
            return View(intencipher);
        }
        [HttpPost]
        public ActionResult Caesar(string input,int key)
        {
            string output = string.Empty;

            foreach (char ch in input) output += CC.cipher(ch, key);

            intencipher.output = output;

            return View(intencipher);
        }
        [HttpGet]
        public ActionResult monoalphabetic()
        {
            return View(intencipher);
        }
        [HttpPost]
        public ActionResult monoalphabetic(string input)
        {

            intencipher.output = MC.Encrypt(input, AlphaKey);
            return View(intencipher);
        }

        [HttpGet]
        public ActionResult playfair()
        {
            return View(stringencipher);
        }
        [HttpPost]
        public ActionResult playfair(string input, string key)
        {
            stringencipher.output =PF.Cipher(input, key, true);
            return View(stringencipher);
        }

        [HttpGet]
        public ActionResult railfence()
        {
            return View(stringencipher);
        }
        [HttpPost]
        public ActionResult railfence(string input)
        {
            int key = 3;
            stringencipher.output =RF.Cipher(input, key);
            return View(stringencipher);
        }
        [HttpGet]
        public ActionResult vigenere_view()
        {
            
            return View(stringencipher);

        }
        [HttpPost]
        public ActionResult vigenere_view(string input, string key)
        {
            string vkey =vigenere.generateKey(input, key);
            stringencipher.output = vigenere.cipherText(input, vkey);
            return View(stringencipher);

        }
        [HttpGet]
        public ActionResult Rc5()
        {
            rc.EncryptFile(@"Pictures\images.jpg", @"D:\VizioEncrypted.jpg");
            return View();
            
        }
    }
}